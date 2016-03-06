using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.Common
{
    public class LogInfo
    {
        public string Method { get; set; }
        public string Exception { get; set; }
        public string Result { get; set; }

        public override string ToString()
        {
            if(string.IsNullOrEmpty(Exception))
                return string.Format("Method:{0},Result:{1}", Method,Result);
            else
                return string.Format("Method:{0},Exception:{1}", Method, Exception);
        }
    }
}