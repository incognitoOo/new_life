using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace WebAddressbookTests
{

    public class ContactHelper
    {
        private IWebDriver driver;

        public ContactHelper(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void SubmitCreationContact()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        public void FillContactData(ContactData contact)
        {
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contact.Firstname);
            driver.FindElement(By.Name("middlename")).Clear();
            driver.FindElement(By.Name("middlename")).SendKeys(contact.Middlename);
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contact.Lastname);
            driver.FindElement(By.Name("address")).Clear();
            driver.FindElement(By.Name("address")).SendKeys(contact.Address);
            driver.FindElement(By.Name("work")).Clear();
            driver.FindElement(By.Name("work")).SendKeys(contact.Work);
        }

        public void InitCreationContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }


    }
}
