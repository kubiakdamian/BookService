using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // UWAGA: możesz użyć polecenia „Zmień nazwę” w menu „Refaktoryzuj”, aby zmienić nazwę interfejsu „IServiceDemo” w kodzie i pliku konfiguracji.
    [ServiceContract]
    public interface IServiceDemo
    {
        [OperationContract]
        string HelloWorld();

        [OperationContract]
        string Hi(string name);

        [OperationContract]
        int Sum(int a, int b);
    }
}
