using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation
{
    public class BAB_SearchPage
    {
        public static void ChangeView(int number)
        {
            var viewStyle = Driver.Instance.FindElement(By.ClassName($"view{number}"));
            viewStyle.Click();
        }

        public class RefineBy
        {
            public static void Designer (int designerNumber)
            {
                WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
                IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Designer')]/..//li[{designerNumber}]/label/span")));
                var designer = Driver.Instance.FindElement(By.XPath($".//h3[@class='filter-header'][contains(text(), 'Designer')]/..//li[{designerNumber}]/label/span"));
                designer.Click();
            }
        }
    }
}
