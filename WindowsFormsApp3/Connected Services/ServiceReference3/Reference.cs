﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp3.ServiceReference3 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.IService3")]
    public interface IService3 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/DoWork", ReplyAction="http://tempuri.org/IService3/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/DoWork", ReplyAction="http://tempuri.org/IService3/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/contadorSingle", ReplyAction="http://tempuri.org/IService3/contadorSingleResponse")]
        int contadorSingle();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService3/contadorSingle", ReplyAction="http://tempuri.org/IService3/contadorSingleResponse")]
        System.Threading.Tasks.Task<int> contadorSingleAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService3Channel : WindowsFormsApp3.ServiceReference3.IService3, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service3Client : System.ServiceModel.ClientBase<WindowsFormsApp3.ServiceReference3.IService3>, WindowsFormsApp3.ServiceReference3.IService3 {
        
        public Service3Client() {
        }
        
        public Service3Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service3Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service3Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service3Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public int contadorSingle() {
            return base.Channel.contadorSingle();
        }
        
        public System.Threading.Tasks.Task<int> contadorSingleAsync() {
            return base.Channel.contadorSingleAsync();
        }
    }
}
