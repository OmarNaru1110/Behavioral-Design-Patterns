using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class Notification
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public override string ToString()
        {
            return $"{Date}\n {Message}";
        }
    }
}
