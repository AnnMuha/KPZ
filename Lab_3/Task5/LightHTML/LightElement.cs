using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.LightHTML.Events;

namespace Task5.LightHTML
{
    public class LightElement : LightNode
    {
        public string Tag { get; }
        public bool SelfClosing { get; }
        public string Display { get; }
        public List<string> CssClasses { get; } = new List<string>();
        public List<LightNode> Children { get; } = new List<LightNode>();

        private readonly Dictionary<string, List<IEventListener>> _listeners = new Dictionary<string, List<IEventListener>>();

        public LightElement(string tag, string display, bool selfClosing)
        {
            Tag = tag;
            Display = display;
            SelfClosing = selfClosing;
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public void AddChild(LightNode node)
        {
            if (!SelfClosing)
                Children.Add(node);
        }

        public void AddEventListener(string eventType, IEventListener listener)
        {
            if (!_listeners.ContainsKey(eventType))
                _listeners[eventType] = new List<IEventListener>();

            _listeners[eventType].Add(listener);
        }

        public void DispatchEvent(string eventType)
        {
            if (_listeners.TryGetValue(eventType, out var eventListeners))
            {
                foreach (var listener in eventListeners)
                {
                    listener.HandleEvent(eventType, this);
                }
            }
        }

        public override string RenderOuterHTML()
        {
            var sb = new StringBuilder();
            sb.Append($"<{Tag}");

            if (CssClasses.Count > 0)
                sb.Append($" class=\"{string.Join(" ", CssClasses)}\"");

            if (SelfClosing)
            {
                sb.Append(" />");
                return sb.ToString();
            }

            sb.Append(">");
            sb.Append(RenderInnerHTML());
            sb.Append($"</{Tag}>");
            return sb.ToString();
        }

        public override string RenderInnerHTML()
        {
            var inner = new StringBuilder();

            foreach (var child in Children)
                inner.Append(child.RenderOuterHTML());

            return inner.ToString();
        }
    }
}
