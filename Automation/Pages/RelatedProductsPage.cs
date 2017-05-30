using OpenQA.Selenium;

namespace Automation
{
    public class RelatedProductsPage
    {
        public class GoTo
        {
            public static void Product(int productNumber)
            {
                var product = Driver.Instance.FindElement(By.XPath($".//div[@class='results']/a[{productNumber}]"));
                product.Click();
            }
        }
    }
}
