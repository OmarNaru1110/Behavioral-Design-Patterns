using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    internal class CareTaker
    {
        private Editor _editor;
        private Stack<Memento> _history;
        public CareTaker(Editor editor)
        {
            _editor = editor;
            _history = new Stack<Memento>();
            _history.Push(_editor.Save());
        }
        public void Backup()
        {
            _history.Push(_editor.Save());

        }
        public void Undo()
        {
            if (_history.Count == 0)
                return;
            var memento = _history.Pop();
            _editor.Restore(memento);
        }
        public void GetCurrentState()
        {
            foreach (var ch in _history.Peek().ToString())
            {
                Console.Write(ch);
                Thread.Sleep(100);
            }
            Console.WriteLine();
        }
        public void ShowHistory()
        {
            foreach (var memento in _history)
            {
                Console.WriteLine(memento.ToString());
            }
        }
    }
}
