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
    public class StoreTab
    {

        IWebDriver driver;
        By Store_button = By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/nav/ul/li[15]/a");
        By Accept_cookie = By.XPath("/html/body/div[2]/div[2]/div/div[1]/div/div[2]/div/button[1]");
        By Shop_Jerseys = By.XPath("/html/body/div[2]/div/div[14]/div[1]/div/a");
        By Select_Item = By.XPath("/html/body/div[2]/div/div[8]/div[2]/div[3]/div/div[2]/div/div/div[1]/div[1]/div[1]");
        By ConfigSize = By.XPath("/html/body/div[2]/div/div[6]/div[2]/div[12]/div/div/div[3]/div/div[2]/a[1]");
        By Addtocart_Btn = By.XPath("/html/body/div[2]/div/div[6]/div[2]/div[12]/div/div/div[5]/div/div[2]/div/div[1]/div/button");
        By Dropdown_select = By.XPath("/html/body/div[2]/div/div[6]/div[2]/div[12]/div/div/div[5]/div/div[1]/div/div/div/div/span/div[2]/ul/li[2]");

        By check_nbateam = By.XPath("//*[@id=\"side-nav\"]/div[2]/div/div[1]/div[2]/ul/li[5]/a");
        By check_gender = By.XPath("//*[@id=\"side-nav\"]/div[2]/div[2]/div[1]/div[2]/ul/li[1]/a");
        By check_sizes = By.XPath("//*[@id=\"side-nav\"]/div[2]/div[2]/div[1]/div[2]/ul/li[4]/a");
        By check_shipping = By.XPath("//*[@id=\"side-nav\"]/div[2]/div[2]/div[1]/div[2]/ul/li/a");
        By check_subdepartment = By.XPath("//*[@id=\"side-nav\"]/div[2]/div[2]/div[1]/div[2]/ul/li[2]/a");
        By check_brand = By.XPath("//*[@id=\"side-nav\"]/div[2]/div[2]/div[2]/div[2]/ul/li[1]/a");
        By check_player = By.XPath("//*[@id=\"side-nav\"]/div[2]/div[2]/div[3]/div[2]/ul/li[2]/a");
        By check_style = By.XPath("//*[@id=\"side-nav\"]/div[2]/div[2]/div[1]/div[2]/ul/li/a");
        By check_price = By.XPath("//*[@id=\"side-nav\"]/div[2]/div[2]/div[1]/div[2]/ul/li/a");


        public StoreTab(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectStoreButton()
        {
            driver.FindElement(Store_button).Click();
        }

        public void AcceptCookiesS()
        {
            driver.FindElement(Accept_cookie).Click();
        }

        public void ScrollDownHomePage()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 3500)");
        }
        public void ScrollDownStore()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 1000)");
        }
        public void ScrollDownJersey()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("window.scrollTo(0, 300)");
        }

        public void ShopButtonJerseys()
        {
            driver.FindElement(Shop_Jerseys).Click();
        }
        public void SelectJersey()
        {
            driver.FindElement(Select_Item).Click();
        }
        public void Clickpop(int x, int y)
        {
            Actions actions = new Actions(driver);
            actions.MoveByOffset(x, y).Click().Perform();
        }

        public void FilterJerseySelect()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            StoreTab storetab = new StoreTab(driver);

            driver.FindElement(check_nbateam).Click();
            System.Threading.Thread.Sleep(1000);
            storetab.Clickpop(0, 0);

            driver.FindElement(check_gender).Click();
            System.Threading.Thread.Sleep(1000);
            storetab.Clickpop(0, 0);


            driver.FindElement(check_sizes).Click();
            System.Threading.Thread.Sleep(1000);
            storetab.Clickpop(0, 0);


            driver.FindElement(check_shipping).Click();
            System.Threading.Thread.Sleep(1000);
            storetab.Clickpop(0, 0);


            driver.FindElement(check_subdepartment).Click();
            System.Threading.Thread.Sleep(1000);
            storetab.Clickpop(0, 0);


            driver.FindElement(check_brand).Click();
            System.Threading.Thread.Sleep(1000);
            js.ExecuteScript("window.scrollTo(0, 200)");
            System.Threading.Thread.Sleep(1000);
            storetab.Clickpop(0, 0);


            driver.FindElement(check_player).Click();
            System.Threading.Thread.Sleep(1000);
            storetab.Clickpop(0, 0);


            driver.FindElement(check_style).Click();
            System.Threading.Thread.Sleep(1000);
            storetab.Clickpop(0, 0);


            driver.FindElement(check_price).Click();

        }


        public void SelectSize()
        {
            driver.FindElement(ConfigSize).Click();
        }
        public void DropdownQuantity()
        {

            string LetterPlayer = "2";
            SelectElement Dropdownplayer = new SelectElement(driver.FindElement(By.XPath("/html/body/div[2]/div/div[6]/div[2]/div[12]/div/div/div[5]/div/div[1]/div/div/div/div/div[2]/select")));
            Dropdownplayer.SelectByText(LetterPlayer);
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(Dropdown_select).Click();
        }
        public void AddtoCartButton()
        {
            driver.FindElement(Addtocart_Btn).Click();
        }


    }
    
    class Test3_StoreTab
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.nba.com/");
            driver.Manage().Window.Maximize();

            var StoreTab = new StoreTab(driver);
            System.Threading.Thread.Sleep(1000);

            StoreTab.AcceptCookiesS();
            System.Threading.Thread.Sleep(1000);

            StoreTab.SelectStoreButton();
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            System.Threading.Thread.Sleep(1000);
            StoreTab.Clickpop(0, 0);
            System.Threading.Thread.Sleep(1000);
            StoreTab.ScrollDownHomePage();

            System.Threading.Thread.Sleep(2000);

            StoreTab.ShopButtonJerseys();
            System.Threading.Thread.Sleep(2000);

            //StoreTab.ScrollDownStore();
            //System.Threading.Thread.Sleep(3000);

            StoreTab.FilterJerseySelect();
            System.Threading.Thread.Sleep(2000);

            StoreTab.Clickpop(0, 0);
            StoreTab.SelectJersey();
            System.Threading.Thread.Sleep(2000);
            
            StoreTab.ScrollDownJersey();
            System.Threading.Thread.Sleep(1000);

            StoreTab.SelectSize();
            System.Threading.Thread.Sleep(1000);
            StoreTab.DropdownQuantity();
            System.Threading.Thread.Sleep(2000);

            StoreTab.AddtoCartButton();
            System.Threading.Thread.Sleep(3000);

            driver.Quit();

        }
    }
}
