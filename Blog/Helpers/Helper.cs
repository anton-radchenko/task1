using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Helpers
{
    public static class Helper
    {
        public static MvcHtmlString ListArrayStringItems(this HtmlHelper html, string[] list, string type, string name)
        {
            TagBuilder tag = new TagBuilder("ul");
            foreach (string str in list)
            {
                TagBuilder listItemTag = new TagBuilder("li");
                TagBuilder inputItemTag = new TagBuilder("input");
                TagBuilder spanItemTag = new TagBuilder("span");
                spanItemTag.SetInnerText(str);
                inputItemTag.MergeAttribute("name", name);
                inputItemTag.MergeAttribute("type", type);
                inputItemTag.MergeAttribute("value", str);
                listItemTag.AddCssClass("marker");
                listItemTag.InnerHtml += inputItemTag.ToString();
                listItemTag.InnerHtml += spanItemTag.ToString();



                tag.InnerHtml += listItemTag.ToString();
            }

            return new MvcHtmlString(tag.ToString());
        }
    }
}