using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace PracticeProject.Hooks
{
    [Binding]
    public class BaseTest
    {

        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
);
            driver.Manage().Window.Maximize();
        }

        //[AfterScenario]
        //public void AfterScenario()
        //{
        //    driver.Quit();
        //}
    }
}