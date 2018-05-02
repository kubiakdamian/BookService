using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceDemoReference;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceDemoClient serviceDemoClient = new ServiceDemoClient();
            Console.WriteLine(serviceDemoClient.HelloWorld());
            Console.ReadLine();

        }
    }
}
