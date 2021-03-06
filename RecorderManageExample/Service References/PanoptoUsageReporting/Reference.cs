﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RecordingManagementExample.PanoptoUsageReporting {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AuthenticationInfo", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    [System.SerializableAttribute()]
    public partial class AuthenticationInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserKeyField;
        
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
        public string AuthCode {
            get {
                return this.AuthCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthCodeField, value) != true)) {
                    this.AuthCodeField = value;
                    this.RaisePropertyChanged("AuthCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserKey {
            get {
                return this.UserKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.UserKeyField, value) != true)) {
                    this.UserKeyField = value;
                    this.RaisePropertyChanged("UserKey");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UsageGranularity", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    public enum UsageGranularity : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Hourly = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Daily = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Weekly = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SummaryUsageResponseItem", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    [System.SerializableAttribute()]
    public partial class SummaryUsageResponseItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double MinutesViewedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UniqueUsersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ViewsField;
        
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
        public double MinutesViewed {
            get {
                return this.MinutesViewedField;
            }
            set {
                if ((this.MinutesViewedField.Equals(value) != true)) {
                    this.MinutesViewedField = value;
                    this.RaisePropertyChanged("MinutesViewed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UniqueUsers {
            get {
                return this.UniqueUsersField;
            }
            set {
                if ((this.UniqueUsersField.Equals(value) != true)) {
                    this.UniqueUsersField = value;
                    this.RaisePropertyChanged("UniqueUsers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Views {
            get {
                return this.ViewsField;
            }
            set {
                if ((this.ViewsField.Equals(value) != true)) {
                    this.ViewsField = value;
                    this.RaisePropertyChanged("Views");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Pagination", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    [System.SerializableAttribute()]
    public partial class Pagination : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MaxNumberResultsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PageNumberField;
        
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
        public int MaxNumberResults {
            get {
                return this.MaxNumberResultsField;
            }
            set {
                if ((this.MaxNumberResultsField.Equals(value) != true)) {
                    this.MaxNumberResultsField = value;
                    this.RaisePropertyChanged("MaxNumberResults");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PageNumber {
            get {
                return this.PageNumberField;
            }
            set {
                if ((this.PageNumberField.Equals(value) != true)) {
                    this.PageNumberField = value;
                    this.RaisePropertyChanged("PageNumber");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetailedUsageResponse", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    [System.SerializableAttribute()]
    public partial class DetailedUsageResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponseItem[] PagedResponsesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalNumberResponsesField;
        
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
        public RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponseItem[] PagedResponses {
            get {
                return this.PagedResponsesField;
            }
            set {
                if ((object.ReferenceEquals(this.PagedResponsesField, value) != true)) {
                    this.PagedResponsesField = value;
                    this.RaisePropertyChanged("PagedResponses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalNumberResponses {
            get {
                return this.TotalNumberResponsesField;
            }
            set {
                if ((this.TotalNumberResponsesField.Equals(value) != true)) {
                    this.TotalNumberResponsesField = value;
                    this.RaisePropertyChanged("TotalNumberResponses");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DetailedUsageResponseItem", Namespace="http://schemas.datacontract.org/2004/07/Panopto.Server.Services.PublicAPI.V40")]
    [System.SerializableAttribute()]
    public partial class DetailedUsageResponseItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double SecondsViewedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid SessionIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double StartPositionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid UserIdField;
        
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
        public double SecondsViewed {
            get {
                return this.SecondsViewedField;
            }
            set {
                if ((this.SecondsViewedField.Equals(value) != true)) {
                    this.SecondsViewedField = value;
                    this.RaisePropertyChanged("SecondsViewed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid SessionId {
            get {
                return this.SessionIdField;
            }
            set {
                if ((this.SessionIdField.Equals(value) != true)) {
                    this.SessionIdField = value;
                    this.RaisePropertyChanged("SessionId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double StartPosition {
            get {
                return this.StartPositionField;
            }
            set {
                if ((this.StartPositionField.Equals(value) != true)) {
                    this.StartPositionField = value;
                    this.RaisePropertyChanged("StartPosition");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Time {
            get {
                return this.TimeField;
            }
            set {
                if ((this.TimeField.Equals(value) != true)) {
                    this.TimeField = value;
                    this.RaisePropertyChanged("Time");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid UserId {
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PanoptoUsageReporting.IUsageReporting")]
    public interface IUsageReporting {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetSystemSummaryUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetSystemSummaryUsageResponse")]
        RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[] GetSystemSummaryUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetSystemSummaryUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetSystemSummaryUsageResponse")]
        System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[]> GetSystemSummaryUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetFolderSummaryUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetFolderSummaryUsageResponse")]
        RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[] GetFolderSummaryUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid folderId, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetFolderSummaryUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetFolderSummaryUsageResponse")]
        System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[]> GetFolderSummaryUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid folderId, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetSessionSummaryUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetSessionSummaryUsageResponse")]
        RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[] GetSessionSummaryUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetSessionSummaryUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetSessionSummaryUsageResponse")]
        System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[]> GetSessionSummaryUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetSessionDetailedUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetSessionDetailedUsageResponse")]
        RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse GetSessionDetailedUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination, System.DateTime beginRange, System.DateTime endRange);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetSessionDetailedUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetSessionDetailedUsageResponse")]
        System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse> GetSessionDetailedUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination, System.DateTime beginRange, System.DateTime endRange);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetUserDetailedUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetUserDetailedUsageResponse")]
        RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse GetUserDetailedUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid userId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetUserDetailedUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetUserDetailedUsageResponse")]
        System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse> GetUserDetailedUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid userId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetSessionUserDetailedUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetSessionUserDetailedUsageResponse")]
        RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse GetSessionUserDetailedUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, System.Guid userId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsageReporting/GetSessionUserDetailedUsage", ReplyAction="http://tempuri.org/IUsageReporting/GetSessionUserDetailedUsageResponse")]
        System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse> GetSessionUserDetailedUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, System.Guid userId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsageReportingChannel : RecordingManagementExample.PanoptoUsageReporting.IUsageReporting, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsageReportingClient : System.ServiceModel.ClientBase<RecordingManagementExample.PanoptoUsageReporting.IUsageReporting>, RecordingManagementExample.PanoptoUsageReporting.IUsageReporting {
        
        public UsageReportingClient() {
        }
        
        public UsageReportingClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsageReportingClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsageReportingClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsageReportingClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[] GetSystemSummaryUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity) {
            return base.Channel.GetSystemSummaryUsage(auth, beginRange, endRange, granularity);
        }
        
        public System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[]> GetSystemSummaryUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity) {
            return base.Channel.GetSystemSummaryUsageAsync(auth, beginRange, endRange, granularity);
        }
        
        public RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[] GetFolderSummaryUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid folderId, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity) {
            return base.Channel.GetFolderSummaryUsage(auth, folderId, beginRange, endRange, granularity);
        }
        
        public System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[]> GetFolderSummaryUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid folderId, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity) {
            return base.Channel.GetFolderSummaryUsageAsync(auth, folderId, beginRange, endRange, granularity);
        }
        
        public RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[] GetSessionSummaryUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity) {
            return base.Channel.GetSessionSummaryUsage(auth, sessionId, beginRange, endRange, granularity);
        }
        
        public System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.SummaryUsageResponseItem[]> GetSessionSummaryUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, System.DateTime beginRange, System.DateTime endRange, RecordingManagementExample.PanoptoUsageReporting.UsageGranularity granularity) {
            return base.Channel.GetSessionSummaryUsageAsync(auth, sessionId, beginRange, endRange, granularity);
        }
        
        public RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse GetSessionDetailedUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination, System.DateTime beginRange, System.DateTime endRange) {
            return base.Channel.GetSessionDetailedUsage(auth, sessionId, pagination, beginRange, endRange);
        }
        
        public System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse> GetSessionDetailedUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination, System.DateTime beginRange, System.DateTime endRange) {
            return base.Channel.GetSessionDetailedUsageAsync(auth, sessionId, pagination, beginRange, endRange);
        }
        
        public RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse GetUserDetailedUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid userId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination) {
            return base.Channel.GetUserDetailedUsage(auth, userId, pagination);
        }
        
        public System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse> GetUserDetailedUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid userId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination) {
            return base.Channel.GetUserDetailedUsageAsync(auth, userId, pagination);
        }
        
        public RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse GetSessionUserDetailedUsage(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, System.Guid userId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination) {
            return base.Channel.GetSessionUserDetailedUsage(auth, sessionId, userId, pagination);
        }
        
        public System.Threading.Tasks.Task<RecordingManagementExample.PanoptoUsageReporting.DetailedUsageResponse> GetSessionUserDetailedUsageAsync(RecordingManagementExample.PanoptoUsageReporting.AuthenticationInfo auth, System.Guid sessionId, System.Guid userId, RecordingManagementExample.PanoptoUsageReporting.Pagination pagination) {
            return base.Channel.GetSessionUserDetailedUsageAsync(auth, sessionId, userId, pagination);
        }
    }
}
