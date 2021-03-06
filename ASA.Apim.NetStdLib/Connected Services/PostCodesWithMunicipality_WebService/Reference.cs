﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PostCodesWithMunicipality_WebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", ConfigurationName="PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service")]
    public interface PostCodesWithMunicipality_Service
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(PostCodesWithMunicipality_WebService.GetRecIdFromKeyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.IsUpdatedResponse> IsUpdatedAsync(PostCodesWithMunicipality_WebService.IsUpdatedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.ReadResponse> ReadAsync(PostCodesWithMunicipality_WebService.ReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.ReadByRecIdResponse> ReadByRecIdAsync(PostCodesWithMunicipality_WebService.ReadByRecIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.ReadMultipleResponse> ReadMultipleAsync(PostCodesWithMunicipality_WebService.ReadMultipleRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", IsWrapped=true)]
    public partial class GetRecIdFromKeyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", IsWrapped=true)]
    public partial class GetRecIdFromKeyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", IsWrapped=true)]
    public partial class IsUpdatedRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", IsWrapped=true)]
    public partial class IsUpdatedResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=0)]
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality")]
    public partial class postCodesWithMunicipality
    {
        
        private string keyField;
        
        private string codeField;
        
        private string cityField;
        
        private string country_Region_CodeField;
        
        private string countyField;
        
        private string municipal_CodeField;
        
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
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Country_Region_Code
        {
            get
            {
                return this.country_Region_CodeField;
            }
            set
            {
                this.country_Region_CodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string County
        {
            get
            {
                return this.countyField;
            }
            set
            {
                this.countyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Municipal_Code
        {
            get
            {
                return this.municipal_CodeField;
            }
            set
            {
                this.municipal_CodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality")]
    public partial class postCodesWithMunicipality_Filter
    {
        
        private postCodesWithMunicipality_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public postCodesWithMunicipality_Fields Field
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality")]
    public enum postCodesWithMunicipality_Fields
    {
        
        /// <remarks/>
        Code,
        
        /// <remarks/>
        City,
        
        /// <remarks/>
        Country_Region_Code,
        
        /// <remarks/>
        County,
        
        /// <remarks/>
        Municipal_Code,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", IsWrapped=true)]
    public partial class ReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=0)]
        public string Code;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=1)]
        public string City;
        
        public ReadRequest()
        {
        }
        
        public ReadRequest(string Code, string City)
        {
            this.Code = Code;
            this.City = City;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", IsWrapped=true)]
    public partial class ReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=0)]
        public PostCodesWithMunicipality_WebService.postCodesWithMunicipality postCodesWithMunicipality;
        
        public ReadResponse()
        {
        }
        
        public ReadResponse(PostCodesWithMunicipality_WebService.postCodesWithMunicipality postCodesWithMunicipality)
        {
            this.postCodesWithMunicipality = postCodesWithMunicipality;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", IsWrapped=true)]
    public partial class ReadByRecIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", IsWrapped=true)]
    public partial class ReadByRecIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=0)]
        public PostCodesWithMunicipality_WebService.postCodesWithMunicipality postCodesWithMunicipality;
        
        public ReadByRecIdResponse()
        {
        }
        
        public ReadByRecIdResponse(PostCodesWithMunicipality_WebService.postCodesWithMunicipality postCodesWithMunicipality)
        {
            this.postCodesWithMunicipality = postCodesWithMunicipality;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", IsWrapped=true)]
    public partial class ReadMultipleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public PostCodesWithMunicipality_WebService.postCodesWithMunicipality_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=2)]
        public int setSize;
        
        public ReadMultipleRequest()
        {
        }
        
        public ReadMultipleRequest(PostCodesWithMunicipality_WebService.postCodesWithMunicipality_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", IsWrapped=true)]
    public partial class ReadMultipleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/postcodeswithmunicipality", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public PostCodesWithMunicipality_WebService.postCodesWithMunicipality[] ReadMultiple_Result;
        
        public ReadMultipleResponse()
        {
        }
        
        public ReadMultipleResponse(PostCodesWithMunicipality_WebService.postCodesWithMunicipality[] ReadMultiple_Result)
        {
            this.ReadMultiple_Result = ReadMultiple_Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface PostCodesWithMunicipality_ServiceChannel : PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class PostCodesWithMunicipality_ServiceClient : System.ServiceModel.ClientBase<PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service>, PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PostCodesWithMunicipality_ServiceClient() : 
                base(PostCodesWithMunicipality_ServiceClient.GetDefaultBinding(), PostCodesWithMunicipality_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.PostCodesWithMunicipality_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCodesWithMunicipality_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PostCodesWithMunicipality_ServiceClient.GetBindingForEndpoint(endpointConfiguration), PostCodesWithMunicipality_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCodesWithMunicipality_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PostCodesWithMunicipality_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCodesWithMunicipality_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PostCodesWithMunicipality_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PostCodesWithMunicipality_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.GetRecIdFromKeyResponse> PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service.GetRecIdFromKeyAsync(PostCodesWithMunicipality_WebService.GetRecIdFromKeyRequest request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(string Key)
        {
            PostCodesWithMunicipality_WebService.GetRecIdFromKeyRequest inValue = new PostCodesWithMunicipality_WebService.GetRecIdFromKeyRequest();
            inValue.Key = Key;
            return ((PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service)(this)).GetRecIdFromKeyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.IsUpdatedResponse> PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service.IsUpdatedAsync(PostCodesWithMunicipality_WebService.IsUpdatedRequest request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.IsUpdatedResponse> IsUpdatedAsync(string Key)
        {
            PostCodesWithMunicipality_WebService.IsUpdatedRequest inValue = new PostCodesWithMunicipality_WebService.IsUpdatedRequest();
            inValue.Key = Key;
            return ((PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service)(this)).IsUpdatedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.ReadResponse> PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service.ReadAsync(PostCodesWithMunicipality_WebService.ReadRequest request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.ReadResponse> ReadAsync(string Code, string City)
        {
            PostCodesWithMunicipality_WebService.ReadRequest inValue = new PostCodesWithMunicipality_WebService.ReadRequest();
            inValue.Code = Code;
            inValue.City = City;
            return ((PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.ReadByRecIdResponse> PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service.ReadByRecIdAsync(PostCodesWithMunicipality_WebService.ReadByRecIdRequest request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.ReadByRecIdResponse> ReadByRecIdAsync(string recId)
        {
            PostCodesWithMunicipality_WebService.ReadByRecIdRequest inValue = new PostCodesWithMunicipality_WebService.ReadByRecIdRequest();
            inValue.recId = recId;
            return ((PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service)(this)).ReadByRecIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.ReadMultipleResponse> PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service.ReadMultipleAsync(PostCodesWithMunicipality_WebService.ReadMultipleRequest request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<PostCodesWithMunicipality_WebService.ReadMultipleResponse> ReadMultipleAsync(PostCodesWithMunicipality_WebService.postCodesWithMunicipality_Filter[] filter, string bookmarkKey, int setSize)
        {
            PostCodesWithMunicipality_WebService.ReadMultipleRequest inValue = new PostCodesWithMunicipality_WebService.ReadMultipleRequest();
            inValue.filter = filter;
            inValue.bookmarkKey = bookmarkKey;
            inValue.setSize = setSize;
            return ((PostCodesWithMunicipality_WebService.PostCodesWithMunicipality_Service)(this)).ReadMultipleAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.PostCodesWithMunicipality_Service))
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
            if ((endpointConfiguration == EndpointConfiguration.PostCodesWithMunicipality_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://iqiapimanagement-asa-dev.azure-api.net/postcodeswithmunicipality");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PostCodesWithMunicipality_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.PostCodesWithMunicipality_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PostCodesWithMunicipality_ServiceClient.GetEndpointAddress(EndpointConfiguration.PostCodesWithMunicipality_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            PostCodesWithMunicipality_Service,
        }
    }
}
