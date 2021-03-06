﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QA.TelerikAcademy.Core.Pages;
using ArtOfTest.WebAii.Core;
using QA.UI.TestingFramework.Core;
using QA.TelerikAcademy.Core.Base;
using QA.UI.TestingFramework.Core.Contracts;
using QA.UI.TestingFramework.Core.Data;

namespace QA.TelerikAcademy.Core.Pages.LoginPage
{
    public class LoginPage : ILogin
    {
        public const string LoginUrl = @"https://telerikacademy.com/Users/Auth/Login";     

        public LoginPageMap Map
        {
            get
            {
                return new LoginPageMap();
            }
        }

        public UpperNavigationSectionMap NavigationMap
        {
            get
            {
                return new UpperNavigationSectionMap();
            }
        }

        public LoginPageValidator Validator
        {
            get
            {
                return new LoginPageValidator();
            }
        }

        public void WaitForUserName()
        {
            Manager.Current.ActiveBrowser.WaitForExists(this.NavigationMap.UserNameExpression);
        }

        public void TypeEmail(string email)
        {
            this.Map.UserName.Text = email;
        }

        public void TypePassword(string password)
        {
            this.Map.Password.Text = password;
        }

        public void Submit()
        {
            this.Map.Submit.Click();
        }

        public void Logout()
        {
            this.NavigationMap.Logout.Click();
        }

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(LoginUrl);
        }
    }
}
