using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebMVC_Views.Helpers
{
    public static class CustomHelper
    {
        public static MvcHtmlString GetHtml(this HtmlHelper html, IEnumerable<string> list)
        {
            TagBuilder tag = new TagBuilder("ul");
            TagBuilder itemTag;

            foreach (string item in list)
            {
                itemTag = new TagBuilder("li");
                itemTag.SetInnerText(item);
                tag.InnerHtml += itemTag.ToString();
            }

            return new MvcHtmlString(tag.ToString());
        }
    }
}