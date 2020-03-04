# CassiniAutomation
Cassini Project UI Automation has two main projects. The Automation framework project and the the Nunit tests specification project.
The framework is built based on the Page object model design pattern,
where every single page will be modelled as a class with high level of abstraction with regards to the users interaction on the page.
Various web elements on the page are defined as variables and all possible user interactions on the page implemented as methods to perform the main feature of that page.
This design pattern consequently enhances test maintenance and reduces code duplication.

#Framework Architecture

Tests --> Framework -->Selenium --> Web App

This architecture ensures that the automation framework is seperated from tests. Each layer only interacts with the layer immediately below it.
Tests are written to directly interact or use the framework and the framework in turn interact with the Web App with the help of Selenium Webdriver.
Tests have no knowledge of the Web App and its html elements. This is handled by the framework so that when a web element changes, all affected tests wont need to be updated
but rather update is made on the page class file that houses the web elements.

#Required setup tools
- Visual Studio Professional 2019 for test development
- Specflow for writing feature files (https://specflow.org)
- Selenium for automating web application for testing purposes (https://www.selenium.dev)
- Nunit as the unit testing framework (https://nunit.org)
- ExtentReport for generating test reports (https://extentreports.com)
- Pickles for creating living documentation of feature files (https://www.picklesdoc.com)

#Required Nuggets
The nuget packages for the Nunit test project are:
- Nunit version 3 or higher
- NUnit3TestAdapter
- SpecFlow version 3 or higer
- SpecFlow for Nunit (SpecFlow.Nunit version 3 or higher)
- SpecFlow.Tools.MsBuild.Generation
- ExtentReports (for generating test reports)
- Pickles for living documentation of feature files

The nuget packages for the Framework project
- Selenium.WebDriver
- Selenium.Support
- Selenium.WebDriver.ChromeDriver
- Selenium.Webdriver.FirefoxDriver
- DotNetSelenumExtras.WaitHelpers

#Writing testst

Feature files are created as SpecFlow Feature file
Step bindings are created as SpecFlow Step defintion file

#Running test

Tests are run locally using nunit runner

#Creating Living documentation of the feature files

command to generate documentation for feature files using pickles
Pickle-Features -FeatureDirectory <feature directory path> -OutputDirectory  <output directory path> -SystemUnderTestName "<project name>" -SystemUnderTestVersion "1.0" -DocumentationFormat Dhtml
  
#Set up guide
- Install Visual Studio Professional 2019
- install git (https://git-scm.com/downloads)
- Clone the repository from github using the clone Url ( )
- Open soluton locally using visual studio
- Happy test development!!!
