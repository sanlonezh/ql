﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace ECommerce.Entity.Common
{
    /// <summary>
    /// 系统Log
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApplicationEventLog : EntityBase
    {
        [DataMember]
        public string Source { get; set; }
        [DataMember]
        public string Category { get; set; }
        [DataMember]
        public string SubCategory { get; set; }
        [DataMember]
        public string ReferenceIP { get; set; }
        [DataMember]
        public int EventType { get; set; }
        [DataMember]
        public string EventTypeName { get; set; }
        [DataMember]
        public string HostName { get; set; }
        [DataMember]
        public string EventTitle { get; set; }
        [DataMember]
        public string EventMessage { get; set; }
        [DataMember]
        public string EventStackTrace { get; set; }
        [DataMember]
        public string EventDetail { get; set; }
    }
}
