using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    //snapshot
    internal class Memento
    {
        private readonly string _text;

        public Memento(string state)
        {
            _text = state;
        }
        public string GetText() => _text; //getState
        public override string ToString()
        {
            return $"{_text}\n";
        }
    }
}
