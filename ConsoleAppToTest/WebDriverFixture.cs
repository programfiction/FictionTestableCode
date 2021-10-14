using System;
using System.Security.Cryptography.X509Certificates;
using AutoIt;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Suppost.UI;
using WebDriverManager;
using Xunit;

namespace ConsoleAppToTest
{
    public class
    WebDriverFixture
    : IDisposable //To dispose the driver object after use and share among multiple cases
    {
        public IWebDriver cDriver { get; private set; }

        public WebDriverFixture()
        {
            var browserDriverName = "Chrome"; // Make it config driven to test in multiple browsers
            if (browserDrivername == "Chrome")
            {
                ChromeOptions chromeOptions = new ChromeOptions();
                chromeOptions.AddArgument("headless"); // go headless to integrate in deployment pipeline
                chromeOptions.AddArguments("--test-type", "--start-maximized"); //Add multiple arguments to customize chrome browser
                cDriver = new ChromeDriver(chromeOptions);
            }
            else if (browserDrivername == "Edge")
            {
                EdgeOptions edgeOptions =
                    new EdgeOptions() { UseInPrivateBrowsing = true };
                cDriver = new EdgeDriver(edgeOptions);
            }
            else if (browserDrivername == "Firefox")
            {
                var _ffp = new FirefoxProfile();
                _ffp.AcceptUntrustedCertificates = true;
                cDriver = new FirefoxDriver(_ffp);
            }
            else
            {
                cDriver = new InternetExplorerDriver();
            }
        }

        public void Dispose()
        {
            cDriver.Quit();
            cDriver.Dispose();
        }
    }

    //How to use this

    public class StartTest : IClassFixture<WebDriverFixture>
    {
        private const string TIMEOUT = 30; //in seconds for timeout

        private WebDriverFixture _fixture { get; set; }

        private ITestOutputHelper _testOPHelper { get; set; }

        public StartTest(WebDriverFixture fixture, ITestOutputHelper testHelper)
        {
            _fixture = fixture;
            _testOPHelper = testHelper;
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void TestName()
        {
            string URL= "<some url config driven>";
            //Given
            using (IWebDriver driver = _fixture.cDriver)
            {
                //When
               
                //Wait to load with expected condition
                WebDriverWait wait= new WebDriverWait(driver,TimeSpan.FromSeconds(TIMEOUT));
                driver.Navigate().GoToUrl(URL);
                //For basic authentication browser prompt
                AutoItX.Send("<username>"+{TAB}+"<password>"+"{ENTER}");
                wait.Until(ExpectedConditions.TitleContains("test")); //wait for load 
                
                //Then
                Assert.Equal("test", driver.Title);// Check browser title after pageload
            }
        }
    }
}
