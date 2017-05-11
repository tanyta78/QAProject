namespace ProjectTests.Pages.RegisterPage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using OpenQA.Selenium;
    using ProjectTests.Models;

    public partial class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver driver) : base(driver)
        {
        }

        public String Url
        {
            get
            {
                return base.URL + "Account/Register/";
            }

        }


        public void NavigateTo()
        {
            this.Driver.Navigate().GoToUrl(this.Url);
            this.Driver.Manage().Window.Maximize();
        }

        public void FillRegistrationForm(RegistrationUserModel user)
        {
            Type(this.FullName, user.FullName);
            Type(this.Email, user.Email);
            Type(this.Password, user.Password);
            Type(this.ConfirmPassword, user.ConfirmPassword);
            this.RegisterButton.Click();


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
