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
    public class TeamTab
    {
        IWebDriver driver;
        By Team_button_header = By.XPath("//*[@id=\"nav-ul\"]/li[9]/a");
        By Conf_Accept_Co = By.Id("onetrust-accept-btn-handler");
        By Select_Team = By.XPath("//*[@id=\"__next\"]/div[2]/div[2]/div[2]/section/div/div[2]/div[1]/div[2]/div[1]/div/a");
        By Select_Schedule = By.XPath("/html/body/div[1]/header/div[3]/div[2]/div[2]/div[2]/div/a");
        By Conf_Filter_Cat = By.XPath("/html/body/div[1]/div[2]/section/section[1]/section[1]/div/div[1]/div[1]/div[3]/label[1]");
        By Conf_Filter_Loc = By.XPath("/html/body/div[1]/div[2]/section/section[1]/section[1]/div/div[1]/div[2]/div[2]/label[1]");
        By Conf_Filter_Op = By.XPath("/html/body/div[1]/div[2]/section/section[1]/section[1]/div/div[1]/div[4]/div[3]/label[2]");
        By Conf_Filter_Season = By.XPath("//*[@id=\"__next\"]/div[2]/section/section[1]/section[1]/div/div[1]/div[5]/div[2]/label[2]/input");
        By Conf_Filter_Month = By.XPath("/html/body/div[1]/div[2]/section/section[1]/section[1]/div/div[1]/div[6]/div[3]/label[3]");
        By Conf_Filter_Broad = By.XPath("/html/body/div[1]/div[2]/section/section[1]/section[1]/div/div[1]/div[7]/div[2]/label[6]");


        public TeamTab(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void SelectButtonHeader()
        {
            driver.FindElement(Team_button_header).Click();
        }

        public void AcceptCookies()
        {
            driver.FindElement(Conf_Accept_Co).Click();
        }

        public void SelectTeamB()
        {
            driver.FindElement(Select_Team).Click();
        }

        public void SelectCal()
        {
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(Select_Schedule).Click();
        }

        public void Configure_Filter()
        {
            driver.FindElement(Conf_Filter_Cat).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(Conf_Filter_Loc).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(Conf_Filter_Op).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(Conf_Filter_Season).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(Conf_Filter_Month).Click();
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(Conf_Filter_Broad).Click();
        }
    }

    class Test1_TeamTab
    {
        static void Main(string[] args)
        {
 
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.nba.com/");
            driver.Manage().Window.Maximize();

            var TeamTab = new TeamTab(driver);
            System.Threading.Thread.Sleep(1000);


            TeamTab.AcceptCookies();
            System.Threading.Thread.Sleep(2000);

            TeamTab.SelectButtonHeader();
            System.Threading.Thread.Sleep(2000);


            TeamTab.SelectTeamB();
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            System.Threading.Thread.Sleep(4000);

            TeamTab.SelectCal();
            System.Threading.Thread.Sleep(3000);

            TeamTab.Configure_Filter();
            System.Threading.Thread.Sleep(3000);

            driver.Quit();
        }
    }
}