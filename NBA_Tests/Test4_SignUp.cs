using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Tests
{
    public class SignUp
    {

        IWebDriver driver;

        By accept_cookie = By.XPath("/html/body/div[2]/div[2]/div/div[1]/div/div[2]/div/button[1]");
        By signin_select = By.CssSelector("#nav-controls > ul > li > button");
        By signin_button = By.CssSelector("#nav-controls > ul > li > div > div > ul > li:nth-child(1) > a");
        By createid_button = By.XPath("//*[@id=\"__next\"]/div[2]/div[2]/div/div/div/form/div/a[2]");

        By email = By.XPath("//*[@id=\"email\"]");
        By password = By.XPath("//*[@id=\"password\"]");
        By fname = By.XPath("//*[@id=\"firstName\"]");
        By lname = By.XPath("//*[@id=\"lastName\"]");
        By checkbox_privacy = By.XPath("//*[@id=\"__next\"]/div[2]/div[2]/div/div/form/div[1]/div[7]/label");
        By checkbox_email = By.XPath("//*[@id=\"__next\"]/div[2]/div[2]/div/div/form/div[1]/div[8]/label");
        By create_button = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/form/div[1]/button");

        By fav_team1 = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[1]/button[3]");
        By fav_team2 = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[1]/button[23]");
        By next_button = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[2]/button");
        By fav_team3 = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[1]/button[1]");
        By next_button2 = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[2]/button[2]");
        By ml_button = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[2]/a[2]");

        public SignUp(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectSignUpButton()
        {
            driver.FindElement(signin_select).Click();
            driver.FindElement(signin_button).Click();
            System.Threading.Thread.Sleep(1000);
        }

        public void SelectSignUpSelect()
        {

            driver.FindElement(createid_button).Click();
            System.Threading.Thread.Sleep(1000);
        }


        public void FillInformation()
        {
            driver.FindElement(email).SendKeys("test345@testcdf.com");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(password).SendKeys("Password2022*");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(fname).SendKeys("Marcos");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(lname).SendKeys("Reyes");
            System.Threading.Thread.Sleep(1000);

            string Month = "04";
            SelectElement Dropdownmonth = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div[2]/div/div/form/div[1]/div[5]/div/div[1]/label/div/select")));
            Dropdownmonth.SelectByValue(Month);
            System.Threading.Thread.Sleep(1000);

            string Year = "1990";
            SelectElement Dropdownyear = new SelectElement(driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/form/div[1]/div[5]/div/div[2]/label/div/select")));
            Dropdownyear.SelectByText(Year);
            System.Threading.Thread.Sleep(1000);

            string Country = "US";
            SelectElement Dropdowncountry = new SelectElement(driver.FindElement(By.XPath("//*[@id=\"__next\"]/div[2]/div[2]/div/div/form/div[1]/div[6]/div/label/div/select")));
            Dropdowncountry.SelectByValue(Country);
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(checkbox_privacy).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(checkbox_email).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(create_button).Click();

        }

        public void AcceptCookiesSU()
        {
            driver.FindElement(accept_cookie).Click();
        }
        public void Preference_Account()
        {
            driver.FindElement(fav_team1).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(fav_team2).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(next_button).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(fav_team3).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(next_button2).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(ml_button).Click();
        }

    }
    
    class Test4_SignUp
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.nba.com/account/sign-in");
            driver.Manage().Window.Maximize();

            var SignUp = new SignUp(driver);
            System.Threading.Thread.Sleep(1000);

            SignUp.AcceptCookiesSU();
            System.Threading.Thread.Sleep(1000);

            SignUp.SelectSignUpButton();

            SignUp.SelectSignUpSelect();
            System.Threading.Thread.Sleep(3000);

            SignUp.FillInformation();
            System.Threading.Thread.Sleep(5000);

            SignUp.Preference_Account();
            System.Threading.Thread.Sleep(2000);

            driver.Quit();

        }
    }
}
