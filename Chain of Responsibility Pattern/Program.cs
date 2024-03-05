using System.Security.Cryptography.X509Certificates;

namespace Chain_of_Responsibility_Pattern
{
    internal class Program
    {
        /*
            i guess the middlewares in asp.net core web api/mvc depend on this pattern 
            am gonna imitate that in this example
        */
        static void Main(string[] args)
        {
            MiddleWare authentication = new Authentication();
            MiddleWare authorization = new Authorization();
            MiddleWare webApp = new WebApp();
            authentication.SetNext(authorization);
            authorization.SetNext(webApp);
            webApp.SetNext(null);

            var request = new Request { IsAuthenticated = true, IsAuthorized = false};

            authentication.Handle(request);

        }
    }
}
