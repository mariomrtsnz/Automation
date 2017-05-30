using OpenQA.Selenium;

namespace Automation
{
    public class BAB_ProjectPage
    {
        public static bool ItemDoesntExist
        {
            get
            {
                var items = Driver.Instance.FindElements(By.CssSelector("#ng-app>main>div>h2"));
                if (items.Count > 0)
                    return items[0].Text == "Your Shopping Basket is empty";
                return false;
            }
        }

        public static void GoToProduct()
        {
            var product = Driver.Instance.FindElement(By.XPath("(.//td[@class='sku-details']/a)[last()]/div[@class='text']"));
            product.Click();
        }

        public static void ChangeShippingTo(string shippingDestination)
        {
            var shippingTo = Driver.Instance.FindElement(By.Id("shipping-country"));
            var selectCountry = shippingTo.FindElement(By.XPath($".//option[contains(text(), '{shippingDestination}')]"));
            selectCountry.Click();
        }
    }
}
