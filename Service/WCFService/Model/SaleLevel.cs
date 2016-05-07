using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WCFService.Entity;

namespace WCFService.Model
{
    [DataContract]
    public class SaleLevel
    {
        [DataMember]
        public string levelID { get; set; }

        [DataMember]
        public string levelName { get; set; }

        [DataMember]
        public int AMaxNumber{ get; set; }

        [DataMember]
        public int ADailyNumber { get; set; }

        [DataMember]
        public string ARemark { get; set; }

        [DataMember]
        public int BMaxNumber { get; set; }

        [DataMember]
        public int BDailyNumber { get; set; }

        [DataMember]
        public string BRemark { get; set; }

        [DataMember]
        public int CMaxNumber { get; set; }

        [DataMember]
        public int CDailyNumber { get; set; }

        [DataMember]
        public string CRemark { get; set; }

        [DataMember]
        public string levelRemark { get; set; }
    }
}