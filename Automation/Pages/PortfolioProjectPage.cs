using OpenQA.Selenium;

namespace Automation
{
    public class PortfolioProjectPage
    {
        public static void Picture(int pictureNumber)
        {
            var selectPicture = Driver.Instance.FindElement(By.XPath($".//*[@class='overview']/li[{pictureNumber}]/img"));
            selectPicture.Click();
        }

        public static void OpenModal()
        {
            var openModal = Driver.Instance.FindElement(By.Id("img-main"));
            openModal.Click();
        }

        public static void CloseModal()
        {
            var closeModal = Driver.Instance.FindElement(By.CssSelector(".fancybox-item.fancybox-close"));
            closeModal.Click();
        }

        public static void NextPicture()
        {
            var nextButton = Driver.Instance.FindElement(By.CssSelector("a.main-image-rotator.next"));
            nextButton.Click();
        }

        public static void GoToWeb()
        {
            var website = Driver.Instance.FindElement(By.CssSelector("#client-web-link>a"));
            website.Click();
        }
    }
}