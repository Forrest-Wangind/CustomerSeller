using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService.Model
{
    public class SaleGroup
    {
        [DataMember]
        public string groupID { get; set; }

        [DataMember]
        public string groupName { get; set; }
    }
}