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

        public string Request { get; set; }
        public override string ToString()
        {
            if(string.IsNullOrEmpty(Exception))
                return string.Format("Request:{0},Method:{1},Result:{2}", string.IsNullOrEmpty(Request)? string.Empty:Request,
                                                                          string.IsNullOrEmpty(Method)?  string.Empty:Method,
                                                                          string.IsNullOrEmpty(Result) ? string.Empty : Result);
            else
                return string.Format("Request:{0},Method:{1},Exception:{2}", string.IsNullOrEmpty(Request)? string.Empty:Request,
                                                                             string.IsNullOrEmpty(Method) ? string.Empty:Method,
                                                                             string.IsNullOrEmpty(Exception) ? string.Empty:Exception);
        }
    }
}