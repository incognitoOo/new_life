using OpenQA.Selenium;

namespace WebAddressbookTests
{
   public class GroupHelper
    {
        private IWebDriver driver;
        public GroupHelper(IWebDriver driver)
        {

            this.driver = driver;
        }

        public  void SubmitGroupCreation()
        {
            driver.FindElement(By.Name("submit")).Click();
        }

        public void FillGroupFields(GroupData group)
        {
            driver.FindElement(By.Name("group_name")).Clear();
            driver.FindElement(By.Name("group_name")).SendKeys(group.GroupName);
            driver.FindElement(By.Name("group_header")).Clear();
            driver.FindElement(By.Name("group_header")).SendKeys(group.GroupHeader);
            driver.FindElement(By.Name("group_footer")).Clear();
            driver.FindElement(By.Name("group_footer")).SendKeys(group.GroupFooter);
        }

        public void InitCreationGroup()
        {
            driver.FindElement(By.Name("new")).Click();
        }

    }
}
