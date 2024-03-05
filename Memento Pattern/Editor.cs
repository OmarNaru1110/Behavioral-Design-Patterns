using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    internal class Editor
    {
        private string _text;//state
        public Editor(string text)
        {
            _text = text;
        }
        public Memento Save()
        {
            return new Memento(_text);
        }
        public void Restore(Memento memento)
        {
            _text = memento.GetText();
        }
        public void AppendText(string text)
        {
            _text += text;
        }
    }
}
