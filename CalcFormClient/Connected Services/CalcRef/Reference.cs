﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalcFormClient.CalcRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ddu.ac.in/wcf", ConfigurationName="CalcRef.ICalculator")]
    public interface ICalculator {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ddu.ac.in/wcf/ICalculator/Add", ReplyAction="http://ddu.ac.in/wcf/ICalculator/AddResponse")]
        double Add(double op1, double op2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ddu.ac.in/wcf/ICalculator/Add", ReplyAction="http://ddu.ac.in/wcf/ICalculator/AddResponse")]
        System.Threading.Tasks.Task<double> AddAsync(double op1, double op2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ddu.ac.in/wcf/ICalculator/Mul", ReplyAction="http://ddu.ac.in/wcf/ICalculator/MulResponse")]
        double Mul(double op1, double op2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://ddu.ac.in/wcf/ICalculator/Mul", ReplyAction="http://ddu.ac.in/wcf/ICalculator/MulResponse")]
        System.Threading.Tasks.Task<double> MulAsync(double op1, double op2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : CalcFormClient.CalcRef.ICalculator, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : System.ServiceModel.ClientBase<CalcFormClient.CalcRef.ICalculator>, CalcFormClient.CalcRef.ICalculator {
        
        public CalculatorClient() {
        }
        
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Add(double op1, double op2) {
            return base.Channel.Add(op1, op2);
        }
        
        public System.Threading.Tasks.Task<double> AddAsync(double op1, double op2) {
            return base.Channel.AddAsync(op1, op2);
        }
        
        public double Mul(double op1, double op2) {
            return base.Channel.Mul(op1, op2);
        }
        
        public System.Threading.Tasks.Task<double> MulAsync(double op1, double op2) {
            return base.Channel.MulAsync(op1, op2);
        }
    }
}
