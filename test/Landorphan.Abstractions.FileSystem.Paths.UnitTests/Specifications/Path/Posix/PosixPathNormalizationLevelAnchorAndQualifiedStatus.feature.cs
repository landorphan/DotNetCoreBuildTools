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
    [NUnit.Framework.DescriptionAttribute("Posix Path Simplification Level, Anchor And Qualifed Status")]
    [NUnit.Framework.CategoryAttribute("Check-In")]
    public partial class PosixPathSimplificationLevelAnchorAndQualifedStatusFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "Check-In"};
        
#line 1 "PosixPathNormalizationLevelAnchorAndQualifiedStatus.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Posix Path Simplification Level, Anchor And Qualifed Status", "\tIn order to develop a reliable Windows Path parser \r\n\tAs a member of the Landorp" +
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
        [NUnit.Framework.DescriptionAttribute("Posix Paths can be normalized to best available form.")]
        [NUnit.Framework.TestCaseAttribute("(null)", "Relative", "false", "SelfReferenceOnly", "Null and Empty paths are equivilent to \'.\'", null)]
        [NUnit.Framework.TestCaseAttribute("(empty)", "Relative", "false", "SelfReferenceOnly", "Null and Empty paths are equivilent to \'.\'", null)]
        [NUnit.Framework.TestCaseAttribute("C:/", "Relative", "false", "NotNormalized", "The trailing slash adds an empty segment thus it\'s not normalized", null)]
        [NUnit.Framework.TestCaseAttribute("/", "Absolute", "true", "Fully", "A root only segment should be created and this path is normalized", null)]
        [NUnit.Framework.TestCaseAttribute("/foo/bar", "Absolute", "true", "Fully", "This path only contains root and generic segments", null)]
        [NUnit.Framework.TestCaseAttribute("foo/bar", "Relative", "false", "Fully", "This path is relative but fully normalized", null)]
        [NUnit.Framework.TestCaseAttribute("foo/../bar", "Relative", "false", "NotNormalized", "This path is not normal because of the parent segment but can be fully normalized" +
            "", null)]
        [NUnit.Framework.TestCaseAttribute("../foo/bar", "Relative", "false", "LeadingParentsOnly", "This path is as normalized as it can be ... leading parent segements can\'t be rem" +
            "oved", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir/file.txt", "Relative", "false", "Fully", "This path is fully normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir/file.txt/", "Relative", "false", "NotNormalized", "The trailing slash adds an empty segement thus it\'s not normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir", "Relative", "false", "Fully", "This path is fully normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir/", "Relative", "false", "NotNormalized", "The trailing slash adds an empty segement thus it\'s not normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:./file.txt", "Relative", "false", "Fully", "This is a Posix path so the \'.\' is not a self reference but part of the name ... " +
            "thus Fully", null)]
        [NUnit.Framework.TestCaseAttribute("C:./file.txt/", "Relative", "false", "NotNormalized", "The self reference and the trailing slash prevent this from being normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:file.txt", "Relative", "false", "Fully", "While not relative this path is still normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:file.txt/", "Relative", "false", "NotNormalized", "Trailing Slash prevents normalization", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir", "Relative", "false", "Fully", "Fully normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir/", "Relative", "false", "NotNormalized", "Trailing slash prevents normalziaiton", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir/file.txt", "Relative", "false", "Fully", "Fully normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir/file.txt/", "Relative", "false", "NotNormalized", "Trailing Slash", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share", "Absolute", "true", "Fully", "Fully normalized remote path", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share/", "Absolute", "true", "NotNormalized", "Trailing Slash", null)]
        [NUnit.Framework.TestCaseAttribute("//server/file.txt", "Absolute", "true", "Fully", "Fully normalized remote path", null)]
        [NUnit.Framework.TestCaseAttribute("//server/file.txt/", "Absolute", "true", "NotNormalized", "Trailing Slash", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share/dir/file.txt", "Absolute", "true", "Fully", "Fully normalized remote path", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share/dir/file.txt/", "Absolute", "true", "NotNormalized", "Trailing Slash", null)]
        [NUnit.Framework.TestCaseAttribute(".", "Relative", "false", "SelfReferenceOnly", "This is normalized as best as posilbe, its a special case where the path only has" +
            " a self reference", null)]
        [NUnit.Framework.TestCaseAttribute("./", "Relative", "false", "NotNormalized", "Self Reference ant Trailing Slash", null)]
        [NUnit.Framework.TestCaseAttribute("./file.txt", "Relative", "false", "NotNormalized", "The self reference could be removed in this case", null)]
        [NUnit.Framework.TestCaseAttribute("./file.txt/", "Relative", "false", "NotNormalized", "The Self reference and the trailing path", null)]
        [NUnit.Framework.TestCaseAttribute("./dir", "Relative", "false", "NotNormalized", "The self reference", null)]
        [NUnit.Framework.TestCaseAttribute("./dir/", "Relative", "false", "NotNormalized", "The self reference and the trailing slash", null)]
        [NUnit.Framework.TestCaseAttribute("./dir/file.txt", "Relative", "false", "NotNormalized", "The self reference", null)]
        [NUnit.Framework.TestCaseAttribute("./dir/file.txt/", "Relative", "false", "NotNormalized", "The self refrence and the trialing slash", null)]
        [NUnit.Framework.TestCaseAttribute("..", "Relative", "false", "LeadingParentsOnly", "Only has a leading parent ... best posible normalization", null)]
        [NUnit.Framework.TestCaseAttribute("../", "Relative", "false", "NotNormalized", "Trailing slash", null)]
        [NUnit.Framework.TestCaseAttribute("../dir/file.txt", "Relative", "false", "LeadingParentsOnly", "Only has leading parents ... best posible normalization", null)]
        [NUnit.Framework.TestCaseAttribute("../dir/file.txt/", "Relative", "false", "NotNormalized", "Trailing slash", null)]
        [NUnit.Framework.TestCaseAttribute("a/b/./c/../../d/../../../e", "Relative", "false", "NotNormalized", "To many resons to mention", null)]
        [NUnit.Framework.TestCaseAttribute("a/b/./c/../d/../../e", "Relative", "false", "NotNormalized", "To many resons to mention", null)]
        public virtual void PosixPathsCanBeNormalizedToBestAvailableForm_(string path, string anchor, string fullyQualified, string simplificationLevel, string notes, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Path", path);
            argumentsOfScenario.Add("Anchor", anchor);
            argumentsOfScenario.Add("Fully Qualified", fullyQualified);
            argumentsOfScenario.Add("Simplification Level", simplificationLevel);
            argumentsOfScenario.Add("Notes", notes);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Posix Paths can be normalized to best available form.", null, tagsOfScenario, argumentsOfScenario);
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
   testRunner.And("I\'m running on the following Operating System: Linux", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
     testRunner.When("I parse the path", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
  testRunner.Then(string.Format("the resulting path should have the following Simplification Level: {0}", simplificationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
