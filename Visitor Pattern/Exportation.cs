using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    //representing the visitor
    internal interface Exportation
    {
        void ExportForCity(City city);
        void ExportForCompany(Company company);
        void ExportForStore(Store store);
    }
}
