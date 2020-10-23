﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TN_CourseParticipant_WebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", ConfigurationName="TN_CourseParticipant_WebService.TN_CourseParticipant_Service")]
    public interface TN_CourseParticipant_Service
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/tn_courseparticipant:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TN_CourseParticipant_WebService.ReadResponse> ReadAsync(TN_CourseParticipant_WebService.ReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/tn_courseparticipant:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TN_CourseParticipant_WebService.ReadByRecIdResponse> ReadByRecIdAsync(TN_CourseParticipant_WebService.ReadByRecIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/tn_courseparticipant:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TN_CourseParticipant_WebService.ReadMultipleResponse> ReadMultipleAsync(TN_CourseParticipant_WebService.ReadMultipleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/tn_courseparticipant:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TN_CourseParticipant_WebService.IsUpdatedResponse> IsUpdatedAsync(TN_CourseParticipant_WebService.IsUpdatedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/tn_courseparticipant:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<TN_CourseParticipant_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(TN_CourseParticipant_WebService.GetRecIdFromKeyRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant")]
    public partial class TN_CourseParticipant
    {
        
        private string keyField;
        
        private string course_Header_NoField;
        
        private string participant_NoField;
        
        private string participant_NameField;
        
        private string notesField;
        
        private string particpant_AddressField;
        
        private string particpant_Address_2Field;
        
        private string particpant_Post_CodeField;
        
        private string particpant_CityField;
        
        private string particpant_Municipal_CodeField;
        
        private string particpant_Country_Region_CodeField;
        
        private string participant_Mobile_Phone_NoField;
        
        private bool particpant_Permission_to_SMSField;
        
        private bool particpant_Permission_to_SMSFieldSpecified;
        
        private string participant_E_mailField;
        
        private bool particpant_Permission_to_E_mailField;
        
        private bool particpant_Permission_to_E_mailFieldSpecified;
        
        private Course_Line_Status course_Line_StatusField;
        
        private bool course_Line_StatusFieldSpecified;
        
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
        public string Course_Header_No
        {
            get
            {
                return this.course_Header_NoField;
            }
            set
            {
                this.course_Header_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Participant_No
        {
            get
            {
                return this.participant_NoField;
            }
            set
            {
                this.participant_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Participant_Name
        {
            get
            {
                return this.participant_NameField;
            }
            set
            {
                this.participant_NameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Particpant_Address
        {
            get
            {
                return this.particpant_AddressField;
            }
            set
            {
                this.particpant_AddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Particpant_Address_2
        {
            get
            {
                return this.particpant_Address_2Field;
            }
            set
            {
                this.particpant_Address_2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Particpant_Post_Code
        {
            get
            {
                return this.particpant_Post_CodeField;
            }
            set
            {
                this.particpant_Post_CodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Particpant_City
        {
            get
            {
                return this.particpant_CityField;
            }
            set
            {
                this.particpant_CityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string Particpant_Municipal_Code
        {
            get
            {
                return this.particpant_Municipal_CodeField;
            }
            set
            {
                this.particpant_Municipal_CodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Particpant_Country_Region_Code
        {
            get
            {
                return this.particpant_Country_Region_CodeField;
            }
            set
            {
                this.particpant_Country_Region_CodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string Participant_Mobile_Phone_No
        {
            get
            {
                return this.participant_Mobile_Phone_NoField;
            }
            set
            {
                this.participant_Mobile_Phone_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public bool Particpant_Permission_to_SMS
        {
            get
            {
                return this.particpant_Permission_to_SMSField;
            }
            set
            {
                this.particpant_Permission_to_SMSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Particpant_Permission_to_SMSSpecified
        {
            get
            {
                return this.particpant_Permission_to_SMSFieldSpecified;
            }
            set
            {
                this.particpant_Permission_to_SMSFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string Participant_E_mail
        {
            get
            {
                return this.participant_E_mailField;
            }
            set
            {
                this.participant_E_mailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public bool Particpant_Permission_to_E_mail
        {
            get
            {
                return this.particpant_Permission_to_E_mailField;
            }
            set
            {
                this.particpant_Permission_to_E_mailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Particpant_Permission_to_E_mailSpecified
        {
            get
            {
                return this.particpant_Permission_to_E_mailFieldSpecified;
            }
            set
            {
                this.particpant_Permission_to_E_mailFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public Course_Line_Status Course_Line_Status
        {
            get
            {
                return this.course_Line_StatusField;
            }
            set
            {
                this.course_Line_StatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Course_Line_StatusSpecified
        {
            get
            {
                return this.course_Line_StatusFieldSpecified;
            }
            set
            {
                this.course_Line_StatusFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant")]
    public enum Course_Line_Status
    {
        
        /// <remarks/>
        Reserved,
        
        /// <remarks/>
        Participation,
        
        /// <remarks/>
        Cancellation,
        
        /// <remarks/>
        Rejection,
        
        /// <remarks/>
        Waitinglist,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant")]
    public partial class TN_CourseParticipant_Filter
    {
        
        private TN_CourseParticipant_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TN_CourseParticipant_Fields Field
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant")]
    public enum TN_CourseParticipant_Fields
    {
        
        /// <remarks/>
        Course_Header_No,
        
        /// <remarks/>
        Participant_No,
        
        /// <remarks/>
        Participant_Name,
        
        /// <remarks/>
        Notes,
        
        /// <remarks/>
        Particpant_Address,
        
        /// <remarks/>
        Particpant_Address_2,
        
        /// <remarks/>
        Particpant_Post_Code,
        
        /// <remarks/>
        Particpant_City,
        
        /// <remarks/>
        Particpant_Municipal_Code,
        
        /// <remarks/>
        Particpant_Country_Region_Code,
        
        /// <remarks/>
        Participant_Mobile_Phone_No,
        
        /// <remarks/>
        Particpant_Permission_to_SMS,
        
        /// <remarks/>
        Participant_E_mail,
        
        /// <remarks/>
        Particpant_Permission_to_E_mail,
        
        /// <remarks/>
        Course_Line_Status,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", IsWrapped=true)]
    public partial class ReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=0)]
        public string Course_Header_No;
        
        public ReadRequest()
        {
        }
        
        public ReadRequest(string Course_Header_No)
        {
            this.Course_Header_No = Course_Header_No;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", IsWrapped=true)]
    public partial class ReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=0)]
        public TN_CourseParticipant_WebService.TN_CourseParticipant TN_CourseParticipant;
        
        public ReadResponse()
        {
        }
        
        public ReadResponse(TN_CourseParticipant_WebService.TN_CourseParticipant TN_CourseParticipant)
        {
            this.TN_CourseParticipant = TN_CourseParticipant;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", IsWrapped=true)]
    public partial class ReadByRecIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", IsWrapped=true)]
    public partial class ReadByRecIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=0)]
        public TN_CourseParticipant_WebService.TN_CourseParticipant TN_CourseParticipant;
        
        public ReadByRecIdResponse()
        {
        }
        
        public ReadByRecIdResponse(TN_CourseParticipant_WebService.TN_CourseParticipant TN_CourseParticipant)
        {
            this.TN_CourseParticipant = TN_CourseParticipant;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", IsWrapped=true)]
    public partial class ReadMultipleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public TN_CourseParticipant_WebService.TN_CourseParticipant_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=2)]
        public int setSize;
        
        public ReadMultipleRequest()
        {
        }
        
        public ReadMultipleRequest(TN_CourseParticipant_WebService.TN_CourseParticipant_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", IsWrapped=true)]
    public partial class ReadMultipleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public TN_CourseParticipant_WebService.TN_CourseParticipant[] ReadMultiple_Result;
        
        public ReadMultipleResponse()
        {
        }
        
        public ReadMultipleResponse(TN_CourseParticipant_WebService.TN_CourseParticipant[] ReadMultiple_Result)
        {
            this.ReadMultiple_Result = ReadMultiple_Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", IsWrapped=true)]
    public partial class IsUpdatedRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", IsWrapped=true)]
    public partial class IsUpdatedResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", IsWrapped=true)]
    public partial class GetRecIdFromKeyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", IsWrapped=true)]
    public partial class GetRecIdFromKeyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/tn_courseparticipant", Order=0)]
        public string GetRecIdFromKey_Result;
        
        public GetRecIdFromKeyResponse()
        {
        }
        
        public GetRecIdFromKeyResponse(string GetRecIdFromKey_Result)
        {
            this.GetRecIdFromKey_Result = GetRecIdFromKey_Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface TN_CourseParticipant_ServiceChannel : TN_CourseParticipant_WebService.TN_CourseParticipant_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class TN_CourseParticipant_ServiceClient : System.ServiceModel.ClientBase<TN_CourseParticipant_WebService.TN_CourseParticipant_Service>, TN_CourseParticipant_WebService.TN_CourseParticipant_Service
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public TN_CourseParticipant_ServiceClient() : 
                base(TN_CourseParticipant_ServiceClient.GetDefaultBinding(), TN_CourseParticipant_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.TN_CourseParticipant_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TN_CourseParticipant_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(TN_CourseParticipant_ServiceClient.GetBindingForEndpoint(endpointConfiguration), TN_CourseParticipant_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TN_CourseParticipant_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(TN_CourseParticipant_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TN_CourseParticipant_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(TN_CourseParticipant_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public TN_CourseParticipant_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TN_CourseParticipant_WebService.ReadResponse> TN_CourseParticipant_WebService.TN_CourseParticipant_Service.ReadAsync(TN_CourseParticipant_WebService.ReadRequest request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<TN_CourseParticipant_WebService.ReadResponse> ReadAsync(string Course_Header_No)
        {
            TN_CourseParticipant_WebService.ReadRequest inValue = new TN_CourseParticipant_WebService.ReadRequest();
            inValue.Course_Header_No = Course_Header_No;
            return ((TN_CourseParticipant_WebService.TN_CourseParticipant_Service)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TN_CourseParticipant_WebService.ReadByRecIdResponse> TN_CourseParticipant_WebService.TN_CourseParticipant_Service.ReadByRecIdAsync(TN_CourseParticipant_WebService.ReadByRecIdRequest request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<TN_CourseParticipant_WebService.ReadByRecIdResponse> ReadByRecIdAsync(string recId)
        {
            TN_CourseParticipant_WebService.ReadByRecIdRequest inValue = new TN_CourseParticipant_WebService.ReadByRecIdRequest();
            inValue.recId = recId;
            return ((TN_CourseParticipant_WebService.TN_CourseParticipant_Service)(this)).ReadByRecIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TN_CourseParticipant_WebService.ReadMultipleResponse> TN_CourseParticipant_WebService.TN_CourseParticipant_Service.ReadMultipleAsync(TN_CourseParticipant_WebService.ReadMultipleRequest request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<TN_CourseParticipant_WebService.ReadMultipleResponse> ReadMultipleAsync(TN_CourseParticipant_WebService.TN_CourseParticipant_Filter[] filter, string bookmarkKey, int setSize)
        {
            TN_CourseParticipant_WebService.ReadMultipleRequest inValue = new TN_CourseParticipant_WebService.ReadMultipleRequest();
            inValue.filter = filter;
            inValue.bookmarkKey = bookmarkKey;
            inValue.setSize = setSize;
            return ((TN_CourseParticipant_WebService.TN_CourseParticipant_Service)(this)).ReadMultipleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TN_CourseParticipant_WebService.IsUpdatedResponse> TN_CourseParticipant_WebService.TN_CourseParticipant_Service.IsUpdatedAsync(TN_CourseParticipant_WebService.IsUpdatedRequest request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public System.Threading.Tasks.Task<TN_CourseParticipant_WebService.IsUpdatedResponse> IsUpdatedAsync(string Key)
        {
            TN_CourseParticipant_WebService.IsUpdatedRequest inValue = new TN_CourseParticipant_WebService.IsUpdatedRequest();
            inValue.Key = Key;
            return ((TN_CourseParticipant_WebService.TN_CourseParticipant_Service)(this)).IsUpdatedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<TN_CourseParticipant_WebService.GetRecIdFromKeyResponse> TN_CourseParticipant_WebService.TN_CourseParticipant_Service.GetRecIdFromKeyAsync(TN_CourseParticipant_WebService.GetRecIdFromKeyRequest request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<TN_CourseParticipant_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(string Key)
        {
            TN_CourseParticipant_WebService.GetRecIdFromKeyRequest inValue = new TN_CourseParticipant_WebService.GetRecIdFromKeyRequest();
            inValue.Key = Key;
            return ((TN_CourseParticipant_WebService.TN_CourseParticipant_Service)(this)).GetRecIdFromKeyAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.TN_CourseParticipant_Service))
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
            if ((endpointConfiguration == EndpointConfiguration.TN_CourseParticipant_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://iqiapimanagement-asa-dev.azure-api.net/tn_courseparticipant");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return TN_CourseParticipant_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.TN_CourseParticipant_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return TN_CourseParticipant_ServiceClient.GetEndpointAddress(EndpointConfiguration.TN_CourseParticipant_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            TN_CourseParticipant_Service,
        }
    }
}