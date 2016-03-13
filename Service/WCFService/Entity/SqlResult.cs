using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.Entity
{
    public class SqlResult
    {
        public FlagType flag;    //执行数据库结果的标志位，成功失败
        public string message;  //执行数据库结果的明细

        public SqlResult()
        {

        }

        public SqlResult(int _flag, string _message)
        {
            flag = (FlagType)_flag;
            message = _message;
        }
    }
}