using OpenQA.Selenium;

namespace Automation
{
    public class BrandPage
    {
        public static void ViewAllProducts()
        {
            var viewAllProducts = Driver.Instance.FindElement(By.XPath("(.//span[contains(text(), 'View all')])[1]"));
            viewAllProducts.Click();
        }

        public static void GoToLatestProduct(int productNumber)
        {
            var product = Driver.Instance.FindElement(By.XPath($".//h3[contains(text(), 'Latest')]/../..//a[{productNumber}]"));
            product.Click();
        }
    }
}
