//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExamPart1TestStudio
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
        /// Page : http://demos.telerik.com/kendo-ui/grid/editing-inline 
        /// </summary>
        public ApplyingInlineEditingInPage ApplyingInlineEditingIn
        {
            get
            {
                return new ApplyingInlineEditingInPage("http://demos.telerik.com/kendo-ui/grid/editing-inline", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://demos.telerik.com/kendo-ui/ 
        /// </summary>
        public KendoUIDemosPage KendoUIDemos
        {
            get
            {
                return new KendoUIDemosPage("http://demos.telerik.com/kendo-ui/", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://demos.telerik.com/kendo-ui/grid/index 
        /// </summary>
        public KendoUIGridDemoPage KendoUIGridDemo
        {
            get
            {
                return new KendoUIGridDemoPage("http://demos.telerik.com/kendo-ui/grid/index", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://test.telerikacademy.com/ 
        /// </summary>
        public TestTILSMainPagePage TestTILSMainPage
        {
            get
            {
                return new TestTILSMainPagePage("http://test.telerikacademy.com/", _manager.ActiveBrowser.Find);
            }
        }
        /// <summary>
        /// Page : http://test.telerikacademy.com/Users/Auth/Login 
        /// </summary>
        public TestTILSLoginPagePage TestTILSLoginPage
        {
            get
            {
                return new TestTILSLoginPagePage("http://test.telerikacademy.com/Users/Auth/Login", _manager.ActiveBrowser.Find);
            }
        }
        public class ApplyingInlineEditingInPage : HtmlPage
        {
            public ApplyingInlineEditingInPage(string url, Find find) : 
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
            /// (Html): [XPath 'Exact' $(XPath)]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell RowElement
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlTableCell>("XPath=$(XPath)");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' grid] AND [tagname 'Exact' div]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv KendoUIGrid
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("id=grid", "tagname=div");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' a] AND [TextContent 'Exact' Add new record]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor AddNewRecordButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("TextContent=Add new record", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' grid][tagIndex 'Exact' a:1]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor EditButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=grid", "|", "tagIndex=a:1");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' grid][tagIndex 'Exact' a:2]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor DeleteButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=grid", "|", "tagIndex=a:2");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' grid][tagIndex 'Exact' div:4]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv GridPagerContainer
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlDiv>("id=grid", "|", "tagIndex=div:4");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-grid] AND [class 'Contains' k-widget] AND [GroupIndex 'Exact' 0]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.KendoUI.KendoGrid GridPage
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.KendoUI.KendoGrid>("class=~k-widget", "class=~k-grid", "GroupIndex=0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [class 'Contains' k-pager-wrap] AND [class 'Contains' k-widget] AND [GroupIndex 'Exact' 0]
            ///
            /// </summary>
            public Telerik.TestingFramework.Controls.KendoUI.KendoPager GridPagerControl
            {
                get
                {
                    return Get<Telerik.TestingFramework.Controls.KendoUI.KendoPager>("class=~k-widget", "class=~k-pager-wrap", "GroupIndex=0");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' span] AND [TextContent 'StartsWith' Go to the last ]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan GridPagerGoToLastPageButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlSpan>("TextContent=^Go to the last ", "tagname=span");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression RowElement = new ArtOfTest.WebAii.Core.HtmlFindExpression("XPath=$(XPath)");
                public ArtOfTest.WebAii.Core.HtmlFindExpression KendoUIGrid = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=grid", "tagname=div");
                public ArtOfTest.WebAii.Core.HtmlFindExpression AddNewRecordButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=Add new record", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression EditButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=grid", "|", "tagIndex=a:1");
                public ArtOfTest.WebAii.Core.HtmlFindExpression DeleteButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=grid", "|", "tagIndex=a:2");
                public ArtOfTest.WebAii.Core.HtmlFindExpression GridPagerContainer = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=grid", "|", "tagIndex=div:4");
                public ArtOfTest.WebAii.Core.HtmlFindExpression GridPage = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-widget", "class=~k-grid", "GroupIndex=0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression GridPagerControl = new ArtOfTest.WebAii.Core.HtmlFindExpression("class=~k-widget", "class=~k-pager-wrap", "GroupIndex=0");
                public ArtOfTest.WebAii.Core.HtmlFindExpression GridPagerGoToLastPageButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^Go to the last ", "tagname=span");
            }
        }
        public class KendoUIDemosPage : HtmlPage
        {
            public KendoUIDemosPage(string url, Find find) : 
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
            /// (Html): [id 'Exact' widgets-all][tagIndex 'Exact' a:0]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor GridDemoLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=widgets-all", "|", "tagIndex=a:0");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression GridDemoLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=widgets-all", "|", "tagIndex=a:0");
            }
        }
        public class KendoUIGridDemoPage : HtmlPage
        {
            public KendoUIGridDemoPage(string url, Find find) : 
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
            /// (Html): [href 'Exact' /kendo-ui/grid/editing-inline] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor InlineEditingLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("href=/kendo-ui/grid/editing-inline", "tagname=a");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression InlineEditingLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("href=/kendo-ui/grid/editing-inline", "tagname=a");
            }
        }
        public class TestTILSMainPagePage : HtmlPage
        {
            public TestTILSMainPagePage(string url, Find find) : 
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
            /// (Html): [id 'Exact' LoginButton] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor LoginButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlAnchor>("id=LoginButton", "tagname=a");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' span] AND [TextContent 'Exact' $(Username)]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl CurrentUserProfileLink
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("tagname=span", "TextContent=$(Username)");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [id 'Exact' ExitMI] AND [tagname 'Exact' a]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl LogoutButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("tagname=a", "id=ExitMI");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression LoginButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=LoginButton", "tagname=a");
                public ArtOfTest.WebAii.Core.HtmlFindExpression CurrentUserProfileLink = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=span", "TextContent=$(Username)");
                public ArtOfTest.WebAii.Core.HtmlFindExpression LogoutButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("tagname=a", "id=ExitMI");
            }
        }
        public class TestTILSLoginPagePage : HtmlPage
        {
            public TestTILSLoginPagePage(string url, Find find) : 
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
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit SubmitButton
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlInputSubmit>("value=Вход", "tagname=input");
                }
            }
            /// <summary>
            /// Find logic 
            /// (Html): [tagname 'Exact' li] AND [TextContent 'StartsWith' Невалидни данни]
            ///
            /// </summary>
            public ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl InvalidCredentialsMessage
            {
                get
                {
                    return Get<ArtOfTest.WebAii.Controls.HtmlControls.HtmlControl>("TextContent=^Невалидни данни", "tagname=li");
                }
            }
            public class ExpressionDefinitions
            {
                public ArtOfTest.WebAii.Core.HtmlFindExpression UsernameField = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=UsernameOrEmail", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression PasswordField = new ArtOfTest.WebAii.Core.HtmlFindExpression("id=Password", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression SubmitButton = new ArtOfTest.WebAii.Core.HtmlFindExpression("value=Вход", "tagname=input");
                public ArtOfTest.WebAii.Core.HtmlFindExpression InvalidCredentialsMessage = new ArtOfTest.WebAii.Core.HtmlFindExpression("TextContent=^Невалидни данни", "tagname=li");
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
