using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BoDi;
using CassiniAutomationProject.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Reflection;
using TechTalk.SpecFlow;

namespace CassiniProject2.Specs
{
    [Binding]
    public sealed class Hooks
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;

        private readonly IObjectContainer _objectContainer;
        private readonly ScenarioContext _scenarioContext;

        private IWebDriver driver;

        public Hooks(IObjectContainer objectContainer, ScenarioContext scenarioContext)
        {
            _objectContainer = objectContainer;
            _scenarioContext = scenarioContext;
        }

        [BeforeTestRun]
        public static void InitializeReport()
        {
            string path = System.Environment.CurrentDirectory;
            string reportPath = path.Substring(0, path.LastIndexOf("bin")) + "Reports\\";

            // Creating a BDD style test report
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }

        [AfterTestRun]
        public static void TearDownReport()
        {
            // Flush report once test completes
            extent.Flush();
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext featureContext)
        {
            //Create dynamic feature name
            featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title);
        }

        [BeforeScenario]
        public void Initialize()
        {
            SelectBrowser(BrowserType.Chrome);
            //Create dynamic scenario name
            scenario = featureName.CreateNode<Scenario>(_scenarioContext.ScenarioInfo.Title);
        }

        [AfterScenario(Order = 2)]
        public void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Dispose();
                driver = null;
            }
        }

        [AfterScenario(Order = 1)]
        public void TakeScreenshotForScenarioFailure()
        {
            if (_scenarioContext.TestError != null)
            {
                string title = _scenarioContext.ScenarioInfo.Title;
                ScreenShotUtility.CaptureScreenshot(driver, title);
            }
        }

        //[AfterStep(Order = 1)]
        //public void TakeScreenshotForAllSteps()
        //{
        //    string stepName = ScenarioStepContext.Current.StepInfo.Text;
        //    ScreenShotUtility.CaptureScreenshot(driver, stepName, scenarioScreenshots: false);
        //}

        [AfterStep]
        public void InsertReportingSteps()
        {
            //Create dynamic step names
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("ScenarioExecutionStatus", BindingFlags.Instance | BindingFlags.Public);
            MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
            object TestResult = getter.Invoke(_scenarioContext, null);

            if (_scenarioContext.TestError == null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
            }
            else if (_scenarioContext.TestError != null)
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(_scenarioContext.TestError.Message);
            }

            //Pending Status
            if (TestResult.ToString() == "StepDefinitionPending")
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
            }
        }
        internal void SelectBrowser(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.Chrome:
                    ChromeOptions option = new ChromeOptions();
                    option.AddArguments("--no-sandbox");
                    option.AddArguments("--ignore-certificate-errors");
                    //option.AddArgument("--headless");
                    driver = new ChromeDriver(option);
                    _objectContainer.RegisterInstanceAs(driver);
                    break;
                case BrowserType.Firefox:
                    FirefoxOptions profile = new FirefoxOptions();
                    profile.AcceptInsecureCertificates = true;
                    driver = new FirefoxDriver(profile);
                    _objectContainer.RegisterInstanceAs(driver);
                    break;
                case BrowserType.Edge:
                    break;
                default:
                    break;
            }
        }
    }
    enum BrowserType
    {
        Chrome,
        Firefox,
        Edge
    }
}

