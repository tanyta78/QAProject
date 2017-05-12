namespace NewTestProject.Pages.LoginPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using NewTestProject.Models;

    public partial class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public String Url
        {
            get
            {
                return base.Url + "Account/Login/";
            }

        }

        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.Url);
            this.Driver.Manage().Window.Maximize();
        }

        public void FillLoginForm(RegistrationUserModel user)
        {
            
            Type(this.Email, user.Email);
            Type(this.Password, user.Password);
           
            this.LoginButton.Click();


        }


        private void Type(IWebElement element, string text)
        {
            if (text == null)
            {
                element.Clear();
            }
            else
            {
                element.Clear();
                element.SendKeys(text);
            }

        }
    }
}
