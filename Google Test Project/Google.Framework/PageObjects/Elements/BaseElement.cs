﻿using Google.Framework.Tools;

namespace Google.Framework.PageObjects.Elements
{
    public class BaseElement
    {
        protected SeleniumWrapper Wrapper;

        public BaseElement(IWebDriverManager manager)
        {
            Wrapper = new SeleniumWrapper(manager.GetDriver(), manager.GetWaiter());
        }
    }
}   