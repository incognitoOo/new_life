using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class TestBase
    {

        protected ApplicationManagers app;

        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManagers();
        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
           
        }


     

        

        
    }
}
