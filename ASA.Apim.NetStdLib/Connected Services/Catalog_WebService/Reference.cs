﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     //
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Catalog_WebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", ConfigurationName="Catalog_WebService.Catalog_Service")]
    public interface Catalog_Service
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/catalog:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Catalog_WebService.ReadResponse> ReadAsync(Catalog_WebService.ReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/catalog:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Catalog_WebService.ReadByRecIdResponse> ReadByRecIdAsync(Catalog_WebService.ReadByRecIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/catalog:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Catalog_WebService.ReadMultipleResponse> ReadMultipleAsync(Catalog_WebService.ReadMultipleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/catalog:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Catalog_WebService.IsUpdatedResponse> IsUpdatedAsync(Catalog_WebService.IsUpdatedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/catalog:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Catalog_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(Catalog_WebService.GetRecIdFromKeyRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog")]
    public partial class Catalog
    {
        
        private string keyField;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string descriptionField;
        
        private bool catalog1Field;
        
        private bool catalog1FieldSpecified;
        
        private System.DateTime catalog_From_DateField;
        
        private bool catalog_From_DateFieldSpecified;
        
        private System.DateTime catalog_To_DateField;
        
        private bool catalog_To_DateFieldSpecified;
        
        private string sEO_HeadlineField;
        
        private string sEO_DescriptionField;
        
        private string sEO_ImagelinkField;
        
        private string sEO_TitleField;
        
        private string sEO_Text_AboveField;
        
        private string sEO_Text_BelovField;
        
        private bool portal_AvailableField;
        
        private bool portal_AvailableFieldSpecified;
        
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
        public int Id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IdSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Catalog", Order=3)]
        public bool Catalog1
        {
            get
            {
                return this.catalog1Field;
            }
            set
            {
                this.catalog1Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Catalog1Specified
        {
            get
            {
                return this.catalog1FieldSpecified;
            }
            set
            {
                this.catalog1FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=4)]
        public System.DateTime Catalog_From_Date
        {
            get
            {
                return this.catalog_From_DateField;
            }
            set
            {
                this.catalog_From_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Catalog_From_DateSpecified
        {
            get
            {
                return this.catalog_From_DateFieldSpecified;
            }
            set
            {
                this.catalog_From_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime Catalog_To_Date
        {
            get
            {
                return this.catalog_To_DateField;
            }
            set
            {
                this.catalog_To_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Catalog_To_DateSpecified
        {
            get
            {
                return this.catalog_To_DateFieldSpecified;
            }
            set
            {
                this.catalog_To_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string SEO_Headline
        {
            get
            {
                return this.sEO_HeadlineField;
            }
            set
            {
                this.sEO_HeadlineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string SEO_Description
        {
            get
            {
                return this.sEO_DescriptionField;
            }
            set
            {
                this.sEO_DescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string SEO_Imagelink
        {
            get
            {
                return this.sEO_ImagelinkField;
            }
            set
            {
                this.sEO_ImagelinkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string SEO_Title
        {
            get
            {
                return this.sEO_TitleField;
            }
            set
            {
                this.sEO_TitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string SEO_Text_Above
        {
            get
            {
                return this.sEO_Text_AboveField;
            }
            set
            {
                this.sEO_Text_AboveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string SEO_Text_Belov
        {
            get
            {
                return this.sEO_Text_BelovField;
            }
            set
            {
                this.sEO_Text_BelovField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public bool Portal_Available
        {
            get
            {
                return this.portal_AvailableField;
            }
            set
            {
                this.portal_AvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Portal_AvailableSpecified
        {
            get
            {
                return this.portal_AvailableFieldSpecified;
            }
            set
            {
                this.portal_AvailableFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog")]
    public partial class Catalog_Filter
    {
        
        private Catalog_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Catalog_Fields Field
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog")]
    public enum Catalog_Fields
    {
        
        /// <remarks/>
        Id,
        
        /// <remarks/>
        Description,
        
        /// <remarks/>
        Catalog,
        
        /// <remarks/>
        Catalog_From_Date,
        
        /// <remarks/>
        Catalog_To_Date,
        
        /// <remarks/>
        SEO_Headline,
        
        /// <remarks/>
        SEO_Description,
        
        /// <remarks/>
        SEO_Imagelink,
        
        /// <remarks/>
        SEO_Title,
        
        /// <remarks/>
        SEO_Text_Above,
        
        /// <remarks/>
        SEO_Text_Belov,
        
        /// <remarks/>
        Portal_Available,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/catalog", IsWrapped=true)]
    public partial class ReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=0)]
        public int Id;
        
        public ReadRequest()
        {
        }
        
        public ReadRequest(int Id)
        {
            this.Id = Id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/catalog", IsWrapped=true)]
    public partial class ReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=0)]
        public Catalog_WebService.Catalog Catalog;
        
        public ReadResponse()
        {
        }
        
        public ReadResponse(Catalog_WebService.Catalog Catalog)
        {
            this.Catalog = Catalog;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/catalog", IsWrapped=true)]
    public partial class ReadByRecIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/catalog", IsWrapped=true)]
    public partial class ReadByRecIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=0)]
        public Catalog_WebService.Catalog Catalog;
        
        public ReadByRecIdResponse()
        {
        }
        
        public ReadByRecIdResponse(Catalog_WebService.Catalog Catalog)
        {
            this.Catalog = Catalog;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/catalog", IsWrapped=true)]
    public partial class ReadMultipleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public Catalog_WebService.Catalog_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=2)]
        public int setSize;
        
        public ReadMultipleRequest()
        {
        }
        
        public ReadMultipleRequest(Catalog_WebService.Catalog_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/catalog", IsWrapped=true)]
    public partial class ReadMultipleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Catalog_WebService.Catalog[] ReadMultiple_Result;
        
        public ReadMultipleResponse()
        {
        }
        
        public ReadMultipleResponse(Catalog_WebService.Catalog[] ReadMultiple_Result)
        {
            this.ReadMultiple_Result = ReadMultiple_Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/catalog", IsWrapped=true)]
    public partial class IsUpdatedRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/catalog", IsWrapped=true)]
    public partial class IsUpdatedResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=0)]
        public bool IsUpdated_Result;
        
        public IsUpdatedResponse()
        {
        }
        
        public IsUpdatedResponse(bool IsUpdated_Result)
        {
            this.IsUpdated_Result = IsUpdated_Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/catalog", IsWrapped=true)]
    public partial class GetRecIdFromKeyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/catalog", IsWrapped=true)]
    public partial class GetRecIdFromKeyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/catalog", Order=0)]
        public string GetRecIdFromKey_Result;
        
        public GetRecIdFromKeyResponse()
        {
        }
        
        public GetRecIdFromKeyResponse(string GetRecIdFromKey_Result)
        {
            this.GetRecIdFromKey_Result = GetRecIdFromKey_Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public interface Catalog_ServiceChannel : Catalog_WebService.Catalog_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.1")]
    public partial class Catalog_ServiceClient : System.ServiceModel.ClientBase<Catalog_WebService.Catalog_Service>, Catalog_WebService.Catalog_Service
    {
        
    /// <summary>
    /// Implement this partial method to configure the service endpoint.
    /// </summary>
    /// <param name="serviceEndpoint">The endpoint to configure</param>
    /// <param name="clientCredentials">The client credentials</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Catalog_ServiceClient() : 
                base(Catalog_ServiceClient.GetDefaultBinding(), Catalog_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.Catalog_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Catalog_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(Catalog_ServiceClient.GetBindingForEndpoint(endpointConfiguration), Catalog_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Catalog_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Catalog_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Catalog_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Catalog_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Catalog_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Catalog_WebService.ReadResponse> Catalog_WebService.Catalog_Service.ReadAsync(Catalog_WebService.ReadRequest request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<Catalog_WebService.ReadResponse> ReadAsync(int Id)
        {
            Catalog_WebService.ReadRequest inValue = new Catalog_WebService.ReadRequest();
            inValue.Id = Id;
            return ((Catalog_WebService.Catalog_Service)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Catalog_WebService.ReadByRecIdResponse> Catalog_WebService.Catalog_Service.ReadByRecIdAsync(Catalog_WebService.ReadByRecIdRequest request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<Catalog_WebService.ReadByRecIdResponse> ReadByRecIdAsync(string recId)
        {
            Catalog_WebService.ReadByRecIdRequest inValue = new Catalog_WebService.ReadByRecIdRequest();
            inValue.recId = recId;
            return ((Catalog_WebService.Catalog_Service)(this)).ReadByRecIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Catalog_WebService.ReadMultipleResponse> Catalog_WebService.Catalog_Service.ReadMultipleAsync(Catalog_WebService.ReadMultipleRequest request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<Catalog_WebService.ReadMultipleResponse> ReadMultipleAsync(Catalog_WebService.Catalog_Filter[] filter, string bookmarkKey, int setSize)
        {
            Catalog_WebService.ReadMultipleRequest inValue = new Catalog_WebService.ReadMultipleRequest();
            inValue.filter = filter;
            inValue.bookmarkKey = bookmarkKey;
            inValue.setSize = setSize;
            return ((Catalog_WebService.Catalog_Service)(this)).ReadMultipleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Catalog_WebService.IsUpdatedResponse> Catalog_WebService.Catalog_Service.IsUpdatedAsync(Catalog_WebService.IsUpdatedRequest request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public System.Threading.Tasks.Task<Catalog_WebService.IsUpdatedResponse> IsUpdatedAsync(string Key)
        {
            Catalog_WebService.IsUpdatedRequest inValue = new Catalog_WebService.IsUpdatedRequest();
            inValue.Key = Key;
            return ((Catalog_WebService.Catalog_Service)(this)).IsUpdatedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Catalog_WebService.GetRecIdFromKeyResponse> Catalog_WebService.Catalog_Service.GetRecIdFromKeyAsync(Catalog_WebService.GetRecIdFromKeyRequest request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<Catalog_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(string Key)
        {
            Catalog_WebService.GetRecIdFromKeyRequest inValue = new Catalog_WebService.GetRecIdFromKeyRequest();
            inValue.Key = Key;
            return ((Catalog_WebService.Catalog_Service)(this)).GetRecIdFromKeyAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.Catalog_Service))
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
            if ((endpointConfiguration == EndpointConfiguration.Catalog_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://iqiapimanagement-asa-test.azure-api.net/catalog");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Catalog_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.Catalog_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Catalog_ServiceClient.GetEndpointAddress(EndpointConfiguration.Catalog_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            Catalog_Service,
        }
    }
}
