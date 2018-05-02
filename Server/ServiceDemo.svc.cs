using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę klasy „ServiceDemo” w kodzie, usłudze i pliku konfiguracji.
    // UWAGA: aby uruchomić klienta testowego WCF w celu przetestowania tej usługi, wybierz plik ServiceDemo.svc lub ServiceDemo.svc.cs w eksploratorze rozwiązań i rozpocznij debugowanie.
    public class ServiceDemo : IServiceDemo
    {
        public string HelloWorld()
        {
            return "Hello world!";
        }

        public string Hi(string name)
        {
            return "Hi " + name;
        }

        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
