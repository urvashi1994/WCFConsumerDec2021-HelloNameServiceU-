﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFConsumerDec2021.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IHelloNameServiceU")]
    public interface IHelloNameServiceU {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloNameServiceU/HelloName", ReplyAction="http://tempuri.org/IHelloNameServiceU/HelloNameResponse")]
        string HelloName(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloNameServiceU/HelloName", ReplyAction="http://tempuri.org/IHelloNameServiceU/HelloNameResponse")]
        System.Threading.Tasks.Task<string> HelloNameAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloNameServiceUChannel : WCFConsumerDec2021.ServiceReference1.IHelloNameServiceU, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloNameServiceUClient : System.ServiceModel.ClientBase<WCFConsumerDec2021.ServiceReference1.IHelloNameServiceU>, WCFConsumerDec2021.ServiceReference1.IHelloNameServiceU {
        
        public HelloNameServiceUClient() {
        }
        
        public HelloNameServiceUClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloNameServiceUClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloNameServiceUClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloNameServiceUClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloName(string name) {
            return base.Channel.HelloName(name);
        }
        
        public System.Threading.Tasks.Task<string> HelloNameAsync(string name) {
            return base.Channel.HelloNameAsync(name);
        }
    }
}