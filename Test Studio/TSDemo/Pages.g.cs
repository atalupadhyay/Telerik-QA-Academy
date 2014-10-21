//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TSDemo
{
    using ArtOfTest.WebAii.Core;
    using ArtOfTest.WebAii.ObjectModel;
    using ArtOfTest.WebAii.TestAttributes;
    using ArtOfTest.WebAii.TestTemplates;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    
    public class Pages
    {
        private Manager _manager;
        public Pages(Manager manager)
        {
            _manager = manager;
        }
        /// <summary>
        /// Page : https://www.google.bg/?gfe_rd=cr&ei=fAwsVOn2Auvc8gfG0YC4Cg&gws_rd=ssl 
        /// </summary>
        public GooglePage Google
        {
            get
            {
                return new GooglePage("https://www.google.bg/?gfe_rd=cr&ei=fAwsVOn2Auvc8gfG0YC4Cg&gws_rd=ssl", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : https://www.google.bg/?gfe_rd=cr&ei=fAwsVOn2Auvc8gfG0YC4Cg&gws_rd=ssl#q=qa+training 
        /// </summary>
        public QaTrainingGoogleSearchPage QaTrainingGoogleSearch
        {
            get
            {
                return new QaTrainingGoogleSearchPage("https://www.google.bg/?gfe_rd=cr&ei=fAwsVOn2Auvc8gfG0YC4Cg&gws_rd=ssl#q=qa+traini" +
                        "ng", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://www.bing.com/ 
        /// </summary>
        public BingPage Bing
        {
            get
            {
                return new BingPage("http://www.bing.com/", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://www.store.bg/search?srchstr=javascript&p=s&=%D2%FA%F0%F1%E8+%E2%FA%E2+%E2%F1%E8%F7%EA%E8+%F0%E0%E7%E4%E5%EB%E8&sin=0 
        /// </summary>
        public StoreBgJavascriptPage StoreBgJavascript
        {
            get
            {
                return new StoreBgJavascriptPage("http://www.store.bg/search?srchstr=javascript&p=s&=%D2%FA%F0%F1%E8+%E2%FA%E2+%E2%" +
                        "F1%E8%F7%EA%E8+%F0%E0%E7%E4%E5%EB%E8&sin=0", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://test.telerikacademy.com/ 
        /// </summary>
        public TILSLoggedUserPagePage TILSLoggedUserPage
        {
            get
            {
                return new TILSLoggedUserPagePage("http://test.telerikacademy.com/", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://test.telerikacademy.com/Users/Auth/Login 
        /// </summary>
        public TILSLoginPagePage TILSLoginPage
        {
            get
            {
                return new TILSLoginPagePage("http://test.telerikacademy.com/Users/Auth/Login", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://localhost:36240/WebUI/Pages/Start/Start.html?recorder=36239 
        /// </summary>
        public TestStudioRecorderStartPage TestStudioRecorderStart
        {
            get
            {
                return new TestStudioRecorderStartPage("http://localhost:36240/WebUI/Pages/Start/Start.html?recorder=36239", _manager.ActiveBrowser.Find);
            }
        }
        public class GooglePage : HtmlPage
        {
            public GooglePage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' gbqfq] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText SearchField
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=gbqfq", "tagname=input");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression SearchField = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=gbqfq", "tagname=input");
            }
        }
        public class QaTrainingGoogleSearchPage : HtmlPage
        {
            public QaTrainingGoogleSearchPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' span] AND [TextContent 'StartsWith' are the UK's la]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan AreTheUKSSpan
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("TextContent=^are the UK\'s la", "tagname=span");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' $(Col1)] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText GbqfqText
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("tagname=input", "id=$(Col1)");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression AreTheUKSSpan = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^are the UK\'s la", "tagname=span");
                public ArtOfTest.WebAii.Core.HtmlFindExpression GbqfqText = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=input", "id=$(Col1)");
            }
        }
        public class BingPage : HtmlPage
        {
            public BingPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' sb_form_q] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSearch BingSearchField
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSearch>("id=sb_form_q", "tagname=input");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression BingSearchField = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=sb_form_q", "tagname=input");
            }
        }
        public class StoreBgJavascriptPage : HtmlPage
        {
            public StoreBgJavascriptPage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [TagIndex 'Exact' input:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText SeachField
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("TagIndex=input:0");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression SeachField = new ArtOfTest.WebAii.Core.HtmlFindExpression("TagIndex=input:0");
            }
        }
        public class TILSLoggedUserPagePage : HtmlPage
        {
            public TILSLoggedUserPagePage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' ExitMI] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor LogoutLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=ExitMI", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' LoginButton] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor LoginButtonLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=LoginButton", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' MessagesMI] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor MessagesLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=MessagesMI", "tagname=a");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression LogoutLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=ExitMI", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LoginButtonLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=LoginButton", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression MessagesLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=MessagesMI", "tagname=a");
            }
        }
        public class TILSLoginPagePage : HtmlPage
        {
            public TILSLoginPagePage(string url, Find find) : 
                    base(url, find)
            {
            }
            /// <summary>
            /// Find expressions for this page
            /// </summary>
            public ExpressionDefinitions Expressions
            {
                get
                {
                    return new ExpressionDefinitions();
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' UsernameOrEmail] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText UsernameField
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputText>("id=UsernameOrEmail", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' Password] AND [tagname 'Exact' input]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword PasswordField
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputPassword>("id=Password", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' input] AND [value 'Exact' Вход]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit LoginButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit>("value=Вход", "tagname=input");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression UsernameField = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=UsernameOrEmail", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression PasswordField = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=Password", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LoginButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("value=Вход", "tagname=input");
            }
        }
        public class TestStudioRecorderStartPage : HtmlPage
        {
            public TestStudioRecorderStartPage(string url, Find find) : 
                    base(url, find)
            {
            }
        }
    }
    public class Applications
    {
        private Manager _manager;
        public Applications(Manager manager)
        {
            _manager = manager;
        }
    }
}
