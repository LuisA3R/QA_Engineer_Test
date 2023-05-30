using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBA_Tests
{
    public class PlayerTab
    {
        IWebDriver driver;
        By Players_button = By.XPath("/html/body/div[1]/div[2]/div[1]/div[1]/nav/ul/li[10]/a");
        By Accept_cookie = By.XPath("/html/body/div[2]/div[2]/div/div[1]/div/div[2]/div/button[1]");
        By Switch_show = By.XPath("/html/body/div[1]/div[2]/div[2]/main/div[2]/section/div/div[2]/div[1]/div[6]/label/div");
        By Search_Player = By.XPath("/html/body/div[1]/div[2]/div[2]/main/div[2]/section/div/div[1]/div/div/input");
        By Select_Player = By.XPath("/html/body/div[1]/div[2]/div[2]/main/div[2]/section/div/div[2]/div[2]/div/div/div/table/tbody/tr/td[1]/a");
        public PlayerTab(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectButtonPLayer()
        {
            driver.FindElement(Players_button).Click();
        }

        public void AcceptCookiesP()
        {
            driver.FindElement(Accept_cookie).Click();
        }
        public void SelectDropdownPLayer()
        {
            driver.FindElement(Switch_show).Click();
            System.Threading.Thread.Sleep(2000);

            string LetterPlayer = "K";
            SelectElement Dropdownplayer = new SelectElement(driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/main/div[2]/section/div/div[2]/div[1]/div[1]/label/div/select")));
            Dropdownplayer.SelectByValue(LetterPlayer);
            System.Threading.Thread.Sleep(2000);

            string TeamPlayer = "76ers";
            SelectElement Dropdownteam = new SelectElement(driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/main/div[2]/section/div/div[2]/div[1]/div[2]/label/div/select")));
            Dropdownteam.SelectByValue(TeamPlayer);
            System.Threading.Thread.Sleep(2000);

            string PositionPlayer = "G";
            SelectElement DropdownPost = new SelectElement(driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/main/div[2]/section/div/div[2]/div[1]/div[3]/label/div/select")));
            DropdownPost.SelectByValue(PositionPlayer);
            System.Threading.Thread.Sleep(2000);

            string CollegesPlayer = "Anadolu Efes";
            SelectElement DropdownCol = new SelectElement(driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/main/div[2]/section/div/div[2]/div[1]/div[4]/label/div/select")));
            DropdownCol.SelectByValue(CollegesPlayer);
            System.Threading.Thread.Sleep(2000);

            string CountryPlayer = "Turkey";
            SelectElement DropdownCount = new SelectElement(driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[2]/main/div[2]/section/div/div[2]/div[1]/div[5]/label/div/select")));
            DropdownCount.SelectByValue(CountryPlayer);
            System.Threading.Thread.Sleep(2000);

            driver.FindElement(Switch_show).Click();
            System.Threading.Thread.Sleep(1000);

        }

        public void SearchPlayer(string name)
        {
            driver.FindElement(Search_Player).SendKeys(name);

        }
        public void EnterSearch()
        {
            PlayerTab playertab = new PlayerTab(driver);
            playertab.SearchPlayer("Furkan Korkmaz");

        }
        public void SelectPlayer()
        {
            driver.FindElement(Select_Player).Click();

        }

    }
    
    class Test2_PlayerTab
    {
        static void Main(string[] args)
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.nba.com/");
            driver.Manage().Window.Maximize();

            var PlayerTab = new PlayerTab(driver);
            System.Threading.Thread.Sleep(1000);

            PlayerTab.AcceptCookiesP();
            System.Threading.Thread.Sleep(2000);

            PlayerTab.SelectButtonPLayer();
            System.Threading.Thread.Sleep(2000);

            PlayerTab.SelectDropdownPLayer();
            System.Threading.Thread.Sleep(2000);

            PlayerTab.EnterSearch();
            System.Threading.Thread.Sleep(2000);

            PlayerTab.SelectPlayer();
            System.Threading.Thread.Sleep(4000);

            driver.Quit();

        }
    }
}
