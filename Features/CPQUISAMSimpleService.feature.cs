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
    [NUnit.Framework.DescriptionAttribute("CPQUISAMSimpleService")]
    public partial class CPQUISAMSimpleServiceFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "CPQUISAMSimpleService.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CPQUISAMSimpleService", "This feature is dedicated to testing the UI Health of the SAMSimple Service withi" +
                    "n the CPQ UI. \r\nThe primary objective is to ensure a consistent and seamless use" +
                    "r experience while configuring a new \r\ncontract for the SAMSimple Service.", ProgrammingLanguage.CSharp, featureTags);
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
        [NUnit.Framework.DescriptionAttribute("Verify UI Health while Configuring SAMSimple Service in CPQ UI")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        public void VerifyUIHealthWhileConfiguringSAMSimpleServiceInCPQUI()
        {
            string[] tagsOfScenario = new string[] {
                    "smoke"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Verify UI Health while Configuring SAMSimple Service in CPQ UI", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 9
 testRunner.Given("I Navigate to CPQ UI Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                            "Username",
                            "Password"});
                table19.AddRow(new string[] {
                            "helpdesk-scg.global@softwareone.com",
                            "CPQ.account1708"});
#line 10
  testRunner.And("I Enter following Login Details and Click Login Button", ((string)(null)), table19, "And ");
#line hidden
#line 13
  testRunner.And("I click the button containing the text \"New Contract\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
  testRunner.And("I enter \"walmart\" into the textbox with the header labeled \"Select an Account\" an" +
                        "d press \"Enter\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
  testRunner.And("I check the \"asynchronous\" checkbox based on the adjacent table has index \"1\" hav" +
                        "ing cell that has value \"00001614\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
  testRunner.And("I click the button containing the text \"Do you want to continue without an Opport" +
                        "unity?\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
  testRunner.And("I enter \"UI Test\" into the textbox for the question \"Draft topic:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
  testRunner.And("I check the \"synchronous\" checkbox based on the adjacent table has index \"3\" havi" +
                        "ng cell that has value \"Idris Elba\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
  testRunner.And("I click the button containing the text \"I Confirm\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
  testRunner.And("I click the \"Get Contract\" button associated with the reference text \"SAMSimple\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
  testRunner.And("I click the button containing the text \"Configure Now\" Only If button found withi" +
                        "n 30 seconds else skip", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
  testRunner.And("I choose \"Yes\" from the radio button group for the question \"Please confirm, we a" +
                        "re able to do so\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
  testRunner.And("I choose the radio button option \"We are able to deploy the SAMSimple inventory a" +
                        "gents to all devices in scope\" specifically", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
  testRunner.And("I click the button with the text \"Next\" identified by the parent class \"heap-next" +
                        "-1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
  testRunner.And("I click on the tile having text \"ActivePDF\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
  testRunner.And("I enter \"1\" into the textbox for the question \"# End-user Device:\" and press \"Ent" +
                        "er\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
  testRunner.And("I enter \"1\" into the textbox for the question \"# Servers (Physical & Virtual):\" a" +
                        "nd press \"Enter\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
  testRunner.And("I enter \"1\" into the textbox for the question \"# Users:\" and press \"Enter\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
  testRunner.And("I click on the tile having text \"Linux\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
  testRunner.And("I enter \"1\" into the textbox for the question \"# Trusted Domains:\" and press \"Ent" +
                        "er\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
  testRunner.And("I enter \"1\" into the textbox for the question \"# Untrusted Domains:\" and press \"E" +
                        "nter\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
  testRunner.And("I enter \"1\" into the textbox for the question \"# Locations:\" and press \"Enter\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
  testRunner.And("I enter \"1\" into the textbox for the question \"# Segregated Networks:\" and press " +
                        "\"Enter\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
  testRunner.And("I click on the tile having text \"HP-UD (DDMI)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
  testRunner.And("I click on the tile having text \"PDQ Deploy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
  testRunner.And("I click on the tile having text \"Microsoft Hyper-V\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
  testRunner.And("I click on the tile having text \"Microsoft App-V\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
  testRunner.And("I click on the tile having text \"Microsoft Office 365\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
  testRunner.And("I click the button with the text \"Next\" identified by the parent class \"heap-next" +
                        "-2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
  testRunner.And("I choose \"Medium\" from the radio button group for the question \"Implementation Le" +
                        "vel: Based on the provided scoping information, the implementation may be Comple" +
                        "x\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
  testRunner.And("I click the button with the text \"Next\" identified by the parent class \"heap-next" +
                        "-3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
  testRunner.And("I click the element contains the text \"Add Domain\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
  testRunner.And("I choose \"Trusted\" from the dropdown for the question \"Is this a trusted or untru" +
                        "sted domain?\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
  testRunner.And("I enter \"ABCD\" into the textbox for the question \"Domain name:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
  testRunner.And("I click the element contains the text \"Save & Add another\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
  testRunner.And("I click to close the form \"Add Domain\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
  testRunner.And("I click the element contains the text \"Add Domain\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
  testRunner.And("I choose \"Untrusted\" from the dropdown for the question \"Is this a trusted or unt" +
                        "rusted domain?\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
  testRunner.And("I enter \"ABCD\" into the textbox for the question \"Domain name:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
  testRunner.And("I click the element contains the text \"Save & Add another\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
  testRunner.And("I click to close the form \"Add Domain\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
  testRunner.And("I click the element contains the text \"Add Location\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
  testRunner.And("I enter \"India\" into the textbox for the question \"Geographic location:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
  testRunner.And("I click the element contains the text \"Save & Add another\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
  testRunner.And("I click to close the form \"Add new location\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
  testRunner.And("I click the element contains the text \"Add Network\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
  testRunner.And("I enter \"ABCD\" into the textbox for the question \"Details:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
  testRunner.And("I click the element contains the text \"Save & Add another\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
  testRunner.And("I click to close the form \"Add new segregated network\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
  testRunner.And("I click the element contains the text \"Add Application virtualization Details\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
  testRunner.And("I enter \"ABCD\" into the textbox for the question \"Product:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
  testRunner.And("I enter \"1\" into the textbox for the question \"Version:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
  testRunner.And("I enter \"2\" into the textbox for the question \"Edition:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
  testRunner.And("I click the element contains the text \"Save & Add another\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
  testRunner.And("I click to close the form \"Add new record\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
  testRunner.And("I click the element contains the text \"Add Virtualization Platform Details\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
  testRunner.And("I enter \"ABCD\" into the textbox for the question \"Product:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
  testRunner.And("I enter \"1\" into the textbox for the question \"Version:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
  testRunner.And("I enter \"2\" into the textbox for the question \"Edition:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
  testRunner.And("I click the element contains the text \"Save & Add another\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
  testRunner.And("I click to close the form \"Add new record\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
  testRunner.And("I choose \"Option A: Quarterly consumption subscription invoice\" from the dropdown" +
                        " for the question \"Invoicing frequency:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
  testRunner.And("I click the button with the text \"Next\" identified by the parent class \"heap-next" +
                        "-5\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
  testRunner.And("I choose \"PDF\" from the dropdown for the question \"Document Type:\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.When("I click the button with the text \"Finish\" identified by the parent class \"heap-fi" +
                        "nish\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.Then("I should see the value of contract", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
