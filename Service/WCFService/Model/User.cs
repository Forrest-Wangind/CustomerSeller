using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService.Model
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string userID { get; set; }

        [DataMember]
        public string userName { get; set; }

        [DataMember]
        public string password { get; set; }

        [DataMember]
        public string gender { get; set; }

        [DataMember]
        public string role { get; set; }

        [DataMember]
        public string exten { get; set; }

        [DataMember]
        public DateTime entryTimeStart { get; set; }

        [DataMember]
        public DateTime entryTimeEnd { get; set; }

        [DataMember]
        public List<string> permissions { get; set; }
    }
}