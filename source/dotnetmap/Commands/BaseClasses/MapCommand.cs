using System.Collections.Generic;
using System.CommandLine;
using System.IO;

namespace dotnetmap.Commands
{
    public abstract class MapCommand : Command
    {
        protected Option<FileInfo> MapFileArgument;
        protected virtual string DescriptionMapFile { get; private set; } = "The path to the map file to create.";

        protected MapCommand(string name, string description = null) : base(name, description)
        {
            MapFileArgument = new Option<FileInfo>(new[] {"--map", "-m"}, DescriptionMapFile)
            {
                IsRequired = true
            };
            this.AddOption(MapFileArgument);
        }
    }
}