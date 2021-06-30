﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseHeaderWithRef_WebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", ConfigurationName="CourseHeaderWithRef_WebService.courseHeaderWithRef_Service")]
    public interface courseHeaderWithRef_Service
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/courseheaderwithref:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.ReadResponse> ReadAsync(CourseHeaderWithRef_WebService.ReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/courseheaderwithref:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.ReadByRecIdResponse> ReadByRecIdAsync(CourseHeaderWithRef_WebService.ReadByRecIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/courseheaderwithref:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.ReadMultipleResponse> ReadMultipleAsync(CourseHeaderWithRef_WebService.ReadMultipleRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/courseheaderwithref:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.IsUpdatedResponse> IsUpdatedAsync(CourseHeaderWithRef_WebService.IsUpdatedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/courseheaderwithref:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(CourseHeaderWithRef_WebService.GetRecIdFromKeyRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref")]
    public partial class courseHeaderWithRef
    {
        
        private string keyField;
        
        private string noField;
        
        private string descriptionField;
        
        private string description_2Field;
        
        private int levelField;
        
        private bool levelFieldSpecified;
        
        private System.DateTime from_DateField;
        
        private bool from_DateFieldSpecified;
        
        private System.DateTime from_TimeField;
        
        private bool from_TimeFieldSpecified;
        
        private System.DateTime to_DateField;
        
        private bool to_DateFieldSpecified;
        
        private System.DateTime to_TimeField;
        
        private bool to_TimeFieldSpecified;
        
        private string course_Location_NoField;
        
        private string class_Room_NoField;
        
        private System.DateTime enrolment_DeadlineField;
        
        private bool enrolment_DeadlineFieldSpecified;
        
        private string school_Department_CodeField;
        
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
        public string Description_2
        {
            get
            {
                return this.description_2Field;
            }
            set
            {
                this.description_2Field = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int Level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LevelSpecified
        {
            get
            {
                return this.levelFieldSpecified;
            }
            set
            {
                this.levelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=5)]
        public System.DateTime From_Date
        {
            get
            {
                return this.from_DateField;
            }
            set
            {
                this.from_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool From_DateSpecified
        {
            get
            {
                return this.from_DateFieldSpecified;
            }
            set
            {
                this.from_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=6)]
        public System.DateTime From_Time
        {
            get
            {
                return this.from_TimeField;
            }
            set
            {
                this.from_TimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool From_TimeSpecified
        {
            get
            {
                return this.from_TimeFieldSpecified;
            }
            set
            {
                this.from_TimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=7)]
        public System.DateTime To_Date
        {
            get
            {
                return this.to_DateField;
            }
            set
            {
                this.to_DateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool To_DateSpecified
        {
            get
            {
                return this.to_DateFieldSpecified;
            }
            set
            {
                this.to_DateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=8)]
        public System.DateTime To_Time
        {
            get
            {
                return this.to_TimeField;
            }
            set
            {
                this.to_TimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool To_TimeSpecified
        {
            get
            {
                return this.to_TimeFieldSpecified;
            }
            set
            {
                this.to_TimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string Course_Location_No
        {
            get
            {
                return this.course_Location_NoField;
            }
            set
            {
                this.course_Location_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Class_Room_No
        {
            get
            {
                return this.class_Room_NoField;
            }
            set
            {
                this.class_Room_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=11)]
        public System.DateTime Enrolment_Deadline
        {
            get
            {
                return this.enrolment_DeadlineField;
            }
            set
            {
                this.enrolment_DeadlineField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Enrolment_DeadlineSpecified
        {
            get
            {
                return this.enrolment_DeadlineFieldSpecified;
            }
            set
            {
                this.enrolment_DeadlineFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string School_Department_Code
        {
            get
            {
                return this.school_Department_CodeField;
            }
            set
            {
                this.school_Department_CodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref")]
    public partial class courseHeaderWithRef_Filter
    {
        
        private courseHeaderWithRef_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public courseHeaderWithRef_Fields Field
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref")]
    public enum courseHeaderWithRef_Fields
    {
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Description,
        
        /// <remarks/>
        Description_2,
        
        /// <remarks/>
        Level,
        
        /// <remarks/>
        From_Date,
        
        /// <remarks/>
        From_Time,
        
        /// <remarks/>
        To_Date,
        
        /// <remarks/>
        To_Time,
        
        /// <remarks/>
        Course_Location_No,
        
        /// <remarks/>
        Class_Room_No,
        
        /// <remarks/>
        Enrolment_Deadline,
        
        /// <remarks/>
        School_Department_Code,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", IsWrapped=true)]
    public partial class ReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", IsWrapped=true)]
    public partial class ReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=0)]
        public CourseHeaderWithRef_WebService.courseHeaderWithRef courseHeaderWithRef;
        
        public ReadResponse()
        {
        }
        
        public ReadResponse(CourseHeaderWithRef_WebService.courseHeaderWithRef courseHeaderWithRef)
        {
            this.courseHeaderWithRef = courseHeaderWithRef;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", IsWrapped=true)]
    public partial class ReadByRecIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", IsWrapped=true)]
    public partial class ReadByRecIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=0)]
        public CourseHeaderWithRef_WebService.courseHeaderWithRef courseHeaderWithRef;
        
        public ReadByRecIdResponse()
        {
        }
        
        public ReadByRecIdResponse(CourseHeaderWithRef_WebService.courseHeaderWithRef courseHeaderWithRef)
        {
            this.courseHeaderWithRef = courseHeaderWithRef;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", IsWrapped=true)]
    public partial class ReadMultipleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public CourseHeaderWithRef_WebService.courseHeaderWithRef_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=2)]
        public int setSize;
        
        public ReadMultipleRequest()
        {
        }
        
        public ReadMultipleRequest(CourseHeaderWithRef_WebService.courseHeaderWithRef_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", IsWrapped=true)]
    public partial class ReadMultipleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public CourseHeaderWithRef_WebService.courseHeaderWithRef[] ReadMultiple_Result;
        
        public ReadMultipleResponse()
        {
        }
        
        public ReadMultipleResponse(CourseHeaderWithRef_WebService.courseHeaderWithRef[] ReadMultiple_Result)
        {
            this.ReadMultiple_Result = ReadMultiple_Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", IsWrapped=true)]
    public partial class IsUpdatedRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", IsWrapped=true)]
    public partial class IsUpdatedResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", IsWrapped=true)]
    public partial class GetRecIdFromKeyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", IsWrapped=true)]
    public partial class GetRecIdFromKeyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/courseheaderwithref", Order=0)]
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
    public interface courseHeaderWithRef_ServiceChannel : CourseHeaderWithRef_WebService.courseHeaderWithRef_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class courseHeaderWithRef_ServiceClient : System.ServiceModel.ClientBase<CourseHeaderWithRef_WebService.courseHeaderWithRef_Service>, CourseHeaderWithRef_WebService.courseHeaderWithRef_Service
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public courseHeaderWithRef_ServiceClient() : 
                base(courseHeaderWithRef_ServiceClient.GetDefaultBinding(), courseHeaderWithRef_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.courseHeaderWithRef_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public courseHeaderWithRef_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(courseHeaderWithRef_ServiceClient.GetBindingForEndpoint(endpointConfiguration), courseHeaderWithRef_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public courseHeaderWithRef_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(courseHeaderWithRef_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public courseHeaderWithRef_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(courseHeaderWithRef_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public courseHeaderWithRef_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.ReadResponse> CourseHeaderWithRef_WebService.courseHeaderWithRef_Service.ReadAsync(CourseHeaderWithRef_WebService.ReadRequest request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.ReadResponse> ReadAsync(string No)
        {
            CourseHeaderWithRef_WebService.ReadRequest inValue = new CourseHeaderWithRef_WebService.ReadRequest();
            inValue.No = No;
            return ((CourseHeaderWithRef_WebService.courseHeaderWithRef_Service)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.ReadByRecIdResponse> CourseHeaderWithRef_WebService.courseHeaderWithRef_Service.ReadByRecIdAsync(CourseHeaderWithRef_WebService.ReadByRecIdRequest request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.ReadByRecIdResponse> ReadByRecIdAsync(string recId)
        {
            CourseHeaderWithRef_WebService.ReadByRecIdRequest inValue = new CourseHeaderWithRef_WebService.ReadByRecIdRequest();
            inValue.recId = recId;
            return ((CourseHeaderWithRef_WebService.courseHeaderWithRef_Service)(this)).ReadByRecIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.ReadMultipleResponse> CourseHeaderWithRef_WebService.courseHeaderWithRef_Service.ReadMultipleAsync(CourseHeaderWithRef_WebService.ReadMultipleRequest request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.ReadMultipleResponse> ReadMultipleAsync(CourseHeaderWithRef_WebService.courseHeaderWithRef_Filter[] filter, string bookmarkKey, int setSize)
        {
            CourseHeaderWithRef_WebService.ReadMultipleRequest inValue = new CourseHeaderWithRef_WebService.ReadMultipleRequest();
            inValue.filter = filter;
            inValue.bookmarkKey = bookmarkKey;
            inValue.setSize = setSize;
            return ((CourseHeaderWithRef_WebService.courseHeaderWithRef_Service)(this)).ReadMultipleAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.IsUpdatedResponse> CourseHeaderWithRef_WebService.courseHeaderWithRef_Service.IsUpdatedAsync(CourseHeaderWithRef_WebService.IsUpdatedRequest request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.IsUpdatedResponse> IsUpdatedAsync(string Key)
        {
            CourseHeaderWithRef_WebService.IsUpdatedRequest inValue = new CourseHeaderWithRef_WebService.IsUpdatedRequest();
            inValue.Key = Key;
            return ((CourseHeaderWithRef_WebService.courseHeaderWithRef_Service)(this)).IsUpdatedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.GetRecIdFromKeyResponse> CourseHeaderWithRef_WebService.courseHeaderWithRef_Service.GetRecIdFromKeyAsync(CourseHeaderWithRef_WebService.GetRecIdFromKeyRequest request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseHeaderWithRef_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(string Key)
        {
            CourseHeaderWithRef_WebService.GetRecIdFromKeyRequest inValue = new CourseHeaderWithRef_WebService.GetRecIdFromKeyRequest();
            inValue.Key = Key;
            return ((CourseHeaderWithRef_WebService.courseHeaderWithRef_Service)(this)).GetRecIdFromKeyAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.courseHeaderWithRef_Service))
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
            if ((endpointConfiguration == EndpointConfiguration.courseHeaderWithRef_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://iqiapimanagement-asa-test.azure-api.net/courseheaderwithref");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return courseHeaderWithRef_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.courseHeaderWithRef_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return courseHeaderWithRef_ServiceClient.GetEndpointAddress(EndpointConfiguration.courseHeaderWithRef_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            courseHeaderWithRef_Service,
        }
    }
}
