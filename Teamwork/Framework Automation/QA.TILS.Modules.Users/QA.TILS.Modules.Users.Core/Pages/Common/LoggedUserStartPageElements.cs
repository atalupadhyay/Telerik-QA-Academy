﻿namespace QA.TILS.Modules.Users.Core.Pages.Common
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using QA.Framework.Core.Base;
    using QA.Framework.Core.Extensions;

    public class LoggedUserStartPageElements : BaseElementsMap
    {
        public HtmlAnchor UnacceptedInvitationsLink
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>("//*[@id='ImportantMessages']/div/a[@href='/Friends']");
            }
        }

        public HtmlAnchor NewMessagesLink
        {
            get
            {
                return this.Find.ByXPath<HtmlAnchor>("//*[@id='ImportantMessages']/div/a[@href='/Messages']");
            }
        }
    }
}
