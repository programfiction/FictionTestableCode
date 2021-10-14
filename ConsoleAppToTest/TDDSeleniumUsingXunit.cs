using System;
using System.Security.Cryptography.X509Certificates;
using AutoIt;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Suppost.UI;
using WebDriverManager;
using Xunit;
namespace ConsoleAppToTest
{
    public class TDDSeleniumUsingXunit
    {
        //Write test cases by choosing different browsers as an argment
        [Theory]
        [InlineData(BrowserType.Chrome)]
        public void NavigateToGoogle(BrowserType browserType)
        {
            var URL= @"https://Google.com";
            using(IWebDriver driver= new ChromeDriver())
            {
                 //Wait to load with expected condition
                WebDriverWait wait= new WebDriverWait(driver,TimeSpan.FromSeconds(TIMEOUT));
                driver.Navigate().GoToUrl(URL);
                wait.Until(ExpectedConditions.TitleContains("Google")); //wait for load 
                driver.FindElementByName("q").SendKeys("ProgramFiction"); //Find element by name, you can use by id and classname also. find read me to get selement selectos
                var elements = driver.FindElements(By.XPath("//input[@name='btnK']")); //Find elements by xpath
                foreach (var item in selements)
                {
                    if(item.GetAttribute("value")=="Google Search")
                    {
                        element= item;
                    }
                }
                element.Submit();

                //save screen shot if you need, create a helper to take screenshot and save it in desired path
                driver.SaveScreenshot("<prvide screen namename>");
                driver.Quit();
                driver.Dispose();
            }
        }
        
    }
}