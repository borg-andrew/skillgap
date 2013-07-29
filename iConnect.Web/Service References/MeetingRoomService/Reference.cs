﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iConnect.Presentation.MeetingRoomService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MeetingRoomEntity", Namespace="http://schemas.datacontract.org/2004/07/iConnect.Entities")]
    [System.SerializableAttribute()]
    public partial class MeetingRoomEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExtensionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RoomNameField;
        
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
        public string Extension {
            get {
                return this.ExtensionField;
            }
            set {
                if ((object.ReferenceEquals(this.ExtensionField, value) != true)) {
                    this.ExtensionField = value;
                    this.RaisePropertyChanged("Extension");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomId {
            get {
                return this.RoomIdField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomIdField, value) != true)) {
                    this.RoomIdField = value;
                    this.RaisePropertyChanged("RoomId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RoomName {
            get {
                return this.RoomNameField;
            }
            set {
                if ((object.ReferenceEquals(this.RoomNameField, value) != true)) {
                    this.RoomNameField = value;
                    this.RaisePropertyChanged("RoomName");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MeetingRoomService.IMeetingRoom")]
    public interface IMeetingRoom {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMeetingRoom/SearchMeetingRoom", ReplyAction="http://tempuri.org/IMeetingRoom/SearchMeetingRoomResponse")]
        iConnect.Presentation.MeetingRoomService.MeetingRoomEntity[] SearchMeetingRoom(string searchText);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMeetingRoomChannel : iConnect.Presentation.MeetingRoomService.IMeetingRoom, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MeetingRoomClient : System.ServiceModel.ClientBase<iConnect.Presentation.MeetingRoomService.IMeetingRoom>, iConnect.Presentation.MeetingRoomService.IMeetingRoom {
        
        public MeetingRoomClient() {
        }
        
        public MeetingRoomClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MeetingRoomClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MeetingRoomClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MeetingRoomClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public iConnect.Presentation.MeetingRoomService.MeetingRoomEntity[] SearchMeetingRoom(string searchText) {
            return base.Channel.SearchMeetingRoom(searchText);
        }
    }
}