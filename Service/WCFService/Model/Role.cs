using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService.Model
{
    [DataContract]
    public class Role
    {
        [DataMember]
        public string roleID { get; set; }

        [DataMember]
        public string roleName { get; set; }

        [DataMember]
        public string roleRemark { get; set; }

        [DataMember]
        public List<string> functions { get; set; }
    }
}