using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Threading;

namespace BrowserStackBooksWagon.Base
{
    [TestFixture]
    public class BaseClass
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        [Obsolete]
        public void init()
        {
              string USERNAME = "pushkarmorey1";
              string ACCESSKEY = "rAYxqN4QL9WBbqDhXpPp";
              string URL = "https://" + USERNAME + ":" + ACCESSKEY + "@www.bookswagon.com/";

              DesiredCapabilities capability = new DesiredCapabilities();
              capability.SetCapability("os_version", "8.1");
              capability.SetCapability("resolution", "1920x1080");
              capability.SetCapability("browser", "Chrome");
              capability.SetCapability("browser_version", "81.0");
              capability.SetCapability("os", "Windows");
              capability.SetCapability("browserstack.debug", "true");
              capability.SetCapability("browserstack.video", "false");
              capability.SetCapability("project", "Test");
              capability.SetCapability("build", "Build1");
              capability.SetCapability("name", "Test1");
              capability.SetCapability("browserstack.local", "false");
              capability.SetCapability("browserstack.selenium_version", "3.14.0");
              capability.SetCapability("browserstack.user", "pushkarmorey1");
              capability.SetCapability("browserstack.key", "rAYxqN4QL9WBbqDhXpPp");

              driver = new RemoteWebDriver(
                new Uri("https://hub-cloud.browserstack.com/wd/hub/"), capability
              );

                         
              driver.Manage().Window.Maximize();
              driver.Navigate().GoToUrl("https://www.bookswagon.com/");
           
        }

        [OneTimeTearDown]
        public void Close()
        {
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
