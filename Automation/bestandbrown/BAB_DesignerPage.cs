using OpenQA.Selenium;

namespace Automation
{
    public class BAB_DesignerPage
    {
        public static void ViewAllProducts()
        {
            var viewAllProducts = Driver.Instance.FindElement(By.XPath("(.//span[contains(text(), 'View all')])[1]"));
            viewAllProducts.Click();
        }
    }
}
