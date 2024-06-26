﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CollegeDekhoClient.CourseReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Course", Namespace="http://schemas.datacontract.org/2004/07/CollegeDekhoService")]
    [System.SerializableAttribute()]
    public partial class Course : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SC_closing_rank_GujcatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SC_closing_rank_JeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SC_opening_rank_GujcatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SC_opening_rank_JeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ST_closing_rank_GujcatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ST_closing_rank_JeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ST_opening_rank_GujcatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ST_opening_rank_JeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int closing_home_state_rankField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int college_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string degreeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string durationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal feesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int general_closing_rank_GujcatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int general_closing_rank_JeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int general_opening_rank_GujcatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int general_opening_rank_JeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int general_seatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal median_salaryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int obc_closing_rank_GujcatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int obc_closing_rank_JeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int obc_opening_rank_GujcatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int obc_opening_rank_JeeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int obc_seatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int opening_home_state_rankField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal placement_rateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ratingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int sc_seatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int st_seatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int total_available_seatsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string typeField;
        
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
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SC_closing_rank_Gujcat {
            get {
                return this.SC_closing_rank_GujcatField;
            }
            set {
                if ((this.SC_closing_rank_GujcatField.Equals(value) != true)) {
                    this.SC_closing_rank_GujcatField = value;
                    this.RaisePropertyChanged("SC_closing_rank_Gujcat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SC_closing_rank_Jee {
            get {
                return this.SC_closing_rank_JeeField;
            }
            set {
                if ((this.SC_closing_rank_JeeField.Equals(value) != true)) {
                    this.SC_closing_rank_JeeField = value;
                    this.RaisePropertyChanged("SC_closing_rank_Jee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SC_opening_rank_Gujcat {
            get {
                return this.SC_opening_rank_GujcatField;
            }
            set {
                if ((this.SC_opening_rank_GujcatField.Equals(value) != true)) {
                    this.SC_opening_rank_GujcatField = value;
                    this.RaisePropertyChanged("SC_opening_rank_Gujcat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SC_opening_rank_Jee {
            get {
                return this.SC_opening_rank_JeeField;
            }
            set {
                if ((this.SC_opening_rank_JeeField.Equals(value) != true)) {
                    this.SC_opening_rank_JeeField = value;
                    this.RaisePropertyChanged("SC_opening_rank_Jee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ST_closing_rank_Gujcat {
            get {
                return this.ST_closing_rank_GujcatField;
            }
            set {
                if ((this.ST_closing_rank_GujcatField.Equals(value) != true)) {
                    this.ST_closing_rank_GujcatField = value;
                    this.RaisePropertyChanged("ST_closing_rank_Gujcat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ST_closing_rank_Jee {
            get {
                return this.ST_closing_rank_JeeField;
            }
            set {
                if ((this.ST_closing_rank_JeeField.Equals(value) != true)) {
                    this.ST_closing_rank_JeeField = value;
                    this.RaisePropertyChanged("ST_closing_rank_Jee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ST_opening_rank_Gujcat {
            get {
                return this.ST_opening_rank_GujcatField;
            }
            set {
                if ((this.ST_opening_rank_GujcatField.Equals(value) != true)) {
                    this.ST_opening_rank_GujcatField = value;
                    this.RaisePropertyChanged("ST_opening_rank_Gujcat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ST_opening_rank_Jee {
            get {
                return this.ST_opening_rank_JeeField;
            }
            set {
                if ((this.ST_opening_rank_JeeField.Equals(value) != true)) {
                    this.ST_opening_rank_JeeField = value;
                    this.RaisePropertyChanged("ST_opening_rank_Jee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int closing_home_state_rank {
            get {
                return this.closing_home_state_rankField;
            }
            set {
                if ((this.closing_home_state_rankField.Equals(value) != true)) {
                    this.closing_home_state_rankField = value;
                    this.RaisePropertyChanged("closing_home_state_rank");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int college_id {
            get {
                return this.college_idField;
            }
            set {
                if ((this.college_idField.Equals(value) != true)) {
                    this.college_idField = value;
                    this.RaisePropertyChanged("college_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string degree {
            get {
                return this.degreeField;
            }
            set {
                if ((object.ReferenceEquals(this.degreeField, value) != true)) {
                    this.degreeField = value;
                    this.RaisePropertyChanged("degree");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.descriptionField, value) != true)) {
                    this.descriptionField = value;
                    this.RaisePropertyChanged("description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string duration {
            get {
                return this.durationField;
            }
            set {
                if ((object.ReferenceEquals(this.durationField, value) != true)) {
                    this.durationField = value;
                    this.RaisePropertyChanged("duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal fees {
            get {
                return this.feesField;
            }
            set {
                if ((this.feesField.Equals(value) != true)) {
                    this.feesField = value;
                    this.RaisePropertyChanged("fees");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int general_closing_rank_Gujcat {
            get {
                return this.general_closing_rank_GujcatField;
            }
            set {
                if ((this.general_closing_rank_GujcatField.Equals(value) != true)) {
                    this.general_closing_rank_GujcatField = value;
                    this.RaisePropertyChanged("general_closing_rank_Gujcat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int general_closing_rank_Jee {
            get {
                return this.general_closing_rank_JeeField;
            }
            set {
                if ((this.general_closing_rank_JeeField.Equals(value) != true)) {
                    this.general_closing_rank_JeeField = value;
                    this.RaisePropertyChanged("general_closing_rank_Jee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int general_opening_rank_Gujcat {
            get {
                return this.general_opening_rank_GujcatField;
            }
            set {
                if ((this.general_opening_rank_GujcatField.Equals(value) != true)) {
                    this.general_opening_rank_GujcatField = value;
                    this.RaisePropertyChanged("general_opening_rank_Gujcat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int general_opening_rank_Jee {
            get {
                return this.general_opening_rank_JeeField;
            }
            set {
                if ((this.general_opening_rank_JeeField.Equals(value) != true)) {
                    this.general_opening_rank_JeeField = value;
                    this.RaisePropertyChanged("general_opening_rank_Jee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int general_seat {
            get {
                return this.general_seatField;
            }
            set {
                if ((this.general_seatField.Equals(value) != true)) {
                    this.general_seatField = value;
                    this.RaisePropertyChanged("general_seat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal median_salary {
            get {
                return this.median_salaryField;
            }
            set {
                if ((this.median_salaryField.Equals(value) != true)) {
                    this.median_salaryField = value;
                    this.RaisePropertyChanged("median_salary");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int obc_closing_rank_Gujcat {
            get {
                return this.obc_closing_rank_GujcatField;
            }
            set {
                if ((this.obc_closing_rank_GujcatField.Equals(value) != true)) {
                    this.obc_closing_rank_GujcatField = value;
                    this.RaisePropertyChanged("obc_closing_rank_Gujcat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int obc_closing_rank_Jee {
            get {
                return this.obc_closing_rank_JeeField;
            }
            set {
                if ((this.obc_closing_rank_JeeField.Equals(value) != true)) {
                    this.obc_closing_rank_JeeField = value;
                    this.RaisePropertyChanged("obc_closing_rank_Jee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int obc_opening_rank_Gujcat {
            get {
                return this.obc_opening_rank_GujcatField;
            }
            set {
                if ((this.obc_opening_rank_GujcatField.Equals(value) != true)) {
                    this.obc_opening_rank_GujcatField = value;
                    this.RaisePropertyChanged("obc_opening_rank_Gujcat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int obc_opening_rank_Jee {
            get {
                return this.obc_opening_rank_JeeField;
            }
            set {
                if ((this.obc_opening_rank_JeeField.Equals(value) != true)) {
                    this.obc_opening_rank_JeeField = value;
                    this.RaisePropertyChanged("obc_opening_rank_Jee");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int obc_seat {
            get {
                return this.obc_seatField;
            }
            set {
                if ((this.obc_seatField.Equals(value) != true)) {
                    this.obc_seatField = value;
                    this.RaisePropertyChanged("obc_seat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int opening_home_state_rank {
            get {
                return this.opening_home_state_rankField;
            }
            set {
                if ((this.opening_home_state_rankField.Equals(value) != true)) {
                    this.opening_home_state_rankField = value;
                    this.RaisePropertyChanged("opening_home_state_rank");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal placement_rate {
            get {
                return this.placement_rateField;
            }
            set {
                if ((this.placement_rateField.Equals(value) != true)) {
                    this.placement_rateField = value;
                    this.RaisePropertyChanged("placement_rate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal rating {
            get {
                return this.ratingField;
            }
            set {
                if ((this.ratingField.Equals(value) != true)) {
                    this.ratingField = value;
                    this.RaisePropertyChanged("rating");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int sc_seat {
            get {
                return this.sc_seatField;
            }
            set {
                if ((this.sc_seatField.Equals(value) != true)) {
                    this.sc_seatField = value;
                    this.RaisePropertyChanged("sc_seat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int st_seat {
            get {
                return this.st_seatField;
            }
            set {
                if ((this.st_seatField.Equals(value) != true)) {
                    this.st_seatField = value;
                    this.RaisePropertyChanged("st_seat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int total_available_seats {
            get {
                return this.total_available_seatsField;
            }
            set {
                if ((this.total_available_seatsField.Equals(value) != true)) {
                    this.total_available_seatsField = value;
                    this.RaisePropertyChanged("total_available_seats");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string type {
            get {
                return this.typeField;
            }
            set {
                if ((object.ReferenceEquals(this.typeField, value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CourseReference.ICourseService")]
    public interface ICourseService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetCourseById", ReplyAction="http://tempuri.org/ICourseService/GetCourseByIdResponse")]
        CollegeDekhoClient.CourseReference.Course GetCourseById(int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetCourseById", ReplyAction="http://tempuri.org/ICourseService/GetCourseByIdResponse")]
        System.Threading.Tasks.Task<CollegeDekhoClient.CourseReference.Course> GetCourseByIdAsync(int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/AddCourse", ReplyAction="http://tempuri.org/ICourseService/AddCourseResponse")]
        void AddCourse(CollegeDekhoClient.CourseReference.Course course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/AddCourse", ReplyAction="http://tempuri.org/ICourseService/AddCourseResponse")]
        System.Threading.Tasks.Task AddCourseAsync(CollegeDekhoClient.CourseReference.Course course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/UpdateCourse", ReplyAction="http://tempuri.org/ICourseService/UpdateCourseResponse")]
        void UpdateCourse(CollegeDekhoClient.CourseReference.Course course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/UpdateCourse", ReplyAction="http://tempuri.org/ICourseService/UpdateCourseResponse")]
        System.Threading.Tasks.Task UpdateCourseAsync(CollegeDekhoClient.CourseReference.Course course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/DeleteCourse", ReplyAction="http://tempuri.org/ICourseService/DeleteCourseResponse")]
        void DeleteCourse(int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/DeleteCourse", ReplyAction="http://tempuri.org/ICourseService/DeleteCourseResponse")]
        System.Threading.Tasks.Task DeleteCourseAsync(int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetCoursesByCollegeId", ReplyAction="http://tempuri.org/ICourseService/GetCoursesByCollegeIdResponse")]
        CollegeDekhoClient.CourseReference.Course[] GetCoursesByCollegeId(int collegeId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICourseService/GetCoursesByCollegeId", ReplyAction="http://tempuri.org/ICourseService/GetCoursesByCollegeIdResponse")]
        System.Threading.Tasks.Task<CollegeDekhoClient.CourseReference.Course[]> GetCoursesByCollegeIdAsync(int collegeId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICourseServiceChannel : CollegeDekhoClient.CourseReference.ICourseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CourseServiceClient : System.ServiceModel.ClientBase<CollegeDekhoClient.CourseReference.ICourseService>, CollegeDekhoClient.CourseReference.ICourseService {
        
        public CourseServiceClient() {
        }
        
        public CourseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CourseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CourseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CollegeDekhoClient.CourseReference.Course GetCourseById(int courseId) {
            return base.Channel.GetCourseById(courseId);
        }
        
        public System.Threading.Tasks.Task<CollegeDekhoClient.CourseReference.Course> GetCourseByIdAsync(int courseId) {
            return base.Channel.GetCourseByIdAsync(courseId);
        }
        
        public void AddCourse(CollegeDekhoClient.CourseReference.Course course) {
            base.Channel.AddCourse(course);
        }
        
        public System.Threading.Tasks.Task AddCourseAsync(CollegeDekhoClient.CourseReference.Course course) {
            return base.Channel.AddCourseAsync(course);
        }
        
        public void UpdateCourse(CollegeDekhoClient.CourseReference.Course course) {
            base.Channel.UpdateCourse(course);
        }
        
        public System.Threading.Tasks.Task UpdateCourseAsync(CollegeDekhoClient.CourseReference.Course course) {
            return base.Channel.UpdateCourseAsync(course);
        }
        
        public void DeleteCourse(int courseId) {
            base.Channel.DeleteCourse(courseId);
        }
        
        public System.Threading.Tasks.Task DeleteCourseAsync(int courseId) {
            return base.Channel.DeleteCourseAsync(courseId);
        }
        
        public CollegeDekhoClient.CourseReference.Course[] GetCoursesByCollegeId(int collegeId) {
            return base.Channel.GetCoursesByCollegeId(collegeId);
        }
        
        public System.Threading.Tasks.Task<CollegeDekhoClient.CourseReference.Course[]> GetCoursesByCollegeIdAsync(int collegeId) {
            return base.Channel.GetCoursesByCollegeIdAsync(collegeId);
        }
    }
}
