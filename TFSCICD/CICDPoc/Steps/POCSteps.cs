using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System.Collections.Generic;
using System.Configuration;
using DecaAutomationFramework;
using SharedHelperClass;

namespace CICDPoc.Steps
{
    [Binding]
    public class POCSteps
    {
        ChromeDriver driver;

        [Given(@"I have launched test site")]
        public void GivenIHaveLaunchedTestSite()
        {
            //Functions._Login(driver, url);

            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--log-level=1");
            
            driver = new ChromeDriver(options);
            //Functions._Login(driver, "");
            driver.Manage().Cookies.DeleteAllCookies(); //delete all cookies
            Thread.Sleep(5000); //wait 5 seconds to clear cookies.
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);
            driver.Navigate().GoToUrl("https://www.google.com");
            Thread.Sleep(15000);

        }


 

    }
}
