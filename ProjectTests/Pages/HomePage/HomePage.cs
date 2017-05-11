using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace ProjectTests.Pages.HomePage
{
   public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public String Url
        {
            get
            {
                return base.URL + "Article/List/";
            }

        }


        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.Url);
            this.Driver.Manage().Window.Maximize();
        }
    }
}
