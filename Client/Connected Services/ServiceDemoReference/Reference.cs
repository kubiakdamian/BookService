﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.ServiceDemoReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceDemoReference.IServiceDemo")]
    public interface IServiceDemo {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDemo/HelloWorld", ReplyAction="http://tempuri.org/IServiceDemo/HelloWorldResponse")]
        string HelloWorld();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDemo/HelloWorld", ReplyAction="http://tempuri.org/IServiceDemo/HelloWorldResponse")]
        System.Threading.Tasks.Task<string> HelloWorldAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDemo/Hi", ReplyAction="http://tempuri.org/IServiceDemo/HiResponse")]
        string Hi(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDemo/Hi", ReplyAction="http://tempuri.org/IServiceDemo/HiResponse")]
        System.Threading.Tasks.Task<string> HiAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDemo/Sum", ReplyAction="http://tempuri.org/IServiceDemo/SumResponse")]
        int Sum(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceDemo/Sum", ReplyAction="http://tempuri.org/IServiceDemo/SumResponse")]
        System.Threading.Tasks.Task<int> SumAsync(int a, int b);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceDemoChannel : Client.ServiceDemoReference.IServiceDemo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceDemoClient : System.ServiceModel.ClientBase<Client.ServiceDemoReference.IServiceDemo>, Client.ServiceDemoReference.IServiceDemo {
        
        public ServiceDemoClient() {
        }
        
        public ServiceDemoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceDemoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDemoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceDemoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld() {
            return base.Channel.HelloWorld();
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync() {
            return base.Channel.HelloWorldAsync();
        }
        
        public string Hi(string name) {
            return base.Channel.Hi(name);
        }
        
        public System.Threading.Tasks.Task<string> HiAsync(string name) {
            return base.Channel.HiAsync(name);
        }
        
        public int Sum(int a, int b) {
            return base.Channel.Sum(a, b);
        }
        
        public System.Threading.Tasks.Task<int> SumAsync(int a, int b) {
            return base.Channel.SumAsync(a, b);
        }
    }
}
