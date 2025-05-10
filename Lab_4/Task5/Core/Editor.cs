using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Memento;

namespace Task5.Core
{
    public class Editor
    {
        private readonly Document _doc = new Document();
        private readonly StateManager _manager;

        public Editor()
        {
            _manager = new StateManager(this);
        }

        public void Type(string text)
        {
            _doc.AddText(text);
        }

        public void Save()
        {
            _manager.SaveState();
        }

        public void Undo()
        {
            _manager.RestoreLastState();
        }

        public string GetContent()
        {
            return _doc.Text;
        }

        public IDocumentSnapshot GetSnapshot()
        {
            return new DocumentSnapshot(_doc.Text);
        }

        public void RestoreSnapshot(IDocumentSnapshot snapshot)
        {
            _doc.Overwrite(snapshot.GetSavedText());
        }
    }
}
