using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using DotNet.Globbing;
using Landorphan.BuildMap.Abstractions;
using Landorphan.BuildMap.Construction.SolutionModel;
using Landorphan.BuildMap.Model;

namespace Landorphan.BuildMap.Construction
{
    using System.Xml.Linq;
    using System.Xml.XPath;
    using Landorphan.Common;
    using Onion.SolutionParser.Parser;
    using Onion.SolutionParser.Parser.Model;
    using YamlDotNet.Core.Tokens;

    public class MapManagement
    {
        public IEnumerable<FilePaths> LocateFiles(string workingDirectory, IEnumerable<string> globPatterns)
        {
            var fs = AbstractionManager.GetFileSystem();
            if (string.IsNullOrWhiteSpace(workingDirectory))
            {
                workingDirectory = fs.GetWorkingDirectory();
            }
            List<FilePaths> retval = new List<FilePaths>();
            var globs =
                (from g in globPatterns
               select Glob.Parse(g));
            var files = fs.GetFiles(workingDirectory);
            foreach (var file in files)
            {
                foreach (var glob in globs)
                {
                    if (glob.IsMatch(file.Absolute))
                    {
                        retval.Add(file);
                        break;
                    }
                }
            }
            return retval;
        }

        // public List<SuppliedFile> GetSuppliedFiles(IEnumerable<string> locatedFiles)
        // {
        //     List<SuppliedFile> retval = new List<SuppliedFile>();
        //     foreach (var file in locatedFiles)
        //     {
        //         var suppliedFile = GetSuppliedFile(file);
        //         retval.Add(suppliedFile);
        //     }
        //
        //     return retval;
        // }

        private readonly Guid SolutionFolderGuid = new Guid("2150E333-8FDC-42A3-9474-1A3956D46DE8");
//        private readonly Guid SharedProjectGuid = new Guid("D954291E-2A0B-460D-934E-DC6B0785DB48");
        
