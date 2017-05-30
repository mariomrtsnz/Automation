using OpenQA.Selenium;

namespace Automation
{
    public class BAB_RangePage
    {
        public static void ViewAllProducts()
        {
            var viewAllProducts = Driver.Instance.FindElement(By.XPath(".//span[contains(text(), 'View all')]"));
            viewAllProducts.Click();
        }

        public static void GoToProduct(int productNumber)
        {
            var product = Driver.Instance.FindElement(By.XPath($"(.//div[@class='results'])[1]/a[{productNumber}]"));
            product.Click();
        }
    }
}
