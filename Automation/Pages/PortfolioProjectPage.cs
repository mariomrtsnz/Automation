using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Automation
{
    public class PortfolioProjectPage
    {
        public static void Picture(int pictureNumber)
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($".//*[@class='overview']/li[{pictureNumber}]/img")));
            var selectPicture = Driver.Instance.FindElement(By.XPath($".//*[@class='overview']/li[{pictureNumber}]/img"));
            selectPicture.Click();
        }

        public static void OpenModal()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("img-main")));
            var openModal = Driver.Instance.FindElement(By.Id("img-main"));
            openModal.Click();
        }

        public static void CloseModal()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".fancybox-item.fancybox-close")));
            var closeModal = Driver.Instance.FindElement(By.CssSelector(".fancybox-item.fancybox-close"));
            closeModal.Click();
        }

        public static void NextPicture()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("a.main-image-rotator.next")));
            var nextButton = Driver.Instance.FindElement(By.CssSelector("a.main-image-rotator.next"));
            nextButton.Click();
        }

        public static void GoToWeb()
        {
            WebDriverWait wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#client-web-link>a")));
            var website = Driver.Instance.FindElement(By.CssSelector("#client-web-link>a"));
            website.Click();
        }
    }
}