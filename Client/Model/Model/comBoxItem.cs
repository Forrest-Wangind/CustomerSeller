using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomerSeller.Model
{
    class comBoxItem
    {
        private string key;

        private string value;

        public comBoxItem(string pkey, string pvalue)
        {
            this.key = pkey;
            this.value = pvalue;
        }

        public string pKey
        {
            get { return key; }
        }

        public string pValue
        {
            get { return value; }
        }
    }
}
