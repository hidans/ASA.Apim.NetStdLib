﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalarySettlement_WebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/SalarySettlement", ConfigurationName="SalarySettlement_WebService.SalarySettlement_Service")]
    public interface SalarySettlement_Service
    {
        
        // CODEGEN: Generating message contract since the operation has multiple return values.
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/codeunit/SalarySettlement:SalarySettle", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SalarySettlement_WebService.SalarySettleResponse> SalarySettleAsync(SalarySettlement_WebService.SalarySettleRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-nav/xmlports/x6024612")]
    public partial class SalaryPostings
    {
        
        private SalaryPosting[] salaryPostingField;
        
        private string[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalaryPosting", Order=0)]
        public SalaryPosting[] SalaryPosting
        {
            get
            {
                return this.salaryPostingField;
            }
            set
            {
                this.salaryPostingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-nav/xmlports/x6024612")]
    public partial class SalaryPosting
    {
        
        private string accountNoField;
        
        private System.DateTime postingDateField;
        
        private string postingTextField;
        
        private decimal amountField;
        
        private string departmentCodeField;
        
        public SalaryPosting()
        {
            this.postingDateField = new System.DateTime(0);
            this.amountField = ((decimal)(0m));
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string AccountNo
        {
            get
            {
                return this.accountNoField;
            }
            set
            {
                this.accountNoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=1)]
        public System.DateTime PostingDate
        {
            get
            {
                return this.postingDateField;
            }
            set
            {
                this.postingDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string PostingText
        {
            get
            {
                return this.postingTextField;
            }
            set
            {
                this.postingTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string DepartmentCode
        {
            get
            {
                return this.departmentCodeField;
            }
            set
            {
                this.departmentCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-nav/xmlports/x6024611")]
    public partial class SalarySession
    {
        
        private string salaryGUIDField;
        
        private decimal amountField;
        
        public SalarySession()
        {
            this.salaryGUIDField = "{00000000-0000-0000-0000-000000000000}";
            this.amountField = ((decimal)(0m));
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SalaryGUID
        {
            get
            {
                return this.salaryGUIDField;
            }
            set
            {
                this.salaryGUIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public decimal Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-nav/xmlports/x6024611")]
    public partial class SalarySessions
    {
        
        private SalarySession[] salarySessionField;
        
        private string[] textField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SalarySession", Order=0)]
        public SalarySession[] SalarySession
        {
            get
            {
                return this.salarySessionField;
            }
            set
            {
                this.salarySessionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalarySettle", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/SalarySettlement", IsWrapped=true)]
    public partial class SalarySettleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/SalarySettlement", Order=0)]
        public SalarySettlement_WebService.SalaryPostings salaryPostings;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/SalarySettlement", Order=1)]
        public SalarySettlement_WebService.SalarySessions salarySessions;
        
        public SalarySettleRequest()
        {
        }
        
        public SalarySettleRequest(SalarySettlement_WebService.SalaryPostings salaryPostings, SalarySettlement_WebService.SalarySessions salarySessions)
        {
            this.salaryPostings = salaryPostings;
            this.salarySessions = salarySessions;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SalarySettle_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/codeunit/SalarySettlement", IsWrapped=true)]
    public partial class SalarySettleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/SalarySettlement", Order=0)]
        public SalarySettlement_WebService.SalaryPostings salaryPostings;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/codeunit/SalarySettlement", Order=1)]
        public SalarySettlement_WebService.SalarySessions salarySessions;
        
        public SalarySettleResponse()
        {
        }
        
        public SalarySettleResponse(SalarySettlement_WebService.SalaryPostings salaryPostings, SalarySettlement_WebService.SalarySessions salarySessions)
        {
            this.salaryPostings = salaryPostings;
            this.salarySessions = salarySessions;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface SalarySettlement_ServiceChannel : SalarySettlement_WebService.SalarySettlement_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class SalarySettlement_ServiceClient : System.ServiceModel.ClientBase<SalarySettlement_WebService.SalarySettlement_Service>, SalarySettlement_WebService.SalarySettlement_Service
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SalarySettlement_ServiceClient() : 
                base(SalarySettlement_ServiceClient.GetDefaultBinding(), SalarySettlement_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.SalarySettlement_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalarySettlement_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(SalarySettlement_ServiceClient.GetBindingForEndpoint(endpointConfiguration), SalarySettlement_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalarySettlement_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SalarySettlement_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalarySettlement_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SalarySettlement_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SalarySettlement_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<SalarySettlement_WebService.SalarySettleResponse> SalarySettleAsync(SalarySettlement_WebService.SalarySettleRequest request)
        {
            return base.Channel.SalarySettleAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SalarySettlement_Service))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SalarySettlement_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://iqiapimanagement-asa-test.azure-api.net/salarysettlement");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SalarySettlement_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.SalarySettlement_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SalarySettlement_ServiceClient.GetEndpointAddress(EndpointConfiguration.SalarySettlement_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            SalarySettlement_Service,
        }
    }
}
