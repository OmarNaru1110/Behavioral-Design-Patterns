using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor_Pattern
{
    //why an interface though we have one class? cuz u may have different type of exportation
    //like pdf,etc..
    internal class XMLExportation : Exportation
    {
        public void ExportForCity(City city)
        {
            Console.WriteLine("Exporting City");
        }

        public void ExportForCompany(Company company)
        {
            Console.WriteLine("Exporting Company");
        }

        public void ExportForStore(Store store)
        {
            Console.WriteLine("Exporting Store");
        }
    }
}
