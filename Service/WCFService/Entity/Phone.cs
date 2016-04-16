using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WCFService.Entity
{
    public class Phone
    {
        public String type { get; set; }
        public int dailyCount { get; set; }
        public int totalCount { get; set; }

        public Phone(string phoneType)
        {
            this.type = phoneType;
        }

        public static Phone getDetail(string type)
        {
            Phone phone = new Phone(type);
            phone.dailyCount = int.Parse(ConfigurationManager.AppSettings[string.Format("{0}_DailyMaxCount", type)]);
            phone.totalCount = int.Parse(ConfigurationManager.AppSettings[string.Format("{0}_MaxCount", type)]);
            return phone;
        }
    }

    public class CallPhoneRequest
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


    public class HandupPhoneRequest
    {
        public String action { get; set; }
        public int companyid { get; set; }
        public String auth { get; set; }
        public String exten { get; set; }
       
    }


    public class Response<T>
    {
        public string errno { get; set; }
        public string message { get; set; }
        public T data { get; set; }
    }

}