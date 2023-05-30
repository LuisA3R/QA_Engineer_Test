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
    public class SignIn
    {

        IWebDriver driver;

        By accept_cookie = By.XPath("/html/body/div[2]/div[2]/div/div[1]/div/div[2]/div/button[1]");
        By signin_select = By.CssSelector("#nav-controls > ul > li > button");
        By signin_button = By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/nav/div/div/ul/li/div/div/ul/li[1]/a");
        By edit_button = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div[1]/div[2]/div[1]/div/div/a");

        By email_enter = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/div[1]/input");
        By pass_enter = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/div[2]/input");
        By signin_enter = By.XPath("/html/body/div[1]/div[2]/div[2]/div/div/div/form/div/button");

        By fname_edit = By.XPath("//*[@id=\"givenName\"]");
        By lname_edit = By.XPath("//*[@id=\"familyName\"]");
        By save_button = By.XPath("/html/body/div[4]/div/div/div/div[2]/form/div[5]/button");
        By close_button = By.XPath("/html/body/div[4]/div/div/button");

        public SignIn(IWebDriver driver)
        {
            this.driver = driver;
        }
        public void AcceptCookiesSI()
        {
            driver.FindElement(accept_cookie).Click();
        }
        public void SelectSignInButton()
        {
            driver.FindElement(signin_select).Click();
            driver.FindElement(signin_button).Click();
            System.Threading.Thread.Sleep(1000);
        }
        public void SignInEnter()
        {
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(email_enter).SendKeys("test@testsecond.com");
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(pass_enter).SendKeys("Password2022*");
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(signin_enter).Click();
            System.Threading.Thread.Sleep(2000);
        }

        public void EditSignInButton()
        {
            driver.FindElement(edit_button).Click();
        }

        public void EditInfo()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//*[@id=\"givenName\"]")).Clear();
            driver.FindElement(fname_edit).SendKeys("Marcos");
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(By.XPath("//*[@id=\"familyName\"]")).Clear();
            driver.FindElement(lname_edit).SendKeys("Reyes");
            System.Threading.Thread.Sleep(1000);

            string month_edit = "04";
            SelectElement Dropdownmonth = new SelectElement(driver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[2]/form/div[3]/div[1]/div/select")));
            Dropdownmonth.SelectByValue(month_edit);
            System.Threading.Thread.Sleep(1000);

            string year_edit = "1990";
            SelectElement Dropdownyear = new SelectElement(driver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[2]/form/div[3]/div[2]/div/select")));
            Dropdownyear.SelectByText(year_edit);
            System.Threading.Thread.Sleep(1000);

            string country_edit = "US";
            SelectElement Dropdowncountry = new SelectElement(driver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[2]/form/div[4]/div/select")));
            Dropdowncountry.SelectByValue(country_edit);
            System.Threading.Thread.Sleep(1000);

            driver.FindElement(save_button).Click();
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(close_button).Click();
            System.Threading.Thread.Sleep(1000);
            js.ExecuteScript("window.scrollTo(0, 200)");
        }





    }
    
    class Test5_SignIn
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.nba.com/account/sign-in");
            driver.Manage().Window.Maximize();

            var SignIn = new SignIn(driver);
            System.Threading.Thread.Sleep(1000);

            SignIn.AcceptCookiesSI();
            System.Threading.Thread.Sleep(1000);

            SignIn.SignInEnter();
            System.Threading.Thread.Sleep(4000);

            SignIn.SelectSignInButton();
            System.Threading.Thread.Sleep(3000);


            SignIn.EditSignInButton();
            System.Threading.Thread.Sleep(2000);

            SignIn.EditInfo();
            System.Threading.Thread.Sleep(2000);


            driver.Quit();

        }
    }
}
