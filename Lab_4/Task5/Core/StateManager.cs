using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.Memento;

namespace Task5.Core
{
    public class StateManager
    {
        private readonly List<IDocumentSnapshot> _history = new List<IDocumentSnapshot>();
        private readonly Editor _editor;

        public StateManager(Editor editor)
        {
            _editor = editor;
        }

        public void SaveState()
        {
            _history.Add(_editor.GetSnapshot());
        }

        public void RestoreLastState()
        {
            if (_history.Count == 0) return;

            var last = _history[_history.Count - 1];
            _history.RemoveAt(_history.Count - 1);
            _editor.RestoreSnapshot(last);
        }
    }
}
