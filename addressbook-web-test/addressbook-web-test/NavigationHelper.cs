using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {        
        private string baseURL;

        public NavigationHelper(IWebDriver driver, string baseURL) 
            : base(driver)
        {
            this.baseURL = baseURL;
        }
        public void OpenMainPage()
        {
            driver.Navigate().GoToUrl(baseURL = "http://localhost/addressbook/");
        }

        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }

        public void ReturnToHomepage()
        {
            driver.FindElement(By.LinkText("home")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();
        }
        
    }
}
