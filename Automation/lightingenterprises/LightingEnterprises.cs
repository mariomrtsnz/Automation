using OpenQA.Selenium;

namespace Automation
{
    public class LightingEnterprises
    {
        public static bool ShowingMore()
        {
            var name = Driver.Instance.FindElements(By.Id("toggle"));
            if (name.Count > 0)
                return name[0].Text == "Show less";
            return false;
        }

        public class OurTeam
        {
            public static void NextPage()
            {
                var nextPage = Driver.Instance.FindElement(By.CssSelector(".bx-next>img"));
                nextPage.Click();
            }

            public static void PreviousPage()
            {
                var prevPage = Driver.Instance.FindElement(By.CssSelector(".bx-prev>img"));
                prevPage.Click();
            }
        }

        public class Projects
        {
            public static void FilterBy(string filterName)
            {
                var filter = Driver.Instance.FindElement(By.XPath($".//span/h5[contains(text(), '{filterName}')]"));
                filter.Click();
            }

            public static bool FilteredBy(string filterName)
            {
                var name = Driver.Instance.FindElements(By.CssSelector(".filter.active>h5"));
                if (name.Count > 0)
                    return name[0].Text == $"{filterName}";
                return false;
            }

            public static void OpenModal()
            {
                var project = Driver.Instance.FindElement(By.CssSelector(".portfolio-wrapper>img"));
                project.Click();
            }

            public static void CloseModal()
            {
                var closeButton = Driver.Instance.FindElement(By.CssSelector(".modal>div>p"));
                closeButton.Click();
            }
        }

        public class GoTo
        {
            public static void Home()
            {
                var home = Driver.Instance.FindElement(By.Id("home"));
                home.Click();
            }

            public static void About()
            {
                var about = Driver.Instance.FindElement(By.Id("about"));
                about.Click();
            }

            public static void Websites()
            {
                var websites = Driver.Instance.FindElement(By.Id("websites"));
                websites.Click();
            }

            public static void OurTeam()
            {
                var ourTeam = Driver.Instance.FindElement(By.Id("ourTeam"));
                ourTeam.Click();
            }

            public static void Projects()
            {
                var projects = Driver.Instance.FindElement(By.Id("menuProjects"));
                projects.Click();
            }

            public static void Blog()
            {
                var blog = Driver.Instance.FindElement(By.Id("blog"));
                blog.Click();
            }

            public static void Contact()
            {
                var contact = Driver.Instance.FindElement(By.Id("contact"));
                contact.Click();
            }

            public static void Brands()
            {
                var brands = Driver.Instance.FindElement(By.CssSelector(".new-service-item:nth-of-type(3)>.newave-button"));
                brands.Click();
            }
        }

        public static void ShowBrands()
        {
            var toggleSwitch = Driver.Instance.FindElement(By.Id("toggle"));
            toggleSwitch.Click();
        }

        public static SendMessageCommand SendMessageAs(string fullName)
        {
            return new SendMessageCommand(fullName);
        }
        public class SendMessageCommand
        {
            private readonly string fullName;
            private string phone;
            private string email;
            private string message;

            public SendMessageCommand(string fullName)
            {
                this.fullName = fullName;
            }

            public SendMessageCommand WithPhone(string phone)
            {
                this.phone = phone;
                return this;
            }

            public SendMessageCommand WithEmail(string email)
            {
                this.email = email;
                return this;
            }

            public SendMessageCommand WithMessage(string message)
            {
                this.message = message;
                return this;
            }

            public void Send()
            {
                var name = Driver.Instance.FindElement(By.Id("Name"));
                name.SendKeys(fullName);

                var phone = Driver.Instance.FindElement(By.Id("Phone"));
                phone.SendKeys(this.phone);

                var email = Driver.Instance.FindElement(By.Id("Email"));
                email.SendKeys(this.email);

                var message = Driver.Instance.FindElement(By.Id("Message"));
                message.SendKeys(this.message);

                var sendButton = Driver.Instance.FindElement(By.Id("send"));
                sendButton.Click();
            }
        }

        public static bool ElementsRequired()
        {
            try
            {
                bool isElementDisplayed = Driver.Instance.FindElement(By.Id("Name-error")).Displayed;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ValidEmail()
        {
            var name = Driver.Instance.FindElements(By.Id("Email-error"));
            if (name.Count > 0)
                return name[0].Text == "Must be a valid email";
            return false;
        }

        public static void ClearContactForm()
        {
            var name = Driver.Instance.FindElement(By.Id("Name"));
            name.Clear();

            var phone = Driver.Instance.FindElement(By.Id("Phone"));
            phone.Clear();

            var email = Driver.Instance.FindElement(By.Id("Email"));
            email.Clear();

            var message = Driver.Instance.FindElement(By.Id("Message"));
            message.Clear();
        }

        public static bool MessageSent()
        {
            try
            {
                bool isElementDisplayed = Driver.Instance.FindElement(By.Id("popup")).Displayed;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}