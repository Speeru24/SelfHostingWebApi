using System;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace SelfHostingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOTE: Run Visual Studio as Administrator
            
            var config = new HttpSelfHostConfiguration("http://localhost:8080");

            config.Routes.MapHttpRoute(
                name:"API Default", 
                routeTemplate:"api/{controller}/{id}",
                defaults:null);

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                //Setting Formatters
                var formatters = server.Configuration.Formatters;

                // Return Json Data
                formatters.Add(formatters.JsonFormatter);
                formatters.Remove(formatters.XmlFormatter);

                // Return XML Data
                //formatters.Remove(formatters.JsonFormatter);
                //formatters.Add(formatters.XmlFormatter);

                server.OpenAsync().Wait();
                Console.WriteLine("Api application is  Up and Running at http://localhost:8080");

                Console.WriteLine("Press Enter to quit.");
                Console.ReadLine();
            }
        }
    }
}
