using OpenQA.Selenium;

namespace Automation
{
    public class PortfolioPage
    {
        public static bool IsAt(string filterName)
        {
            var name = Driver.Instance.FindElements(By.ClassName("for-list"));
            if (name.Count > 0)
                return name[0].Text == $"{filterName}";
            return false;
        }

        public static void GoToPortfolioProject(int projectNumber)
        {
            var project = Driver.Instance.FindElement(By.XPath($".//*[@id='portfolio-results']/a[{projectNumber}]/img"));
            project.Click();
        }

        public static void NextPage()
        {

            var nextButton = Driver.Instance.FindElement(By.LinkText("Next"));
            nextButton.Click();
        }

        public static void PreviousPage()
        {
            var prevButton = Driver.Instance.FindElement(By.LinkText("Previous"));
            prevButton.Click();
        }

        public static void Filter(string filterName)
        {
            var filter = Driver.Instance.FindElement(By.LinkText($"{filterName}"));
            filter.Click();
        }

        public static void Page(int pageNumber)
        {
            var numberButton = Driver.Instance.FindElement(By.XPath($".//*[@id='pager_T']/ul/li[{pageNumber}]/a"));
            numberButton.Click();
        }
    }
}
