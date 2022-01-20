using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using PracticeProject.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PracticeProject.PageObjects
{
    public class LoginPage
    {
        IWebDriver driver;

        public LoginPage() 
        
        { 
            driver = BaseTest.driver;
        }

        public By email = By.CssSelector("input[name='email']");
        public By password = By.CssSelector("input[name='password']");
        public By button = By.CssSelector("#app > div > div.wrapper > div > div > div.view > div > div.container > div > form > div > div.row > div.col-xs-5.login__button.block-mt > button");
        public By jobTitle = By.CssSelector("input[name ='title']");
        public By jobCategory = By.CssSelector("[name='categoryId']");
        public By Description = By.CssSelector("[name='description']");
        public By dressCode = By.CssSelector("input[name='dressCode']");
       // public By experienceLevel = By.CssSelector("#app > div > div.wrapper > div > div > div.view > div > div.job-what-state.container > div > div.col-xs-8 > div:nth-child(1) > div:nth-child(4) > div:nth-child(2) > div > div.jobcats__select > select");
       public By experienceLevel = By.CssSelector("[name='experience']");
    public void Navigate(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmail(string emailtext)
        {
            driver.FindElement(email).SendKeys(emailtext);
        }

        public void EnterPassword(string passwordtext)
        {
            driver.FindElement(password).SendKeys(passwordtext);
        }

        public void ClickButton()
        {
            driver.FindElement(button).Click(); 
        }

        public void EnterJobTitle(string jobtitletext)
        {
            Thread.Sleep(5000);
            driver.FindElement(jobTitle).SendKeys(jobtitletext);
        }

        public void SelectJobCategory()
        {
            SelectElement select = new SelectElement(driver.FindElement(jobCategory));
            select.SelectByValue("3708b930-0b41-11e8-bb63-5f7f3f7883aa");
        }

        public void EnterDescription(string descriptiontext)
        {
            driver.FindElement(Description).SendKeys(descriptiontext);
        }

        public void EnterDressCode(string dressCodetext)
        {
            driver.FindElement(dressCode).SendKeys(dressCodetext);
        }
        
        public void SelectExperienceLevel()
        {
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(driver.FindElement(experienceLevel));
            select.SelectByValue("Moderate");
        }


        

    }
}
