using System.Web.Mvc;

namespace Fsd.Cs.Web.Extensions
{
    public static class KamilExtensions
    {
        public static string AddNamePrefix(this string value)
        {
            return $"Kamil: {value}";
        }

        public static MvcHtmlString ShowHelloWorld(this HtmlHelper helper, string name)
        {
            return new MvcHtmlString($"<h1>Hello world: {name}</h1>");
        }

        public static MvcHtmlString Submit(this HtmlHelper helper, string text)
        {
            return new MvcHtmlString($"<input type=\"submit\" value=\"{text}\" />");
        }
    }
}