using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation
{
    public class ProductPage
    {
        public static bool ProductAdded
        {
            get
            {
                var added = Driver.Instance.FindElements(By.CssSelector(".view-project.primary.button"));
                if (added.Count > 0)
                    return added[0].Text == "View project";
                return false;
            }
        }

        public static void Close()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".fancybox-item.fancybox-close")));
            var closeButton = Driver.Instance.FindElement(By.CssSelector(".fancybox-item.fancybox-close"));
            closeButton.Click();
        }

        public static void Quantity(int quantity)
        {
            var quantityInput = Driver.Instance.FindElement(By.Id("add-to-project-quantity"));
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver.Instance;
            js.ExecuteScript($"document.getElementById('add-to-project-quantity').setAttribute('value', '{quantity}')");
        }

        public static void AddToProject()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("add-to-project")));
            var addToProject = Driver.Instance.FindElement(By.Id("add-to-project"));
            addToProject.Click();
        }

        public class GoTo
        {
            public static void Project()
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(".view-project.primary.button")));
                var checkout = Driver.Instance.FindElement(By.CssSelector(".view-project.primary.button"));
                checkout.Click();
            }

            public static void Checkout()
            {
                var checkout = Driver.Instance.FindElement(By.CssSelector(".begin-checkout.button.secondary"));
                checkout.Click();
            }

            public static void RelatedProducts()
            {
                var relatedProducts = Driver.Instance.FindElement(By.CssSelector(".general-info>p>a:first-of-type"));
                relatedProducts.Click();
            }

            public static void Brand()
            {
                var brand = Driver.Instance.FindElement(By.CssSelector(".general-info>p>a:last-of-type"));
                brand.Click();
            }
        }

        public static void OpenImage()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.Id("img-main")));
            var mainImage = Driver.Instance.FindElement(By.Id("img-main"));
            mainImage.Click();
        }

        public static bool ImageOpened()
        {
            try
            {
                bool isElementDisplayed = Driver.Instance.FindElement(By.ClassName("fancybox-image")).Displayed;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
