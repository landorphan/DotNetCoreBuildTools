﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.3.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Landorphan.Abstractions.FileSystem.Paths.UnitTests.Specifications.Path.Posix
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Posix Path Segments")]
    [NUnit.Framework.CategoryAttribute("Check-In")]
    public partial class PosixPathSegmentsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "Check-In"};
        
#line 1 "PosixPathSegments.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Posix Path Segments", "\tIn order to develop a reliable Windows Path parser \r\n\tAs a member of the Landorp" +
                    "han Team\r\n\tI want to to be able to convert incoming paths into a more managable " +
                    "form", ProgrammingLanguage.CSharp, new string[] {
                        "Check-In"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Posix Segmenter generates the following segments")]
        [NUnit.Framework.TestCaseAttribute("(null)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("(empty)", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:/", "{G} C:", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir/file.txt", "{G} C:", "{G} dir", "{G} file.txt", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir/file.txt/", "{G} C:", "{G} dir", "{G} file.txt", "{E} (empty)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir", "{G} C:", "{G} dir", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir/", "{G} C:", "{G} dir", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir//file.txt", "{G} C:", "{G} dir", "{E} (empty)", "{G} file.txt", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:./file.txt", "{G} C:.", "{G} file.txt", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:./file.txt/", "{G} C:.", "{G} file.txt", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:file.txt", "{G} C:file.txt", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:file.txt/", "{G} C:file.txt", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir", "{G} C:dir", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir/", "{G} C:dir", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir/file.txt", "{G} C:dir", "{G} file.txt", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir/file.txt/", "{G} C:dir", "{G} file.txt", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share", "{U} server", "{G} share", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share/", "{U} server", "{G} share", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("//server/file.txt", "{U} server", "{G} file.txt", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("//server/file.txt/", "{U} server", "{G} file.txt", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share/dir/file.txt", "{U} server", "{G} share", "{G} dir", "{G} file.txt", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share/dir/file.txt/", "{U} server", "{G} share", "{G} dir", "{G} file.txt", "{E} (empty)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("//?/C:/dir/file.txt", "{U} ?", "{G} C:", "{G} dir", "{G} file.txt", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("//?/C:/dir/file.txt/", "{U} ?", "{G} C:", "{G} dir", "{G} file.txt", "{E} (empty)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("//?/UNC/server/share/dir/file.txt", "{U} ?", "{G} UNC", "{G} server", "{G} share", "{G} dir", "{G} file.txt", null)]
        [NUnit.Framework.TestCaseAttribute("//?/UNC/server//file.txt/", "{U} ?", "{G} UNC", "{G} server", "{E} (empty)", "{G} file.txt", "{E} (empty)", null)]
        [NUnit.Framework.TestCaseAttribute("/dir/file.txt/", "{R} dir", "{G} file.txt", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute(".", "{.} .", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("./", "{.} .", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("./file.txt", "{.} .", "{G} file.txt", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("./file.txt/", "{.} .", "{G} file.txt", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("./dir", "{.} .", "{G} dir", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("./dir/", "{.} .", "{G} dir", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("./dir/file.txt", "{.} .", "{G} dir", "{G} file.txt", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("./dir/file.txt/", "{.} .", "{G} dir", "{G} file.txt", "{E} (empty)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("..", "{..} ..", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("../", "{..} ..", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("../dir/file.txt", "{..} ..", "{G} dir", "{G} file.txt", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("../dir/file.txt/", "{..} ..", "{G} dir", "{G} file.txt", "{E} (empty)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("CON", "{G} CON", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:/CON", "{G} C:", "{G} CON", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("../CON", "{..} ..", "{G} CON", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("/dir/CON", "{R} dir", "{G} CON", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server", "{U} server", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server/", "{U} server", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server/share", "{U} server", "{G} share", "{N} (null)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server/share/", "{U} server", "{G} share", "{E} (empty)", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server/share/dir", "{U} server", "{G} share", "{G} dir", "{N} (null)", "{N} (null)", "{N} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server/share/dir/", "{U} server", "{G} share", "{G} dir", "{E} (empty)", "{N} (null)", "{N} (null)", null)]
        public virtual void PosixSegmenterGeneratesTheFollowingSegments(string path, string segment0, string segment1, string segment2, string segment3, string segment4, string segment5, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Path", path);
            argumentsOfScenario.Add("Segment 0", segment0);
            argumentsOfScenario.Add("Segment 1", segment1);
            argumentsOfScenario.Add("Segment 2", segment2);
            argumentsOfScenario.Add("Segment 3", segment3);
            argumentsOfScenario.Add("Segment 4", segment4);
            argumentsOfScenario.Add("Segment 5", segment5);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Posix Segmenter generates the following segments", null, tagsOfScenario, argumentsOfScenario);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given(string.Format("I have the following path: {0}", path), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
  testRunner.When("I segment the Posix path", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
  testRunner.Then(string.Format("segment \'0\' should be: {0}", segment0), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
     testRunner.And(string.Format("segment \'1\' should be: {0}", segment1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
     testRunner.And(string.Format("segment \'2\' should be: {0}", segment2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
     testRunner.And(string.Format("segment \'3\' should be: {0}", segment3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
     testRunner.And(string.Format("segment \'4\' should be: {0}", segment4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
