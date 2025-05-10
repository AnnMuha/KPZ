using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Core
{
    public class Document
    {
        public string Text { get; private set; } = "";

        public void AddText(string newText)
        {
            Text += newText;
        }

        public void Overwrite(string newText)
        {
            Text = newText;
        }
    }
}
