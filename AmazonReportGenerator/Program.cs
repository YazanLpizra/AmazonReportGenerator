using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace AmazonReportGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = ConfigurationManager.AppSettings["loginEmail"],
                password = ConfigurationManager.AppSettings["loginPassword"],
                downloadDirectory = ConfigurationManager.AppSettings["downloadDirectory"];

            SeleniumDriver driver = new SeleniumDriver(downloadDirectory);

            driver.Navigate(PathConstants.URL);

            Login(driver, email, password);
            RequestReport(driver, );

            driver.TearDown();
        }

        public static void Login(SeleniumDriver driver, string email, string password)
        {
            driver.ClearAndOverwrite(By.XPath(PathConstants.Login_EmailField), email);
            driver.ClearAndOverwrite(By.XPath(PathConstants.Login_PasswordField), password);
            driver.PressButton(By.XPath(PathConstants.Login_submitButton));
        }

        public static void RequestReport(SeleniumDriver driver, string reportType, string timePeriod, string organizedBy)
        {
            driver.DropdownSelect(By.XPath(PathConstants.Report_TypeDropDown), reportType);
            driver.DropdownSelect(By.XPath(PathConstants.Report_TimePeriodDropDown), timePeriod);
            driver.DropdownSelect(By.XPath(PathConstants.Report_OrganizedByDropDown), organizedBy);

            driver.PressButton(By.XPath(PathConstants.Report_DownloadCsvButton));
        }
    }
}
