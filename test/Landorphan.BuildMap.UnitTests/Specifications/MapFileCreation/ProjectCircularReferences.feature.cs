﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.4.0.0
//      SpecFlow Generator Version:3.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Landorphan.BuildMap.UnitTests.Specifications.MapFileCreation
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Project Circular References")]
    [NUnit.Framework.CategoryAttribute("Check-In")]
    public partial class ProjectCircularReferencesFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "Check-In"};
        
#line 1 "ProjectCircularReferences.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Specifications/MapFileCreation", "Project Circular References", "\tIn order to build complicated project structures\r\n\tAs a developer\r\n\tI want to to" +
                    " be able to create a mapping of all projects, their dependencies and their build" +
                    " order.", ProgrammingLanguage.CSharp, new string[] {
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
        [NUnit.Framework.DescriptionAttribute("Direct Circular References")]
        public virtual void DirectCircularReferences()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Direct Circular References", null, tagsOfScenario, argumentsOfScenario);
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
                TechTalk.SpecFlow.Table table37 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Language"});
                table37.AddRow(new string[] {
                            "Project1",
                            "CSharp"});
                table37.AddRow(new string[] {
                            "Project2",
                            "CSharp"});
#line 8
 testRunner.Given("I locate the following project files:", ((string)(null)), table37, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table38 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name"});
                table38.AddRow(new string[] {
                            "Solution1"});
#line 12
      testRunner.And("I locate the following solution files:", ((string)(null)), table38, "And ");
#line hidden
                TechTalk.SpecFlow.Table table39 = new TechTalk.SpecFlow.Table(new string[] {
                            "Solution",
                            "Project"});
                table39.AddRow(new string[] {
                            "Solution1",
                            "Project1"});
                table39.AddRow(new string[] {
                            "Solution1",
                            "Project2"});
#line 15
   testRunner.And("the following solutions contain the following located projects:", ((string)(null)), table39, "And ");
#line hidden
                TechTalk.SpecFlow.Table table40 = new TechTalk.SpecFlow.Table(new string[] {
                            "Project",
                            "Reference"});
                table40.AddRow(new string[] {
                            "Project2",
                            "Project1"});
                table40.AddRow(new string[] {
                            "Project1",
                            "Project2"});
#line 19
   testRunner.And("the following projects contain the following references:", ((string)(null)), table40, "And ");
#line hidden
#line 23
      testRunner.And("the projects and solutions are saved on disk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
  testRunner.When("I create the map file with the following search patterns: **/*.sln;**/*.csproj", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table41 = new TechTalk.SpecFlow.Table(new string[] {
                            "Group",
                            "Item",
                            "Types",
                            "Language",
                            "Name",
                            "Status",
                            "Solutions",
                            "Id",
                            "Relative Path",
                            "Dependent On"});
                table41.AddRow(new string[] {
                            "-1",
                            "0",
                            "Library",
                            "CSharp",
                            "Project1",
                            "Circular",
                            "Solution1",
                            "1",
                            "Project1`Project1.csproj",
                            "2"});
                table41.AddRow(new string[] {
                            "-1",
                            "0",
                            "Library",
                            "CSharp",
                            "Project2",
                            "Circular",
                            "Solution1",
                            "2",
                            "Project2`Project2.csproj",
                            "1"});
#line 25
  testRunner.Then("the map file should contain the following projects:", ((string)(null)), table41, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Indirect Circular Reference")]
        public virtual void IndirectCircularReference()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Indirect Circular Reference", null, tagsOfScenario, argumentsOfScenario);
#line 30
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
                TechTalk.SpecFlow.Table table42 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Language"});
                table42.AddRow(new string[] {
                            "Project1",
                            "CSharp"});
                table42.AddRow(new string[] {
                            "Project2",
                            "CSharp"});
                table42.AddRow(new string[] {
                            "Project3",
                            "CSharp"});
                table42.AddRow(new string[] {
                            "Project4",
                            "CSharp"});
#line 31
 testRunner.Given("I locate the following project files:", ((string)(null)), table42, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table43 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name"});
                table43.AddRow(new string[] {
                            "Solution1"});
#line 37
      testRunner.And("I locate the following solution files:", ((string)(null)), table43, "And ");
#line hidden
                TechTalk.SpecFlow.Table table44 = new TechTalk.SpecFlow.Table(new string[] {
                            "Solution",
                            "Project"});
                table44.AddRow(new string[] {
                            "Solution1",
                            "Project1"});
                table44.AddRow(new string[] {
                            "Solution1",
                            "Project2"});
                table44.AddRow(new string[] {
                            "Solution1",
                            "Project3"});
                table44.AddRow(new string[] {
                            "Solution1",
                            "Project4"});
#line 40
   testRunner.And("the following solutions contain the following located projects:", ((string)(null)), table44, "And ");
#line hidden
                TechTalk.SpecFlow.Table table45 = new TechTalk.SpecFlow.Table(new string[] {
                            "Project",
                            "Reference"});
                table45.AddRow(new string[] {
                            "Project3",
                            "Project1"});
                table45.AddRow(new string[] {
                            "Project2",
                            "Project3"});
                table45.AddRow(new string[] {
                            "Project1",
                            "Project2"});
                table45.AddRow(new string[] {
                            "Project4",
                            "Project1"});
#line 46
   testRunner.And("the following projects contain the following references:", ((string)(null)), table45, "And ");
#line hidden
#line 52
      testRunner.And("the projects and solutions are saved on disk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
  testRunner.When("I create the map file with the following search patterns: **/*.sln;**/*.csproj", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table46 = new TechTalk.SpecFlow.Table(new string[] {
                            "Group",
                            "Item",
                            "Types",
                            "Language",
                            "Name",
                            "Status",
                            "Solutions",
                            "Id",
                            "Relative Path",
                            "Dependent On"});
                table46.AddRow(new string[] {
                            "-1",
                            "0",
                            "Library",
                            "CSharp",
                            "Project1",
                            "Circular",
                            "Solution1",
                            "1",
                            "Project1`Project1.csproj",
                            "2"});
                table46.AddRow(new string[] {
                            "-1",
                            "0",
                            "Library",
                            "CSharp",
                            "Project2",
                            "Circular",
                            "Solution1",
                            "2",
                            "Project2`Project2.csproj",
                            "3"});
                table46.AddRow(new string[] {
                            "-1",
                            "0",
                            "Library",
                            "CSharp",
                            "Project3",
                            "Circular",
                            "Solution1",
                            "3",
                            "Project3`Project3.csproj",
                            "1"});
                table46.AddRow(new string[] {
                            "0",
                            "0",
                            "Library",
                            "CSharp",
                            "Project4",
                            "Valid",
                            "Solution1",
                            "4",
                            "Project4`Project4.csproj",
                            "1"});
#line 54
  testRunner.Then("the map file should contain the following projects:", ((string)(null)), table46, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Second Level Indirect Circular Reference")]
        public virtual void SecondLevelIndirectCircularReference()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Second Level Indirect Circular Reference", null, tagsOfScenario, argumentsOfScenario);
#line 61
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
                TechTalk.SpecFlow.Table table47 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name",
                            "Language"});
                table47.AddRow(new string[] {
                            "Project1",
                            "CSharp"});
                table47.AddRow(new string[] {
                            "Project2",
                            "CSharp"});
                table47.AddRow(new string[] {
                            "Project3",
                            "CSharp"});
                table47.AddRow(new string[] {
                            "Project4",
                            "CSharp"});
                table47.AddRow(new string[] {
                            "Project5",
                            "CSharp"});
#line 62
 testRunner.Given("I locate the following project files:", ((string)(null)), table47, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table48 = new TechTalk.SpecFlow.Table(new string[] {
                            "Name"});
                table48.AddRow(new string[] {
                            "Solution1"});
#line 69
      testRunner.And("I locate the following solution files:", ((string)(null)), table48, "And ");
#line hidden
                TechTalk.SpecFlow.Table table49 = new TechTalk.SpecFlow.Table(new string[] {
                            "Solution",
                            "Project"});
                table49.AddRow(new string[] {
                            "Solution1",
                            "Project1"});
                table49.AddRow(new string[] {
                            "Solution1",
                            "Project2"});
                table49.AddRow(new string[] {
                            "Solution1",
                            "Project3"});
                table49.AddRow(new string[] {
                            "Solution1",
                            "Project4"});
                table49.AddRow(new string[] {
                            "Solution1",
                            "Project5"});
#line 72
   testRunner.And("the following solutions contain the following located projects:", ((string)(null)), table49, "And ");
#line hidden
                TechTalk.SpecFlow.Table table50 = new TechTalk.SpecFlow.Table(new string[] {
                            "Project",
                            "Reference"});
                table50.AddRow(new string[] {
                            "Project1",
                            "Project4"});
                table50.AddRow(new string[] {
                            "Project2",
                            "Project1"});
                table50.AddRow(new string[] {
                            "Project3",
                            "Project2"});
                table50.AddRow(new string[] {
                            "Project4",
                            "Project3"});
                table50.AddRow(new string[] {
                            "Project5",
                            "Project1"});
#line 79
   testRunner.And("the following projects contain the following references:", ((string)(null)), table50, "And ");
#line hidden
#line 86
      testRunner.And("the projects and solutions are saved on disk", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
  testRunner.When("I create the map file with the following search patterns: **/*.sln;**/*.csproj", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table51 = new TechTalk.SpecFlow.Table(new string[] {
                            "Group",
                            "Item",
                            "Types",
                            "Language",
                            "Name",
                            "Status",
                            "Solutions",
                            "Id",
                            "Relative Path",
                            "Dependent On"});
                table51.AddRow(new string[] {
                            "-1",
                            "0",
                            "Library",
                            "CSharp",
                            "Project1",
                            "Circular",
                            "Solution1",
                            "1",
                            "Project1`Project1.csproj",
                            "4"});
                table51.AddRow(new string[] {
                            "-1",
                            "0",
                            "Library",
                            "CSharp",
                            "Project2",
                            "Circular",
                            "Solution1",
                            "2",
                            "Project2`Project2.csproj",
                            "1"});
                table51.AddRow(new string[] {
                            "-1",
                            "0",
                            "Library",
                            "CSharp",
                            "Project3",
                            "Circular",
                            "Solution1",
                            "3",
                            "Project3`Project3.csproj",
                            "2"});
                table51.AddRow(new string[] {
                            "-1",
                            "0",
                            "Library",
                            "CSharp",
                            "Project4",
                            "Circular",
                            "Solution1",
                            "4",
                            "Project4`Project4.csproj",
                            "3"});
                table51.AddRow(new string[] {
                            "0",
                            "0",
                            "Library",
                            "CSharp",
                            "Project5",
                            "Valid",
                            "Solution1",
                            "5",
                            "Project5`Project5.csproj",
                            "1"});
#line 88
  testRunner.Then("the map file should contain the following projects:", ((string)(null)), table51, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