        public void IncorporateSolutionFileProjects(MapFiles mapFiles)
        {
            var fs = AbstractionManager.GetFileSystem();
            foreach (var solutionFile in mapFiles.GetAllSolutionFiles().Where(sf => sf.Status == FileStatus.Valid))
            {
                Dictionary<Guid, Project> solutionProjects = new Dictionary<Guid, Project>(
                (   from sp in solutionFile.SolutionContents.Projects
                   where sp.TypeGuid != SolutionFolderGuid 
                  select new KeyValuePair<Guid, Project>(sp.Guid, sp)));
                // First pass through ... create the ProjectFile entries and map
                // sln guids to HashGuids.
                foreach (var projectReference in solutionProjects)
                {
                    var slnGuid = projectReference.Key;
                    var projectReferencePath = fs.CombinePaths(solutionFile.Directory, projectReference.Value.Path);
                    if (mapFiles.TryGetProjectFileBySafePath(projectReferencePath, out var projectFile))
                    {
                        solutionFile.SlnGuidToHashGuidLookup.Add(slnGuid, projectFile.Id);
                        projectFile.SolutionFiles.Add(solutionFile);
                    }
                }
                // Second pass through ... map dependency projects.
                foreach (var projectReference in solutionProjects)
                {
                    var currentProjectHashGuid = solutionFile.SlnGuidToHashGuidLookup[projectReference.Value.Guid];
                    if (mapFiles.TryGetProjectFileByHashId(currentProjectHashGuid, out var currentProjectFile))
                    {
                        if (projectReference.Value.ProjectSection != null)
                        {
                            foreach (var dependentOnSlnEntry in projectReference.Value.ProjectSection.Entries)
                            {
                                var dependencySlnGuid = new Guid(dependentOnSlnEntry.Key
                                    .Replace("{", string.Empty, StringComparison.Ordinal)
                                    .Replace("}", string.Empty, StringComparison.Ordinal));
                                var dependentOnHashGuid = solutionFile.SlnGuidToHashGuidLookup[dependencySlnGuid];
                                if (mapFiles.TryGetProjectFileByHashId(dependentOnHashGuid, out var dependentOnProject))
                                {
                                    if (!currentProjectFile.DependentOn.TryGetValue(dependentOnHashGuid, out _))
                                    {
                                        currentProjectFile.DependentOn.Add(dependentOnHashGuid, dependentOnProject);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public const string ProjectReferenceXPath = "/Project/ItemGroup/ProjectReference/@Include";

        public void MapProjectLevelDependenciesForProjectFile(MapFiles mapFiles, ProjectFile projectFile)
        {
            var fs = AbstractionManager.GetFileSystem();
            var projectReferences = (projectFile.ProjectContents.XPathEvaluate(ProjectReferenceXPath) 
                as IEnumerable<object>)?.Cast<XAttribute>();
            foreach (var include in projectReferences)
            {
                var includePath = fs.GetAbsolutePath(fs.CombinePaths(projectFile.Directory, include.Value));
                ProjectFile includedProjectFile;
                // Guid includedProjectHashGuid;
                // First attempt to lookup the project based on the "safe path".
                if (mapFiles.TryGetProjectFileBySafePath(includePath, out includedProjectFile) && 
                    !projectFile.DependentOn.TryGetValue(includedProjectFile.Id, out _))
                {
                    projectFile.DependentOn.Add(includedProjectFile.Id, includedProjectFile);
                }
                // I think after refactor this is no longer necissary but keeping the code until we test ... just in case.
                // else
                // {
                //     // The Safe path did not work ... attempt to resolve via hashGuid.
                //     var suppliedFile = GetSuppliedFile(includePath);
                //     includedProjectHashGuid = suppliedFile.Id;
                //     if (!mapFiles.ProjectFiles.TryGetValue(includedProjectHashGuid, out includedProjectFile))
                //     {
                //         // Finally try to load the project file
                //         includedProjectFile = LoadProjectFileContents(suppliedFile);
                //         mapFiles.SafeAddFile(includedProjectFile);
                //     }
                // }
            }
        }

        public void MapProjectLevelDependencies(MapFiles mapFiles)
        {
            foreach (var projectFile in mapFiles.GetAllProjectFiles())
            {
                if (projectFile.Status == FileStatus.Valid)
                {
                    MapProjectLevelDependenciesForProjectFile(mapFiles, projectFile);
                }
            }
        }

        // TODO: This needs to be moved to the extension system once its in place.
        public string DetermineProjectLanguage(ProjectFile projectFile)
        {
            var fs = AbstractionManager.GetFileSystem();
            var extension = fs.GetExtension(projectFile.Path);
            switch (extension)
            {
                case ".csproj":
                    return Language.CSharp;
                case ".fsproj":
                    return Language.FSharp;
                case ".vbproj":
                    return Language.VisualBasic;
                default:
                    return Language.Unknown;
            }
        }

        public Map ConvertMapFilesToMap(string workingDirectory, MapFiles mapFiles)
        {
            var fs = AbstractionManager.GetFileSystem();
            Map map = new Map();
            map.Build.RelativeRoot = workingDirectory;
            var projectFiles = mapFiles.GetAllProjectFiles();
            foreach (var projectFile in projectFiles)
            {
                var project = new Model.Project();
                project.Id = projectFile.Id;
                project.Language = DetermineProjectLanguage(projectFile);
                project.Name = fs.GetFileNameWithoutExtension(projectFile.Path);
                var solutionNames =
                (     from s in projectFile.SolutionFiles
                    select fs.GetFileName(s.Path));
                project.Solutions.AddRange(solutionNames);
                project.RelativePath = projectFile.Path;
                project.AbsolutePath = projectFile.AbsolutePath;
                project.RealPath = "TODO: ADD THIS";
                project.Status = projectFile.Status;
                project.DependentOn.AddRange(projectFile.DependentOn.Keys);
                map.Build.Projects.Add(project);
            }

            return map;
        }

        public Map Create(string workingDirectory, IEnumerable<string> globPatterns)
        {
            workingDirectory.ArgumentNotNullNorEmptyNorWhiteSpace(nameof(workingDirectory));
            
            var fs = AbstractionManager.GetFileSystem();
            workingDirectory = fs.NormalizePath(workingDirectory);
            IEnumerable<FilePaths> locatedFiles = LocateFiles(workingDirectory, globPatterns);
            MapFiles mapFiles = new MapFiles(workingDirectory); 
            mapFiles.PreprocessList(locatedFiles);

            IncorporateSolutionFileProjects(mapFiles);
            
            MapProjectLevelDependencies(mapFiles);
            
            return ConvertMapFilesToMap(workingDirectory, mapFiles);
        }
    }
}