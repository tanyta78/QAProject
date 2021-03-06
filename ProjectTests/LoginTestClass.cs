﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using ProjectTests.Models;
using ProjectTests.Pages.LoginPage;
using ProjectTests.Pages.RegisterPage;

namespace ProjectTests
{
    [TestFixture]
    public class LoginTestClass
    {
        public IWebDriver driver;
        [SetUp]

        public void Initialized()
        {
            this.driver = BrowserHost.Instance.Application.Browser;
        }

        [TearDown]
        public void LogsandScreenshot()
        {
            // Don't close the driver because of TeamCity  
            //driver.Close();

        }

        [Test, Property("Priority", 2)]
        [Author("Tatyana Milanova")]
        public void NavigateToLoginPage()
        {
            LoginPage LogInPage = new LoginPage(driver);
            LogInPage.NavigateTo();
            Assert.IsTrue(LogInPage.LoginButton.Displayed);
        }

        [Test, Property("Priority", 2)]
        [Author("Nataliya Zh")]
        public void RegisterInvalidEmail()
        {
            RegisterPage RegPage = new RegisterPage(this.driver);
            RegPage.NavigateTo();
            var userex = AccessExcelData.GetTestData("InvalidEmail");
            RegPage.FillRegistrationForm(userex);
          //  RegPage.AssertErrorMessage("The Email field is not a valid e-mail address.");

        }

       
    }
}
