using MarkdownSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace steelcm.Helpers
{
    public static class RenderMarkdownHelper
    {
        public static Markdown markdownTransformer = new Markdown();

        public static MvcHtmlString RenderMarkdown(this HtmlHelper helper, string markdownViewName)
        {
            string absFileName = helper.ViewContext.HttpContext.Server.MapPath(markdownViewName);
            string markdown = System.IO.File.ReadAllText(absFileName);
            string html = markdownTransformer.Transform(markdown);
            return new MvcHtmlString(html);
        }
    }
}