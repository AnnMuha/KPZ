using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.LightHTML.Strategy;

namespace Task5.LightHTML
{
    public class ImageElement : LightElement
    {
        private readonly string _href;
        private readonly IImageLoadingStrategy _strategy;

        public ImageElement(string href, IImageLoadingStrategy strategy)
            : base("img", "inline", true)
        {
            _href = href;
            _strategy = strategy;
        }

        public override string RenderOuterHTML()
        {
            var sb = new StringBuilder();
            sb.Append($"<img src=\"{_href}\" alt=\"image\" title=\"{_strategy.LoadImage(_href)}\"");

            if (CssClasses.Count > 0)
                sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");

            sb.Append(" />");
            return sb.ToString();
        }

        public override string RenderInnerHTML() => "";
    }
}
