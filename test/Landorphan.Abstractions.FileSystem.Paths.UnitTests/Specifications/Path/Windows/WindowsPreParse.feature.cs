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
    [NUnit.Framework.DescriptionAttribute("Windows Preparse")]
    [NUnit.Framework.CategoryAttribute("Check-In")]
    public partial class WindowsPreparseFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "Check-In"};
        
#line 1 "WindowsPreParse.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Windows Preparse", "\tIn order to develop a reliable Windows Path parser \r\n\tAs a member of the Landorp" +
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
        [NUnit.Framework.DescriptionAttribute("Windows Preparse converter creates managable strings for the tokenizer")]
        [NUnit.Framework.TestCaseAttribute("(null)", "(null)", "Null String", null)]
        [NUnit.Framework.TestCaseAttribute("(empty)", "(empty)", "Empty String", null)]
        [NUnit.Framework.TestCaseAttribute("C:`", "C:/", "Drive Root", null)]
        [NUnit.Framework.TestCaseAttribute("C:`dir`file.txt", "C:/dir/file.txt", "Drive + Dir + File", null)]
        [NUnit.Framework.TestCaseAttribute("C:`dir`file.txt`", "C:/dir/file.txt/", "Drive + Dir + File + Empty", null)]
        [NUnit.Framework.TestCaseAttribute("C:`dir", "C:/dir", "Drive + Dir", null)]
        [NUnit.Framework.TestCaseAttribute("C:`dir`", "C:/dir/", "Drive + Dir + Empty", null)]
        [NUnit.Framework.TestCaseAttribute("C:.`file.txt", "C:./file.txt", "Drive + File", null)]
        [NUnit.Framework.TestCaseAttribute("C:.`file.txt`", "C:./file.txt/", "Drive + File + Empty", null)]
        [NUnit.Framework.TestCaseAttribute("C:file.txt", "C:file.txt", "Volume + File", null)]
        [NUnit.Framework.TestCaseAttribute("C:file.txt`", "C:file.txt/", "Volume + File + Empty", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir", "C:dir", "Volume + Dir", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir`", "C:dir/", "Volume + Dir + Empty", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir`file.txt", "C:dir/file.txt", "Volume + Dir + File", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir`file.txt`", "C:dir/file.txt/", "Volume + Dir + File + Empty", null)]
        [NUnit.Framework.TestCaseAttribute("``server`share", "UNC:server/share", "UNC + Share", null)]
        [NUnit.Framework.TestCaseAttribute("``server`share`", "UNC:server/share/", "UNC + Share + Empty", null)]
        [NUnit.Framework.TestCaseAttribute("``server`file.txt", "UNC:server/file.txt", "this is illegal (but not the preparser)", null)]
        [NUnit.Framework.TestCaseAttribute("``server`file.txt`", "UNC:server/file.txt/", "again illegal", null)]
        [NUnit.Framework.TestCaseAttribute("``server`share`dir`file.txt", "UNC:server/share/dir/file.txt", "Server + Share + Dir + File", null)]
        [NUnit.Framework.TestCaseAttribute("``server`share`dir`file.txt`", "UNC:server/share/dir/file.txt/", "Server + Share + Dire + File + Empty", null)]
        [NUnit.Framework.TestCaseAttribute("``?`C:`dir`file.txt", "C:/dir/file.txt", "Drive Root + Dir + File", null)]
        [NUnit.Framework.TestCaseAttribute("``?`C:`dir`file.txt`", "C:/dir/file.txt/", "Drive Root + Dir + File + Empty", null)]
        [NUnit.Framework.TestCaseAttribute("``?`UNC`server`share`dir`file.txt", "UNC:server/share/dir/file.txt", "LONG: UNC + share + dir + file", null)]
        [NUnit.Framework.TestCaseAttribute("``?`UNC`server`share`dir`file.txt`", "UNC:server/share/dir/file.txt/", "LONG: UNC + Share + dir + file + Empty", null)]
        [NUnit.Framework.TestCaseAttribute(".", ".", "self relative", null)]
        [NUnit.Framework.TestCaseAttribute(".`", "./", "self relative + Empty", null)]
        [NUnit.Framework.TestCaseAttribute(".`file.txt", "./file.txt", "self relative + file", null)]
        [NUnit.Framework.TestCaseAttribute(".`file.txt`", "./file.txt/", "self relative + file + Empty", null)]
        [NUnit.Framework.TestCaseAttribute(".`dir", "./dir", "self relative + dir", null)]
        [NUnit.Framework.TestCaseAttribute(".`dir`", "./dir/", "self relatlve + dir + Empty", null)]
        [NUnit.Framework.TestCaseAttribute(".`dir`file.txt", "./dir/file.txt", "self reletive + dir + file", null)]
        [NUnit.Framework.TestCaseAttribute(".`dir`file.txt`", "./dir/file.txt/", "self relatvie + dir + file + Empty", null)]
        [NUnit.Framework.TestCaseAttribute("..", "..", "parent", null)]
        [NUnit.Framework.TestCaseAttribute("..`", "../", "parent + empty", null)]
        [NUnit.Framework.TestCaseAttribute("..`dir`file.txt", "../dir/file.txt", "parent + reletive + dir + file", null)]
        [NUnit.Framework.TestCaseAttribute("..`dir`file.txt`", "../dir/file.txt/", "parent + relative + dir + file + empty", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server", "UNC:server", "server (illegal)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server`", "UNC:server/", "server + empty (illegal)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server`share", "UNC:server/share", "server + share (legal)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server`share`", "UNC:server/share/", "server + share + empty (legal)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server`share`dir", "UNC:server/share/dir", "server + share + dir (legal)", null)]
        [NUnit.Framework.TestCaseAttribute("UNC:server`share`dir`", "UNC:server/share/dir/", "server + share + dir + empty (legal)", null)]
        public virtual void WindowsPreparseConverterCreatesManagableStringsForTheTokenizer(string path, string pre_Parsed, string notes, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Path", path);
            argumentsOfScenario.Add("Pre-Parsed", pre_Parsed);
            argumentsOfScenario.Add("Notes", notes);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Windows Preparse converter creates managable strings for the tokenizer", null, tagsOfScenario, argumentsOfScenario);
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
#line 9
  testRunner.When("I preparse the path as a Windows style path", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
  testRunner.Then(string.Format("the resulting path should read: {0}", pre_Parsed), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
