using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento_Pattern
{
    //this pattern is used when u want to add UNDO feature and the state of your model is private
    //take a look at this https://dotnettutorials.net/lesson/memento-design-pattern/
    //and this https://refactoring.guru/design-patterns/memento
    //srry about not explaining but am tired :(
    internal static class program
    {
        public static void Main()
        {
            //it's like checkpoints in games
            Editor editor = new Editor("hello");
            CareTaker careTaker = new(editor);
            careTaker.Backup();
            careTaker.GetCurrentState();
            editor.AppendText(" naru");
            careTaker.Backup();
            careTaker.GetCurrentState();
            careTaker.Undo();
            careTaker.GetCurrentState();
        }
    }
}
