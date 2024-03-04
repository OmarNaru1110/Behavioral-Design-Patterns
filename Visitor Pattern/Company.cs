using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    internal class Company : Node
    {
        public void Accept(Exportation exportation)
        {
            exportation.ExportForCompany(this);
        }

        public override string ToString()
        {
            return "Company";
        }
    }
}
