
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.PhantomJS;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Threading;

namespace AmazonReportGenerator
{
    public class SeleniumDriver
    {
        private IWebDriver _driver;

        public IWebDriver Driver => _driver;

        public SeleniumDriver(string downloadDirectory)
        {
            if (!Directory.Exists(downloadDirectory)) Directory.CreateDirectory(downloadDirectory);

            var chromeOptions = new ChromeOptions();

            chromeOptions.AddUserProfilePreference("download.default_directory", downloadDirectory);
            chromeOptions.AddUserProfilePreference("download.prompt_for_download", false);
            chromeOptions.AddUserProfilePreference("disable-popup-blocking", "true");
            //chromeOptions.AddArgument("--no-startup-window");

            _driver = new ChromeDriver(chromeOptions);
            _driver.Manage().Timeouts().ImplicitWait = new TimeSpan(0, 0, 30);
        }

        public void Navigate(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public void ClearAndOverwrite(By by, string newValue)
        {
            Find(_driver, by).Clear();
            Find(_driver, by).SendKeys(newValue);
        }

        public void PressButton(By by)
        {
            Find(_driver, by).Click();
        }

        public void DropdownSelect(By by, string text)
        {
            SelectElement dropdown = new SelectElement(Find(_driver, by));
            dropdown.SelectByText(text);
        }

        public static IWebElement Find(IWebDriver driver, By by)
        {
            for (int milis = 0; milis < 3000; milis = milis + 200)
            {
                try
                {
                    return driver.FindElement(by);

                }
                catch (Exception ignore)
                {
                    Thread.Sleep(200);
                }
            }
            throw new Exception("ElementNotFound");
        }

        public void TearDown()
        {
            if (_driver != null)
            {
                _driver.Quit();
                _driver.Dispose();
            }
        }
    }
}