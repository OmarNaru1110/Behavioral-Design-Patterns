using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    internal class City : Node
    {
        public void Accept(Exportation exportation)
        {
            exportation.ExportForCity(this);
        }

        public override string ToString()
        {
            return "City";
        }
    }
}
