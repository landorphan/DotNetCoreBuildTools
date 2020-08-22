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
    [NUnit.Framework.DescriptionAttribute("Posix Path Simplification")]
    [NUnit.Framework.CategoryAttribute("Check-In")]
    public partial class PosixPathSimplificationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "Check-In"};
        
#line 1 "PosixPathNormalization.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Posix Path Simplification", "\tIn order to develop a reliable Windows Path parser \r\n\tAs a member of the Landorp" +
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
        [NUnit.Framework.DescriptionAttribute("Posix Paths can be simplified to best available form.")]
        [NUnit.Framework.TestCaseAttribute("(null)", "Legal", "Relative", "false", "{E} (empty)", ".", "SelfReferenceOnly", "Imposible for Null path to normalize", null)]
        [NUnit.Framework.TestCaseAttribute("(empty)", "Legal", "Relative", "false", "{E} (empty)", ".", "SelfReferenceOnly", "Imposible for Empty path to normalize", null)]
        [NUnit.Framework.TestCaseAttribute("C:/", "Legal", "Relative", "false", "{E} (empty)", "C:", "Fully", "The trailing slash adds an empty segment thus it\'s not normalized", null)]
        [NUnit.Framework.TestCaseAttribute("/", "Legal", "Absolute", "true", "{R}", "/", "Fully", "A root only segment should be created and this path is normalized", null)]
        [NUnit.Framework.TestCaseAttribute("/foo/bar", "Legal", "Absolute", "true", "{R}", "/foo/bar", "Fully", "This path only contains root and generic segments", null)]
        [NUnit.Framework.TestCaseAttribute("foo/bar", "Legal", "Relative", "false", "{E} (empty)", "foo/bar", "Fully", "This path is relative but fully normalized", null)]
        [NUnit.Framework.TestCaseAttribute("foo/../bar", "Legal", "Relative", "false", "{E} (empty)", "bar", "Fully", "This path is not normal because of the parent segment but can be fully normalized" +
            "", null)]
        [NUnit.Framework.TestCaseAttribute("../foo/bar", "Legal", "Relative", "false", "{E} (empty)", "../foo/bar", "LeadingParentsOnly", "This path is as normalized as it can be ... leading parent segements can\'t be rem" +
            "oved", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir/file.txt", "Legal", "Relative", "false", "{E} (empty)", "C:/dir/file.txt", "Fully", "This path is fully normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir/file.txt/", "Legal", "Relative", "false", "{E} (empty)", "C:/dir/file.txt", "Fully", "The trailing slash adds an empty segement thus it\'s not normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir", "Legal", "Relative", "false", "{E} (empty)", "C:/dir", "Fully", "This path is fully normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:/dir/", "Legal", "Relative", "false", "{E} (empty)", "C:/dir", "Fully", "The trailing slash adds an empty segement thus it\'s not normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:./file.txt/", "Legal", "Relative", "false", "{E} (empty)", "C:./file.txt", "Fully", "The self reference and the trailing slash prevent this from being normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:file.txt", "Legal", "Relative", "false", "{E} (empty)", "C:file.txt", "Fully", "While not relative this path is still normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:file.txt/", "Legal", "Relative", "false", "{E} (empty)", "C:file.txt", "Fully", "Trailing Slash prevents normalization", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir", "Legal", "Relative", "false", "{E} (empty)", "C:dir", "Fully", "Fully normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir/", "Legal", "Relative", "false", "{E} (empty)", "C:dir", "Fully", "Trailing slash prevents normalziaiton", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir/file.txt", "Legal", "Relative", "false", "{E} (empty)", "C:dir/file.txt", "Fully", "Fully normalized", null)]
        [NUnit.Framework.TestCaseAttribute("C:dir/file.txt/", "Legal", "Relative", "false", "{E} (empty)", "C:dir/file.txt", "Fully", "Trailing Slash", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share", "Legal", "Absolute", "true", "{X} server", "//server/share", "Fully", "Fully normalized remote path", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share/", "Legal", "Absolute", "true", "{X} server", "//server/share", "Fully", "Trailing Slash", null)]
        [NUnit.Framework.TestCaseAttribute("//server/file.txt", "Legal", "Absolute", "true", "{X} server", "//server/file.txt", "Fully", "Fully normalized remote path", null)]
        [NUnit.Framework.TestCaseAttribute("//server/file.txt/", "Legal", "Absolute", "true", "{X} server", "//server/file.txt", "Fully", "Trailing Slash", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share/dir/file.txt", "Legal", "Absolute", "true", "{X} server", "//server/share/dir/file.txt", "Fully", "Fully normalized remote path", null)]
        [NUnit.Framework.TestCaseAttribute("//server/share/dir/file.txt/", "Legal", "Absolute", "true", "{X} server", "//server/share/dir/file.txt", "Fully", "Trailing Slash", null)]
        [NUnit.Framework.TestCaseAttribute(".", "Legal", "Relative", "false", "{E} (empty)", ".", "SelfReferenceOnly", "This is normalized as best as posilbe, its a special case where the path only has" +
            " a self reference", null)]
        [NUnit.Framework.TestCaseAttribute("./", "Legal", "Relative", "false", "{E} (empty)", ".", "SelfReferenceOnly", "Self Reference ant Trailing Slash", null)]
        [NUnit.Framework.TestCaseAttribute("./file.txt", "Legal", "Relative", "false", "{E} (empty)", "file.txt", "Fully", "The self reference could be removed in this case", null)]
        [NUnit.Framework.TestCaseAttribute("./file.txt/", "Legal", "Relative", "false", "{E} (empty)", "file.txt", "Fully", "The Self reference and the trailing path", null)]
        [NUnit.Framework.TestCaseAttribute("./dir", "Legal", "Relative", "false", "{E} (empty)", "dir", "Fully", "The self reference", null)]
        [NUnit.Framework.TestCaseAttribute("./dir/", "Legal", "Relative", "false", "{E} (empty)", "dir", "Fully", "The self reference and the trailing slash", null)]
        [NUnit.Framework.TestCaseAttribute("./dir/file.txt", "Legal", "Relative", "false", "{E} (empty)", "dir/file.txt", "Fully", "The self reference", null)]
        [NUnit.Framework.TestCaseAttribute("./dir/file.txt/", "Legal", "Relative", "false", "{E} (empty)", "dir/file.txt", "Fully", "The self refrence and the trialing slash", null)]
        [NUnit.Framework.TestCaseAttribute("..", "Legal", "Relative", "false", "{E} (empty)", "..", "LeadingParentsOnly", "Only has a leading parent ... best posible normalization", null)]
        [NUnit.Framework.TestCaseAttribute("../", "Legal", "Relative", "false", "{E} (empty)", "..", "LeadingParentsOnly", "Trailing slash", null)]
        [NUnit.Framework.TestCaseAttribute("../dir/file.txt", "Legal", "Relative", "false", "{E} (empty)", "../dir/file.txt", "LeadingParentsOnly", "Only has leading parents ... best posible normalization", null)]
        [NUnit.Framework.TestCaseAttribute("../dir/file.txt/", "Legal", "Relative", "false", "{E} (empty)", "../dir/file.txt", "LeadingParentsOnly", "Trailing slash", null)]
        [NUnit.Framework.TestCaseAttribute("a/b/./c/../../d/../../../e", "Legal", "Relative", "false", "{E} (empty)", "../e", "LeadingParentsOnly", "To many resons to mention", null)]
        [NUnit.Framework.TestCaseAttribute("a/b/./c/../d/../../e", "Legal", "Relative", "false", "{E} (empty)", "a/e", "Fully", "To many resons to mention", null)]
        [NUnit.Framework.TestCaseAttribute("./././././", "Legal", "Relative", "false", "{E} (empty)", ".", "SelfReferenceOnly", "Nothing but self references = one self reference", null)]
        [NUnit.Framework.TestCaseAttribute(".//.//.//.", "Legal", "Relative", "false", "{E} (empty)", ".", "SelfReferenceOnly", "Same as above as empty segments count as self references for normalization purpos" +
            "es", null)]
        [NUnit.Framework.TestCaseAttribute("C:/..", "Legal", "Relative", "false", "{E} (empty)", ".", "SelfReferenceOnly", "Parrent trversal stops at the first \"rooted\" segment", null)]
        [NUnit.Framework.TestCaseAttribute("C:/../..", "Legal", "Relative", "false", "{E} (empty)", "..", "LeadingParentsOnly", "Parrent trversal stops at the first \"rooted\" segment", null)]
        [NUnit.Framework.TestCaseAttribute("/..", "Legal", "Absolute", "true", "{R}", "/", "Fully", "Parrent trversal stops at the first \"rooted\" segment", null)]
        [NUnit.Framework.TestCaseAttribute("/../..", "Legal", "Absolute", "true", "{R}", "/", "Fully", "Parrent trversal stops at the first \"rooted\" segment", null)]
        [NUnit.Framework.TestCaseAttribute("//server/..", "Legal", "Absolute", "true", "{X} server", "//server", "Fully", "Parrent trversal stops at the first \"rooted\" segment", null)]
        [NUnit.Framework.TestCaseAttribute("//server/../..", "Legal", "Absolute", "true", "{X} server", "//server", "Fully", "Parrent trversal stops at the first \"rooted\" segment", null)]
        public virtual void PosixPathsCanBeSimplifiedToBestAvailableForm_(string path, string pathStatus, string anchor, string fullyQualified, string rootSegment, string normalizedPath, string simplificationLevel, string notes, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Path", path);
            argumentsOfScenario.Add("Path Status", pathStatus);
            argumentsOfScenario.Add("Anchor", anchor);
            argumentsOfScenario.Add("Fully Qualified", fullyQualified);
            argumentsOfScenario.Add("Root Segment", rootSegment);
            argumentsOfScenario.Add("Normalized Path", normalizedPath);
            argumentsOfScenario.Add("Simplification Level", simplificationLevel);
            argumentsOfScenario.Add("Notes", notes);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Posix Paths can be simplified to best available form.", null, tagsOfScenario, argumentsOfScenario);
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
   testRunner.And("I parse the path", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
   testRunner.And(string.Format("the parse status should be {0}", pathStatus), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
   testRunner.And(string.Format("the parse path should be anchored to {0}", anchor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
   testRunner.And(string.Format("the parse path\'s root segment should return: {0}", rootSegment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
   testRunner.And(string.Format("the parse path\'s FullyQualified property should be: {0}", fullyQualified), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
     testRunner.When("I normalize the path", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
  testRunner.Then(string.Format("the resulting path should read: {0}", normalizedPath), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
   testRunner.And(string.Format("the resulting status should be {0}", pathStatus), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
   testRunner.And(string.Format("the resulting path should be anchored to {0}", anchor), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
   testRunner.And(string.Format("the resulting path\'s FullyQualified property should be: {0}", fullyQualified), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
   testRunner.And(string.Format("the resulting path\'s root segment should return: {0}", rootSegment), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
   testRunner.And(string.Format("the resulting path should have the following Simplification Level: {0}", simplificationLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
