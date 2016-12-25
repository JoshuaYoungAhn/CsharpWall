using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Wall
{
    class Program
    {
        static void Main()
        {
            
            
            
            IWebHost host = new WebHostBuilder()
                .UseIISIntegration()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

            host.Run();
           
        }
    }
}
