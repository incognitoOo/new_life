﻿
using OpenQA.Selenium;


namespace WebAddressbookTests
{
    public class LoginHelper
    {
        private IWebDriver driver;
        public LoginHelper(IWebDriver driver) {

        this.driver = driver;
        }

        public  void Login(AccountData account)
        {
            driver.FindElement(By.Name("user")).Clear();
            driver.FindElement(By.Name("user")).SendKeys(account.Username);
            driver.FindElement(By.Name("pass")).Clear();
            driver.FindElement(By.Name("pass")).SendKeys(account.Userpassword);
            driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }
    }
}
