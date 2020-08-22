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
namespace Landorphan.Abstractions.FileSystem.Paths.UnitTests.Specifications.Path.Windows
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Windows Path Segments")]
    [NUnit.Framework.CategoryAttribute("Check-In")]
    public partial class WindowsPathSegmentsFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "Check-In"};
        
#line 1 "WindowsPathSegments.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Windows Path Segments", "\tIn order to develop a reliable Windows Path parser \r\n\tAs a member of the Landorp" +
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
        [NUnit.Framework.DescriptionAttribute("Windows Segmenter generates the following segments")]
        [NUnit.Framework.TestCaseAttribute("(null)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("(empty)", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:`", "{R} C", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:`dir`file.txt", "{R} C", "{G} dir", "{G} file.txt", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:`dir`file.txt`", "{R} C", "{G} dir", "{G} file.txt", "{E} (empty)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:`dir", "{R} C", "{G} dir", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:`dir`", "{R} C", "{G} dir", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:`dir``file.txt", "{R} C", "{G} dir", "{E} (empty)", "{G} file.txt", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:.`file.txt", "{V} C", "{S} .", "{G} file.txt", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:.`file.txt`", "{V} C", "{S} .", "{G} file.txt", "{E} (empty)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:file.txt", "{V} C", "{G} file.txt", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:file.txt`", "{V} C", "{G} file.txt", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir", "{V} C", "{G} dir", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir`", "{V} C", "{G} dir", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir`file.txt", "{V} C", "{G} dir", "{G} file.txt", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir`file.txt`", "{V} C", "{G} dir", "{G} file.txt", "{E} (empty)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("``server`share", "{X} server", "{G} share", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("``server`share`", "{X} server", "{G} share", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("``server`file.txt", "{X} server", "{G} file.txt", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("``server`file.txt`", "{X} server", "{G} file.txt", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("``server`share`dir`file.txt", "{X} server", "{G} share", "{G} dir", "{G} file.txt", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("``server`share`dir`file.txt`", "{X} server", "{G} share", "{G} dir", "{G} file.txt", "{E} (empty)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("``?`C:`dir`file.txt", "{R} C", "{G} dir", "{G} file.txt", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("``?`C:`dir`file.txt`", "{R} C", "{G} dir", "{G} file.txt", "{E} (empty)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("``?`UNC`server`share`dir`file.txt", "{X} server", "{G} share", "{G} dir", "{G} file.txt", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("``?`UNC`server`share`dir`file.txt`", "{X} server", "{G} share", "{G} dir", "{G} file.txt", "{E} (empty)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("`dir`file.txt`", "{$}", "{G} dir", "{G} file.txt", "{E} (empty)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute(".", "{S} .", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute(".`", "{S} .", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute(".`file.txt", "{S} .", "{G} file.txt", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute(".`file.txt`", "{S} .", "{G} file.txt", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute(".`dir", "{S} .", "{G} dir", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute(".`dir`", "{S} .", "{G} dir", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute(".`dir`file.txt", "{S} .", "{G} dir", "{G} file.txt", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute(".`dir`file.txt`", "{S} .", "{G} dir", "{G} file.txt", "{E} (empty)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("..", "{P} ..", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("..`", "{P} ..", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("..`dir`file.txt", "{P} ..", "{G} dir", "{G} file.txt", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("..`dir`file.txt`", "{P} ..", "{G} dir", "{G} file.txt", "{E} (empty)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("CON", "{D} CON", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("C:`CON", "{R} C", "{D} CON", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("..`CON", "{P} ..", "{D} CON", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("`dir`CON", "{$}", "{G} dir", "{D} CON", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server", "{X} server", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server`", "{X} server", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server`share", "{X} server", "{G} share", "{0} (null)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server`share`", "{X} server", "{G} share", "{E} (empty)", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server`share`dir", "{X} server", "{G} share", "{G} dir", "{0} (null)", "{0} (null)", "{0} (null)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server`share`dir`", "{X} server", "{G} share", "{G} dir", "{E} (empty)", "{0} (null)", "{0} (null)", null)]
        public virtual void WindowsSegmenterGeneratesTheFollowingSegments(string path, string segment0, string segment1, string segment2, string segment3, string segment4, string segment5, string[] exampleTags)
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
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Windows Segmenter generates the following segments", null, tagsOfScenario, argumentsOfScenario);
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
  testRunner.When("I segment the Windows path", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
