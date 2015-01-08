using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(SearchService.TextSearch));
            host.Opened += host_Opened;
            host.Open();

            Console.ReadLine();
            
        }

        static void host_Opened(object sender, EventArgs e)
        {
            Console.WriteLine("started...");
        }
    }
}
