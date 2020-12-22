﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NetProg6.Server {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Server.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/HelloUser")]
        void HelloUser(string name);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IService/HelloUser")]
        System.Threading.Tasks.Task HelloUserAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Summator", ReplyAction="http://tempuri.org/IService/SummatorResponse")]
        int Summator(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Summator", ReplyAction="http://tempuri.org/IService/SummatorResponse")]
        System.Threading.Tasks.Task<int> SummatorAsync(int num1, int num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : NetProg6.Server.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<NetProg6.Server.IService>, NetProg6.Server.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void HelloUser(string name) {
            base.Channel.HelloUser(name);
        }
        
        public System.Threading.Tasks.Task HelloUserAsync(string name) {
            return base.Channel.HelloUserAsync(name);
        }
        
        public int Summator(int num1, int num2) {
            return base.Channel.Summator(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> SummatorAsync(int num1, int num2) {
            return base.Channel.SummatorAsync(num1, num2);
        }
    }
}