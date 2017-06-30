﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloWorldHarness.HelloWorldService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/HelloWorld.Data")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CreatedByUserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedOnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserTypeIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CreatedByUserName {
            get {
                return this.CreatedByUserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CreatedByUserNameField, value) != true)) {
                    this.CreatedByUserNameField = value;
                    this.RaisePropertyChanged("CreatedByUserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CreatedOn {
            get {
                return this.CreatedOnField;
            }
            set {
                if ((this.CreatedOnField.Equals(value) != true)) {
                    this.CreatedOnField = value;
                    this.RaisePropertyChanged("CreatedOn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserTypeId {
            get {
                return this.UserTypeIdField;
            }
            set {
                if ((this.UserTypeIdField.Equals(value) != true)) {
                    this.UserTypeIdField = value;
                    this.RaisePropertyChanged("UserTypeId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HelloWorldService.IHelloWorldService")]
    public interface IHelloWorldService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldService/HelloWorld", ReplyAction="http://tempuri.org/IHelloWorldService/HelloWorldResponse")]
        string HelloWorld(string firstName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldService/HelloWorld", ReplyAction="http://tempuri.org/IHelloWorldService/HelloWorldResponse")]
        System.Threading.Tasks.Task<string> HelloWorldAsync(string firstName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldService/GetAllUsers", ReplyAction="http://tempuri.org/IHelloWorldService/GetAllUsersResponse")]
        HelloWorldHarness.HelloWorldService.User[] GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHelloWorldService/GetAllUsers", ReplyAction="http://tempuri.org/IHelloWorldService/GetAllUsersResponse")]
        System.Threading.Tasks.Task<HelloWorldHarness.HelloWorldService.User[]> GetAllUsersAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHelloWorldServiceChannel : HelloWorldHarness.HelloWorldService.IHelloWorldService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HelloWorldServiceClient : System.ServiceModel.ClientBase<HelloWorldHarness.HelloWorldService.IHelloWorldService>, HelloWorldHarness.HelloWorldService.IHelloWorldService {
        
        public HelloWorldServiceClient() {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HelloWorldServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HelloWorld(string firstName) {
            return base.Channel.HelloWorld(firstName);
        }
        
        public System.Threading.Tasks.Task<string> HelloWorldAsync(string firstName) {
            return base.Channel.HelloWorldAsync(firstName);
        }
        
        public HelloWorldHarness.HelloWorldService.User[] GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<HelloWorldHarness.HelloWorldService.User[]> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
    }
}
