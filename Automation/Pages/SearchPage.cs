using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation
{
    public class SearchPage
    {
        public class RefineBy
        {
            public static void SubCategories(string subcategory)
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//h3[contains(text(), 'Sub-categories')]/..//label/span[contains(text(), '{subcategory}')]")));
                var subCategory = Driver.Instance.FindElement(By.XPath($".//h3[contains(text(), 'Sub-categories')]/..//label/span[contains(text(), '{subcategory}')]"));
                subCategory.Click();
            }

            public static void Shapes(int shape)
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Shapes')]/..//li[{shape}]/label/span")));
                var shapeFilter = Driver.Instance.FindElement(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Shapes')]/..//li[{shape}]/label/span"));
                shapeFilter.Click();
            }

            public static void Styles(int style)
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Styles')]/..//li[{style}]/label/span")));
                var styleFilter = Driver.Instance.FindElement(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Styles')]/..//li[{style}]/label/span"));
                styleFilter.Click();
            }

            public static void Themes(int theme)
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Themes')]/..//li[{theme}]/label/span")));
                var themeFilter = Driver.Instance.FindElement(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Themes')]/..//li[{theme}]/label/span"));
                themeFilter.Click();
            }

            public static PriceCommand Price(string from)
            {
                return new PriceCommand(from);
            }
            public class PriceCommand
            {
                private readonly string from;
                private string to;

                public PriceCommand(string from)
                {
                    this.from = from;
                }

                public PriceCommand To(string to)
                {
                    this.to = to;
                    return this;
                }

                public void Go()
                {
                    WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                    IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".price.ng-pristine.ng-valid:nth-of-type(1)")));
                    var fromInput = Driver.Instance.FindElement(By.CssSelector(".price.ng-pristine.ng-valid:nth-of-type(1)"));
                    fromInput.SendKeys(from);

                    IWebElement toElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".price.ng-pristine.ng-valid:nth-of-type(2)")));
                    var toInput = Driver.Instance.FindElement(By.CssSelector(".price.ng-pristine.ng-valid:nth-of-type(2)"));
                    toInput.SendKeys(to);

                    IWebElement goElement = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".filter-values-container>.button")));
                    var goButton = Driver.Instance.FindElement(By.CssSelector(".filter-values-container>.button"));
                    goButton.Click();
                }
            }

            public static void Brand(int brandNumber)
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Brand')]/..//li[{brandNumber}]/label/span")));
                var brand = Driver.Instance.FindElement(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Brand')]/..//li[{brandNumber}]/label/span"));
                brand.Click();
            }

            public static void Colour(int colour)
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Colour')]/..//li[{colour}]/label/span")));
                var colourFilter = Driver.Instance.FindElement(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Colour')]/..//li[{colour}]/label/span"));
                colourFilter.Click();
            }

            public static void Material(int material)
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Material')]/..//li[{material}]/label/span")));
                var materialFilter = Driver.Instance.FindElement(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Material')]/..//li[{material}]/label/span"));
                materialFilter.Click();
            }

            public static void Finish(int finish)
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Finish')]/..//li[{finish}]/label/span")));
                var finishFilter = Driver.Instance.FindElement(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Finish')]/..//li[{finish}]/label/span"));
                finishFilter.Click();
            }

            public static void Range(int range)
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Range')]/..//li[{range}]/label/span")));
                var rangeFilter = Driver.Instance.FindElement(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Range')]/..//li[{range}]/label/span"));
                rangeFilter.Click();
            }
        }

        public static void GoToPage(int pageNumber)
        {
            var page = Driver.Instance.FindElement(By.XPath($".//ul[@class='pagination ng-isolate-scope ng-pristine ng-valid']//a[contains(text(), '{pageNumber}')]"));
            page.Click();
        }

        public static void GoToProduct(int productNumber)
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(15));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath($".//div[@class='results']/a[{productNumber}]")));
            var product = Driver.Instance.FindElement(By.XPath($".//div[@class='results']/a[{productNumber}]"));
            product.Click();
        }

        public static void OrderBy(string order)
        {
            var orderBy = Driver.Instance.FindElement(By.CssSelector("#pager-top>.order-by>select"));
            orderBy.Click();
            var orderOption = Driver.Instance.FindElement(By.XPath($".//div[@id='pager-top']/div[@class='order-by']/select/option[contains(text(), '{order}')]"));
            orderOption.Click();
        }

        public static void ChangeView(int number)
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(60));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName($"view{number}")));
            var viewStyle = Driver.Instance.FindElement(By.ClassName($"view{number}"));
            viewStyle.Click();
        }
    }
}
