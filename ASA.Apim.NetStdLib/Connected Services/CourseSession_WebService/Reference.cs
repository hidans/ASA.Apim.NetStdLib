﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseSession_WebService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", ConfigurationName="CourseSession_WebService.CourseSession_Service")]
    public interface CourseSession_Service
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/coursesession:GetRecIdFromKey", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseSession_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(CourseSession_WebService.GetRecIdFromKeyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/coursesession:IsUpdated", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseSession_WebService.IsUpdatedResponse> IsUpdatedAsync(CourseSession_WebService.IsUpdatedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/coursesession:Read", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseSession_WebService.ReadResponse> ReadAsync(CourseSession_WebService.ReadRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/coursesession:ReadByRecId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseSession_WebService.ReadByRecIdResponse> ReadByRecIdAsync(CourseSession_WebService.ReadByRecIdRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:microsoft-dynamics-schemas/page/coursesession:ReadMultiple", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<CourseSession_WebService.ReadMultipleResponse> ReadMultipleAsync(CourseSession_WebService.ReadMultipleRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursesession", IsWrapped=true)]
    public partial class GetRecIdFromKeyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="GetRecIdFromKey_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursesession", IsWrapped=true)]
    public partial class GetRecIdFromKeyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursesession", IsWrapped=true)]
    public partial class IsUpdatedRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="IsUpdated_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursesession", IsWrapped=true)]
    public partial class IsUpdatedResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=0)]
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession")]
    public partial class CourseSession
    {
        
        private string keyField;
        
        private int entry_NoField;
        
        private bool entry_NoFieldSpecified;
        
        private System.DateTime dateField;
        
        private bool dateFieldSpecified;
        
        private System.DateTime from_TimeField;
        
        private bool from_TimeFieldSpecified;
        
        private System.DateTime to_TimeField;
        
        private bool to_TimeFieldSpecified;
        
        private string course_Header_NoField;
        
        private string course_Location_NoField;
        
        private string class_Room_NoField;
        
        private string course_Header_Type_NoField;
        
        private Week_Day week_DayField;
        
        private bool week_DayFieldSpecified;
        
        private string descriptionField;
        
        private decimal noField;
        
        private bool noFieldSpecified;
        
        private int week_NoField;
        
        private bool week_NoFieldSpecified;
        
        private decimal qty_LessonsField;
        
        private bool qty_LessonsFieldSpecified;
        
        private Cancelled cancelledField;
        
        private bool cancelledFieldSpecified;
        
        private string course_Location_NameField;
        
        private string class_Room_NameField;
        
        private int booked_TeachersField;
        
        private bool booked_TeachersFieldSpecified;
        
        private string course_Header_DescriptionField;
        
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
        public int Entry_No
        {
            get
            {
                return this.entry_NoField;
            }
            set
            {
                this.entry_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Entry_NoSpecified
        {
            get
            {
                return this.entry_NoFieldSpecified;
            }
            set
            {
                this.entry_NoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date", Order=2)]
        public System.DateTime Date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DateSpecified
        {
            get
            {
                return this.dateFieldSpecified;
            }
            set
            {
                this.dateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Course_Header_Type_No
        {
            get
            {
                return this.course_Header_Type_NoField;
            }
            set
            {
                this.course_Header_Type_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public Week_Day Week_Day
        {
            get
            {
                return this.week_DayField;
            }
            set
            {
                this.week_DayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Week_DaySpecified
        {
            get
            {
                return this.week_DayFieldSpecified;
            }
            set
            {
                this.week_DayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public decimal No
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NoSpecified
        {
            get
            {
                return this.noFieldSpecified;
            }
            set
            {
                this.noFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int Week_No
        {
            get
            {
                return this.week_NoField;
            }
            set
            {
                this.week_NoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Week_NoSpecified
        {
            get
            {
                return this.week_NoFieldSpecified;
            }
            set
            {
                this.week_NoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public decimal Qty_Lessons
        {
            get
            {
                return this.qty_LessonsField;
            }
            set
            {
                this.qty_LessonsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Qty_LessonsSpecified
        {
            get
            {
                return this.qty_LessonsFieldSpecified;
            }
            set
            {
                this.qty_LessonsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public Cancelled Cancelled
        {
            get
            {
                return this.cancelledField;
            }
            set
            {
                this.cancelledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CancelledSpecified
        {
            get
            {
                return this.cancelledFieldSpecified;
            }
            set
            {
                this.cancelledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string Course_Location_Name
        {
            get
            {
                return this.course_Location_NameField;
            }
            set
            {
                this.course_Location_NameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string Class_Room_Name
        {
            get
            {
                return this.class_Room_NameField;
            }
            set
            {
                this.class_Room_NameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public int Booked_Teachers
        {
            get
            {
                return this.booked_TeachersField;
            }
            set
            {
                this.booked_TeachersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool Booked_TeachersSpecified
        {
            get
            {
                return this.booked_TeachersFieldSpecified;
            }
            set
            {
                this.booked_TeachersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string Course_Header_Description
        {
            get
            {
                return this.course_Header_DescriptionField;
            }
            set
            {
                this.course_Header_DescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession")]
    public enum Week_Day
    {
        
        /// <remarks/>
        Monday,
        
        /// <remarks/>
        Thuesday,
        
        /// <remarks/>
        Wednesday,
        
        /// <remarks/>
        Thursday,
        
        /// <remarks/>
        Friday,
        
        /// <remarks/>
        Saturday,
        
        /// <remarks/>
        Sunday,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession")]
    public enum Cancelled
    {
        
        /// <remarks/>
        _blank_,
        
        /// <remarks/>
        Cancelled,
        
        /// <remarks/>
        Moved,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession")]
    public partial class CourseSession_Filter
    {
        
        private CourseSession_Fields fieldField;
        
        private string criteriaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public CourseSession_Fields Field
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession")]
    public enum CourseSession_Fields
    {
        
        /// <remarks/>
        Entry_No,
        
        /// <remarks/>
        Date,
        
        /// <remarks/>
        From_Time,
        
        /// <remarks/>
        To_Time,
        
        /// <remarks/>
        Course_Header_No,
        
        /// <remarks/>
        Course_Location_No,
        
        /// <remarks/>
        Class_Room_No,
        
        /// <remarks/>
        Course_Header_Type_No,
        
        /// <remarks/>
        Week_Day,
        
        /// <remarks/>
        Description,
        
        /// <remarks/>
        No,
        
        /// <remarks/>
        Week_No,
        
        /// <remarks/>
        Qty_Lessons,
        
        /// <remarks/>
        Cancelled,
        
        /// <remarks/>
        Course_Location_Name,
        
        /// <remarks/>
        Class_Room_Name,
        
        /// <remarks/>
        Booked_Teachers,
        
        /// <remarks/>
        Course_Header_Description,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursesession", IsWrapped=true)]
    public partial class ReadRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=0)]
        public string Course_Header_No;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime Date;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=2)]
        public int Entry_No;
        
        public ReadRequest()
        {
        }
        
        public ReadRequest(string Course_Header_No, System.DateTime Date, int Entry_No)
        {
            this.Course_Header_No = Course_Header_No;
            this.Date = Date;
            this.Entry_No = Entry_No;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Read_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursesession", IsWrapped=true)]
    public partial class ReadResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=0)]
        public CourseSession_WebService.CourseSession CourseSession;
        
        public ReadResponse()
        {
        }
        
        public ReadResponse(CourseSession_WebService.CourseSession CourseSession)
        {
            this.CourseSession = CourseSession;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursesession", IsWrapped=true)]
    public partial class ReadByRecIdRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=0)]
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
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadByRecId_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursesession", IsWrapped=true)]
    public partial class ReadByRecIdResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=0)]
        public CourseSession_WebService.CourseSession CourseSession;
        
        public ReadByRecIdResponse()
        {
        }
        
        public ReadByRecIdResponse(CourseSession_WebService.CourseSession CourseSession)
        {
            this.CourseSession = CourseSession;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursesession", IsWrapped=true)]
    public partial class ReadMultipleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("filter")]
        public CourseSession_WebService.CourseSession_Filter[] filter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=1)]
        public string bookmarkKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=2)]
        public int setSize;
        
        public ReadMultipleRequest()
        {
        }
        
        public ReadMultipleRequest(CourseSession_WebService.CourseSession_Filter[] filter, string bookmarkKey, int setSize)
        {
            this.filter = filter;
            this.bookmarkKey = bookmarkKey;
            this.setSize = setSize;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReadMultiple_Result", WrapperNamespace="urn:microsoft-dynamics-schemas/page/coursesession", IsWrapped=true)]
    public partial class ReadMultipleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:microsoft-dynamics-schemas/page/coursesession", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public CourseSession_WebService.CourseSession[] ReadMultiple_Result;
        
        public ReadMultipleResponse()
        {
        }
        
        public ReadMultipleResponse(CourseSession_WebService.CourseSession[] ReadMultiple_Result)
        {
            this.ReadMultiple_Result = ReadMultiple_Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface CourseSession_ServiceChannel : CourseSession_WebService.CourseSession_Service, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class CourseSession_ServiceClient : System.ServiceModel.ClientBase<CourseSession_WebService.CourseSession_Service>, CourseSession_WebService.CourseSession_Service
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CourseSession_ServiceClient() : 
                base(CourseSession_ServiceClient.GetDefaultBinding(), CourseSession_ServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.CourseSession_Service.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseSession_ServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(CourseSession_ServiceClient.GetBindingForEndpoint(endpointConfiguration), CourseSession_ServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseSession_ServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CourseSession_ServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseSession_ServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CourseSession_ServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CourseSession_ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseSession_WebService.GetRecIdFromKeyResponse> CourseSession_WebService.CourseSession_Service.GetRecIdFromKeyAsync(CourseSession_WebService.GetRecIdFromKeyRequest request)
        {
            return base.Channel.GetRecIdFromKeyAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseSession_WebService.GetRecIdFromKeyResponse> GetRecIdFromKeyAsync(string Key)
        {
            CourseSession_WebService.GetRecIdFromKeyRequest inValue = new CourseSession_WebService.GetRecIdFromKeyRequest();
            inValue.Key = Key;
            return ((CourseSession_WebService.CourseSession_Service)(this)).GetRecIdFromKeyAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseSession_WebService.IsUpdatedResponse> CourseSession_WebService.CourseSession_Service.IsUpdatedAsync(CourseSession_WebService.IsUpdatedRequest request)
        {
            return base.Channel.IsUpdatedAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseSession_WebService.IsUpdatedResponse> IsUpdatedAsync(string Key)
        {
            CourseSession_WebService.IsUpdatedRequest inValue = new CourseSession_WebService.IsUpdatedRequest();
            inValue.Key = Key;
            return ((CourseSession_WebService.CourseSession_Service)(this)).IsUpdatedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseSession_WebService.ReadResponse> CourseSession_WebService.CourseSession_Service.ReadAsync(CourseSession_WebService.ReadRequest request)
        {
            return base.Channel.ReadAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseSession_WebService.ReadResponse> ReadAsync(string Course_Header_No, System.DateTime Date, int Entry_No)
        {
            CourseSession_WebService.ReadRequest inValue = new CourseSession_WebService.ReadRequest();
            inValue.Course_Header_No = Course_Header_No;
            inValue.Date = Date;
            inValue.Entry_No = Entry_No;
            return ((CourseSession_WebService.CourseSession_Service)(this)).ReadAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseSession_WebService.ReadByRecIdResponse> CourseSession_WebService.CourseSession_Service.ReadByRecIdAsync(CourseSession_WebService.ReadByRecIdRequest request)
        {
            return base.Channel.ReadByRecIdAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseSession_WebService.ReadByRecIdResponse> ReadByRecIdAsync(string recId)
        {
            CourseSession_WebService.ReadByRecIdRequest inValue = new CourseSession_WebService.ReadByRecIdRequest();
            inValue.recId = recId;
            return ((CourseSession_WebService.CourseSession_Service)(this)).ReadByRecIdAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CourseSession_WebService.ReadMultipleResponse> CourseSession_WebService.CourseSession_Service.ReadMultipleAsync(CourseSession_WebService.ReadMultipleRequest request)
        {
            return base.Channel.ReadMultipleAsync(request);
        }
        
        public System.Threading.Tasks.Task<CourseSession_WebService.ReadMultipleResponse> ReadMultipleAsync(CourseSession_WebService.CourseSession_Filter[] filter, string bookmarkKey, int setSize)
        {
            CourseSession_WebService.ReadMultipleRequest inValue = new CourseSession_WebService.ReadMultipleRequest();
            inValue.filter = filter;
            inValue.bookmarkKey = bookmarkKey;
            inValue.setSize = setSize;
            return ((CourseSession_WebService.CourseSession_Service)(this)).ReadMultipleAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.CourseSession_Service))
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
            if ((endpointConfiguration == EndpointConfiguration.CourseSession_Service))
            {
                return new System.ServiceModel.EndpointAddress("https://iqiapimanagement-asa-dev.azure-api.net/coursesession");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CourseSession_ServiceClient.GetBindingForEndpoint(EndpointConfiguration.CourseSession_Service);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CourseSession_ServiceClient.GetEndpointAddress(EndpointConfiguration.CourseSession_Service);
        }
        
        public enum EndpointConfiguration
        {
            
            CourseSession_Service,
        }
    }
}
