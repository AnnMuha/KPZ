using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Memento
{
    public class DocumentSnapshot : IDocumentSnapshot
    {
        private readonly string _savedText;

        public DocumentSnapshot(string text)
        {
            _savedText = text;
        }

        public string GetSavedText()
        {
            return _savedText;
        }
    }
}
