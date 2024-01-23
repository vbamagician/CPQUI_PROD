﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CPQUI.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CPQUIFinOpsProfessionalServicesCloudServicesAWS")]
    public partial class CPQUIFinOpsProfessionalServicesCloudServicesAWSFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "CPQUIFinOpsProfessionalServicesCloudServicesAWS.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CPQUIFinOpsProfessionalServicesCloudServicesAWS", @"This feature aims to ensure the robust UI Health of the FinOps Professional Services - Cloud Services AWS 
Solution within the CPQ environment. It focuses on validating the seamless and 
dependable functionality of the user interface while configuring and processing 
a new contract for the Digital Workplace Essentials for EA.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Verify UI Health while Configuring FinOps Professional Services - Cloud Services " +
            "AWS Solution in CPQ")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public void VerifyUIHealthWhileConfiguringFinOpsProfessionalServices_CloudServicesAWSSolutionInCPQ()
        {
            string[] tagsOfScenario = new string[] {
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify UI Health while Configuring FinOps Professional Services - Cloud Services " +
                    "AWS Solution in CPQ", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
 testRunner.Given("I Navigate to CPQ UI Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Password"});
                table9.AddRow(new string[] {
                            "helpdesk-scg.global@softwareone.com",
                            "CPQ.account1708"});
#line 11
  testRunner.And("I Enter following Login Details and Click Login Button", ((string)(null)), table9, "And ");
#line hidden
#line 14
  testRunner.And("I click the button containing the text \"New Contract\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
  testRunner.And("I enter \"walmart\" into the textbox with the header labeled \"Select an Account\" an" +
                        "d press \"Enter\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
  testRunner.And("I check the \"asynchronous\" checkbox based on the adjacent table has index \"1\" hav" +
                        "ing cell that has value \"00001614\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
  testRunner.And("I click the button containing the text \"Do you want to continue without an Opport" +
                        "unity?\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
  testRunner.And("I enter \"UI Test\" into the textbox for the question \"Draft topic:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
  testRunner.And("I check the \"synchronous\" checkbox based on the adjacent table has index \"3\" havi" +
                        "ng cell that has value \"Idris Elba\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
  testRunner.And("I click the button containing the text \"I Confirm\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
  testRunner.And("I click the \"Get Contract\" button associated with the reference text \"FinOps Prof" +
                        "essional Services - Cloud Services AWS\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
  testRunner.And("I click the button containing the text \"Configure Now\" Only If button found withi" +
                        "n 30 seconds else skip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
  testRunner.And("I choose the radio button option \"Apptio Cloudability\" specifically", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
  testRunner.And("I check \"Azure\" checkbox for the header \"Please select Cloud Providers in-scope\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
  testRunner.And("I check \"AWS\" checkbox for the header \"Please select Cloud Providers in-scope\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
  testRunner.And("I choose \"Yes\" from the radio button group for the question \"FinOps Fundamentals " +
                        "Workshop (Kick Off)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
  testRunner.And("I choose \"Yes\" from the radio button group for the question \"FinOps Diagnostic As" +
                        "sessment\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
  testRunner.And("I choose \"Yes\" from the radio button group for the question \"Cloud Cost Optimizat" +
                        "ion Fundamentals Workshop (Proof of Value)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
  testRunner.And("I choose \"Yes\" from the radio button group for the question \"Cloud Spend Manageme" +
                        "nt Implementation for Cloudability\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
  testRunner.And("I choose \"Yes\" from the radio button group for the question \"Cloud Sustainability" +
                        " Fundamentals Workshop\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
  testRunner.And("I choose \"Yes\" from the radio button group for the question \"Project Management\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
  testRunner.And("I click the button with the text \"Next\" identified by the parent class \"heap-next" +
                        "-1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
  testRunner.And("I choose \"xDC Gurugram\" from the dropdown for the question \"Please provide your p" +
                        "referred Delivery Center:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
  testRunner.And("I choose \"Associate Consultant\" from the radio button group for the question \"Con" +
                        "sultant Level:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
  testRunner.And("I enter \"1\" into the textbox for the question \"Number of subscriptions?\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
  testRunner.And("I enter \"10000\" into the textbox for the question \"Estimated Annual Cloud Spend\" " +
                        "having repeat index of \"1\" and press \"Nothing\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
  testRunner.And("I enter \"1\" into the textbox for the question \"Number of accounts?\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
  testRunner.And("I enter \"10000\" into the textbox for the question \"Estimated Annual Cloud Spend\" " +
                        "having repeat index of \"2\" and press \"Nothing\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
  testRunner.And("I enter \"20000\" into the textbox for the question \"Business Volume:\" and press \"E" +
                        "nter\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
  testRunner.And("I click the button with the text \"Next\" identified by the parent class \"heap-next" +
                        "-2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
  testRunner.And("I click the button with the text \"Next\" identified by the parent class \"heap-next" +
                        "-3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
  testRunner.And("I enter \"ABCD\" into the textarea for the question \"Locations in scope:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
  testRunner.And("I enter \"ABCD\" into the textarea for the question \"Organizations in scope:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
  testRunner.And("I click the button with the text \"Next\" identified by the parent class \"heap-next" +
                        "-5\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
  testRunner.And("I choose \"PDF\" from the dropdown for the question \"Document Type:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.When("I click the button with the text \"Finish\" identified by the parent class \"heap-fi" +
                        "nish\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.Then("I should see the value of contract", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
