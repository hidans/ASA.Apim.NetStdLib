﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseType_WebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", ConfigurationName="CourseType_WebService.CourseType_Service")]
    public interface CourseType_Service
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/coursetype:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseType_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(CourseType_WebService.GetRecIdFromKeyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/coursetype:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseType_WebService.IsUpdatedResponse> IsUpdatedAsync(CourseType_WebService.IsUpdatedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/coursetype:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseType_WebService.ReadResponse> ReadAsync(CourseType_WebService.ReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/coursetype:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseType_WebService.ReadByRecIdResponse> ReadByRecIdAsync(CourseType_WebService.ReadByRecIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/coursetype:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseType_WebService.ReadMultipleResponse> ReadMultipleAsync(CourseType_WebService.ReadMultipleRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursetype", IsWrapped=true)]
    public partial class GetRecIdFromKeyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=0)]
        public string Key;
        
        public GetRecIdFromKeyRequest()
        {
        }
        
        public GetRecIdFromKeyRequest(string Key)
        {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursetype", IsWrapped=true)]
    public partial class GetRecIdFromKeyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=0)]
        public string GetRecIdFromKey_Result;
        
        public GetRecIdFromKeyResponse()
        {
        }
        
        public GetRecIdFromKeyResponse(string GetRecIdFromKey_Result)
        {
            this.GetRecIdFromKey_Result = GetRecIdFromKey_Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursetype", IsWrapped=true)]
    public partial class IsUpdatedRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=0)]
        public string Key;
        
        public IsUpdatedRequest()
        {
        }
        
        public IsUpdatedRequest(string Key)
        {
            this.Key = Key;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursetype", IsWrapped=true)]
    public partial class IsUpdatedResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=0)]
        public bool IsUpdated_Result;
        
        public IsUpdatedResponse()
        {
        }
        
        public IsUpdatedResponse(bool IsUpdated_Result)
        {
            this.IsUpdated_Result = IsUpdated_Result;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype")]
    public partial class courseType
    {
        
        private string keyField;
        
        private string noField;
        
        private string descriptionField;
        
        private bool payers_Name_OnlyField;
        
        private bool payers_Name_OnlyFieldSpecified;
        
        private bool social_Security_No_RequiredField;
        
        private bool social_Security_No_RequiredFieldSpecified;
        
        private bool birthdate_RequiredField;
        
        private bool birthdate_RequiredFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string No
        {
            get
            {
                return this.noField;
            }
            set
            {
                this.noField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool Payers_Name_Only
        {
            get
            {
                return this.payers_Name_OnlyField;
            }
            set
            {
                this.payers_Name_OnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Payers_Name_OnlySpecified
        {
            get
            {
                return this.payers_Name_OnlyFieldSpecified;
            }
            set
            {
                this.payers_Name_OnlyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool Social_Security_No_Required
        {
            get
            {
                return this.social_Security_No_RequiredField;
            }
            set
            {
                this.social_Security_No_RequiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Social_Security_No_RequiredSpecified
        {
            get
            {
                return this.social_Security_No_RequiredFieldSpecified;
            }
            set
            {
                this.social_Security_No_RequiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool Birthdate_Required
        {
            get
            {
                return this.birthdate_RequiredField;
            }
            set
            {
                this.birthdate_RequiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Birthdate_RequiredSpecified
        {
            get
            {
                return this.birthdate_RequiredFieldSpecified;
            }
            set
            {
                this.birthdate_RequiredFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype")]
    public partial class courseType_Filter
    {
        
        private courseType_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public courseType_Fields Field
        {
            get
            {
                return this.fieldField;
            }
            set
            {
                this.fieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Criteria
        {
            get
            {
                return this.criteriaField;
            }
            set
            {
                this.criteriaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype")]
    public enum courseType_Fields
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Description,
        
        /// <remarks/>
        Payers_Name_Only,
        
        /// <remarks/>
        Social_Security_No_Required,
        
        /// <remarks/>
        Birthdate_Required,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursetype", IsWrapped=true)]
    public partial class ReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=0)]
        public string No;
        
        public ReadRequest()
        {
        }
        
        public ReadRequest(string No)
        {
            this.No = No;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursetype", IsWrapped=true)]
    public partial class ReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=0)]
        public CourseType_WebService.courseType courseType;
        
        public ReadResponse()
        {
        }
        
        public ReadResponse(CourseType_WebService.courseType courseType)
        {
            this.courseType = courseType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursetype", IsWrapped=true)]
    public partial class ReadByRecIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=0)]
        public string recId;
        
        public ReadByRecIdRequest()
        {
        }
        
        public ReadByRecIdRequest(string recId)
        {
            this.recId = recId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursetype", IsWrapped=true)]
    public partial class ReadByRecIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=0)]
        public CourseType_WebService.courseType courseType;
        
        public ReadByRecIdResponse()
        {
        }
        
        public ReadByRecIdResponse(CourseType_WebService.courseType courseType)
        {
            this.courseType = courseType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursetype", IsWrapped=true)]
    public partial class ReadMultipleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public CourseType_WebService.courseType_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=2)]
        public int setSize;
        
        public ReadMultipleRequest()
        {
        }
        
        public ReadMultipleRequest(CourseType_WebService.courseType_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursetype", IsWrapped=true)]
    public partial class ReadMultipleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursetype", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public CourseType_WebService.courseType[] ReadMultiple_Result;
        
        public ReadMultipleResponse()
        {
        }
        
        public ReadMultipleResponse(CourseType_WebService.courseType[] ReadMultiple_Result)
        {
            this.ReadMultiple_Result = ReadMultiple_Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface CourseType_ServiceChannel : CourseType_WebService.CourseType_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class CourseType_ServiceClient : System.ServiceModel.ClientBase<CourseType_WebService.CourseType_Service>, CourseType_WebService.CourseType_Service
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CourseType_ServiceClient() : 
                base(CourseType_ServiceClient.GetDefaultBinding(), CourseType_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.CourseType_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseType_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(CourseType_ServiceClient.GetBindingForEndpoint(endpointConfiguration), CourseType_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseType_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CourseType_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseType_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CourseType_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseType_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseType_WebService.GetRecIdFromKeyResponse> CourseType_WebService.CourseType_Service.GetRecIdFromKeyAsync(CourseType_WebService.GetRecIdFromKeyRequest request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseType_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(string Key)
        {
            CourseType_WebService.GetRecIdFromKeyRequest inValue = new CourseType_WebService.GetRecIdFromKeyRequest();
            inValue.Key = Key;
            return ((CourseType_WebService.CourseType_Service)(this)).GetRecIdFromKeyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseType_WebService.IsUpdatedResponse> CourseType_WebService.CourseType_Service.IsUpdatedAsync(CourseType_WebService.IsUpdatedRequest request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseType_WebService.IsUpdatedResponse> IsUpdatedAsync(string Key)
        {
            CourseType_WebService.IsUpdatedRequest inValue = new CourseType_WebService.IsUpdatedRequest();
            inValue.Key = Key;
            return ((CourseType_WebService.CourseType_Service)(this)).IsUpdatedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseType_WebService.ReadResponse> CourseType_WebService.CourseType_Service.ReadAsync(CourseType_WebService.ReadRequest request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseType_WebService.ReadResponse> ReadAsync(string No)
        {
            CourseType_WebService.ReadRequest inValue = new CourseType_WebService.ReadRequest();
            inValue.No = No;
            return ((CourseType_WebService.CourseType_Service)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseType_WebService.ReadByRecIdResponse> CourseType_WebService.CourseType_Service.ReadByRecIdAsync(CourseType_WebService.ReadByRecIdRequest request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseType_WebService.ReadByRecIdResponse> ReadByRecIdAsync(string recId)
        {
            CourseType_WebService.ReadByRecIdRequest inValue = new CourseType_WebService.ReadByRecIdRequest();
            inValue.recId = recId;
            return ((CourseType_WebService.CourseType_Service)(this)).ReadByRecIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseType_WebService.ReadMultipleResponse> CourseType_WebService.CourseType_Service.ReadMultipleAsync(CourseType_WebService.ReadMultipleRequest request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseType_WebService.ReadMultipleResponse> ReadMultipleAsync(CourseType_WebService.courseType_Filter[] filter, string bookmarkKey, int setSize)
        {
            CourseType_WebService.ReadMultipleRequest inValue = new CourseType_WebService.ReadMultipleRequest();
            inValue.filter = filter;
            inValue.bookmarkKey = bookmarkKey;
            inValue.setSize = setSize;
            return ((CourseType_WebService.CourseType_Service)(this)).ReadMultipleAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.CourseType_Service))
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
            if ((endpointConfiguration == EndpointConfiguration.CourseType_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://iqiapimanagement-asa-dev.azure-api.net/coursetype");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CourseType_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.CourseType_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CourseType_ServiceClient.GetEndpointAddress(EndpointConfiguration.CourseType_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            CourseType_Service,
        }
    }
}