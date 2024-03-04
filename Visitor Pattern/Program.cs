namespace Visitor_Pattern
{
    internal class Program
    {
        /*
         that's visitor pattern, 
         i'll implement it but am a little bit not releived with it 
        cuz in this article https://refactoring.guru/design-patterns/visitor
        he said that you have to export each node, but without modifying the classes
        cuz if u did u first breached open/closed principle
        second: u added more complexity (export) to classes that 
        don't have anything to do with exporting which means u breached single responsibility principle
        and if you for example tried to do the solution by adding export method to each class
        let's say u have multiple classes that share the same export() implementation, what are u gonna do?
        
        but literally in his solution which is implementing visitor pattern he breached all that by 
        adding accept(Visitor v) not only that, but it's literally more complex than the way
        we were going to do which is making a class that deals with exporting let's call XMLExport
        and we have all type of methods we need for exporting like ExportForCity()
        ExportForCompany(), ExportForStore(), etc...

        and we add a method called Export() inside the interface Node
        and in each concrete class's method we do the following:
        Export(){
            var xml = new XMLExport();
            xml.ExportForConcreteClass();
        }
        yeah we have breached OCP and SRP but it's easier than the solution he provided using Visitor pattern
        anyway, let's dive into the code
         */
        static void Main(string[] args)
        {
            var Nodes = new List<Node> { new City(), new City(),new Store(),new Company() };
            var exportation = new XMLExportation();
            foreach (var node in Nodes)
            {
                node.Accept(exportation);
                Thread.Sleep(500);
            }
        }
    }
}
