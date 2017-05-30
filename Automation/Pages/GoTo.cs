namespace Automation
{
    public class GoTo
    {
        public class HomePage
        {
            public static void TheLightSource()
            {
                Driver.Instance.Navigate().GoToUrl("http://www.thelightsource.co.uk");
            }

            public static void BestAndBrown()
            {
                Driver.Instance.Navigate().GoToUrl("http://www.bestandbrown.com");
            }

            public static void LightingEnterprises()
            {
                Driver.Instance.Navigate().GoToUrl("http://www.lightingenterprises.com");
            }

            public static void LightingDesign()
            {
                Driver.Instance.Navigate().GoToUrl("http://www.lightingdesignonline.com");
            }

            public static void HotelLighting()
            {
                Driver.Instance.Navigate().GoToUrl("http://www.hotellighting.co.uk");
            }

            public static void ChandelierWinches()
            {
                Driver.Instance.Navigate().GoToUrl("http://www.chandelierwinches.com");
            }
        }
    }
}
