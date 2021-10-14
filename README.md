# FictionTestableCode project deals with Automation using Selenium framework, Xunit in .Net5 
***
##Project Details
This project is about Creating Unit test cases with Nunit, Xunit using Selenium automation in .net5 framework.
- Examples
    - Ways to write code in `C#` that is more easy test with any unti testing framework. in file `TestableInvoiceGeneratorTest`
    - TDD : Automated browser testing using selenium framework
        - How to write unit test using Selenium framwork for any website. in file `TDDSeleniumUsingXunit.cs`
        - How to write unit test for basic authencation prompted by browser.  in fle WebDriverFixture.cs
        - How to share driver objects with multiple test cases. in file `WebDriverFixture.cs`  
---
## FAQ
- #### Question:  What is TDD?
    - Answer: Test-driven development is a software development process relying on software requirements being converted to test cases before software is fully developed, and tracking all software development by repeatedly testing the software against all test cases.
- #### Question:  What is Selenium WebDriver?
    - Answer: Selenium WebDriver is a web framework that permits you to execute cross-browser tests. This tool is used for automating web-based application testing to verify that it performs expectedly. Selenium WebDriver allows you to choose a programming language to create test scripts.
- #### Question:  What is Selenium WebDriver Headless?
    - Answer:The webdriver in Selenium is an automation framework used to carry out testing in the web in multiple browsers. It can support more than one operating system as well. It comes with no cost. .Net Selenium webdriver can be used HTMLUnit browsers which are headless in nature. Thus the execution can happen in invisible mode without a GUI
---

## Technologies Used
- `Vscode` latest : IDE used to develop
- `C#` .Net 5 : Language and framewrok
- `Nunit` ltest/ Xunit latest : nuget test library from nuget
- `Moq` latest : nuget library to mock objects from nuget
- `AutoMoq` latest : nuget auto mock library from nuget
- `Ninject` latest : nuget to inject dependencies from nuget
- `Selenium` latest version : nuget to create TDD/unit test cases
- `Selenium Chrome driver` latest version : nuget to run selenium related test cases
- `AutoIt` : nuget to help with basis authentication in browser if needed in lower environment
- `Web driver manager`: nuget to help in test case creation

 ```yaml
 <PackageReference Include="AutoItX.Dotnet" Version="3.3.14.5" />
    <PackageReference Include="AutoMoq" Version="2.0.0" />
    <PackageReference Include="Moq" Version="4.16.1" />
    <PackageReference Include="Ninject" Version="3.3.4" />
    <PackageReference Include="NUnit" Version="3.13.2" />
    <PackageReference Include="Selenium.WebDriver" Version="4.0.0" />
    <PackageReference Include="Selenium.WebDriver.ChromeDriver" Version="94.0.4606.6100" />
    <PackageReference Include="WebDriverManager" Version="2.12.1" />
    <PackageReference Include="xunit" Version="2.4.1" />
 ```
 ---
### Selenium Locators


| locator | Sample code .net   | sample code java|
| ---   | --- | --- |
| By.Id | driver.FindElement(By.Id("element id") | driver.findElement(By.id("element id")|
| By.Name | driver.FindElement(By.Name("element name") | driver.findElement(By.name("element name") |
| By.LinkText | driver.FindElement(By.LinkText("link text"))  | driver.findElement(By.linkText("link text"))  |
| By.PartialLinkText | driver.FindElement(By.PartialLinkText("link text")) |driver.findElement(By.partialLinkText("link text")) |
| By.ClassName | driver.FindElement(By.ClassName("classname")) | driver.findElement(By.className("classname")) |
| By.TagName | driver.FindElements(By.TagName(tagname")) | driver.findElements(By.tagName(tagname")) |
| By.CssSelector| driver.FindElement(By.CssSelector("input[attributename='btnK']"))  |driver.findElement(By.cssSelector("input[attributename='btnK']"))  |
| By.Xpath| driver.FindElement(By.Xpath("//input[@attributename='btnK']"))  |driver.findElement(By.xpath("//input[@attributename='btnK']"))  |

### Navigation commands
| Commands | Sample use .net  | Sample use Java |
| ---   | --- | --- |
| Get | NA | driver.get("url")|
| Close | driver.Close() | driver.close() |
| Quit | driver.Quit() | driver.quit() |
| Title/getTitle | driver.Title | driver.getTitle()
| Url/getCurrentUrl | driver.Url | driver.getCurrentUrl() |
| .GotoUrl() /.to() | driver.Navigate().GotoUrl("Url")| driver.navigate.to("url") |
| back | Navigate().Back()| navigate().back()|
| forward | Navigate().Froward()| navigate().forward()|
| refresh | Navigate().Refresh()| navigate().refresh()|

### Wait Command
