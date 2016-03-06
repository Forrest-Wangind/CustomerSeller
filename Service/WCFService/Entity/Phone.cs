using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.Entity
{
    public class PhoneRequest
    {
        public String action { get; set; }
        public int companyid { get; set; }
        public String auth { get; set; }
        public String exten { get; set; }
        public String staffid { get; set; }
        public String phonenum { get; set; }
        public String codeid_1 { get; set; }
        public String codeid_2 { get; set; }
    }
    public class PhoneResponse
    {
        public int Reault { get; set; }
    }
}