using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CustomerSeller.Common
{
   public  class XmlHelper
    {
       public static string GetFirstNodeValue(string nodeName ,string xmlPath)
       {
           try
           {

               XElement rootNode = XElement.Load(xmlPath);
               IEnumerable<XElement> targetNodes = from target in rootNode.Descendants(nodeName)
                                                   select target ;
               return targetNodes.FirstOrDefault().Value;

           }
           catch
           {
               return string.Empty;
           }
       }


       public static bool SetNodeValue(string nodeName, string nodeValue,string xmlPath)
       {
           try
           {

               XElement rootNode = XElement.Load(xmlPath);
               IEnumerable<XElement> targetNodes = from target in rootNode.Descendants(nodeName)
                                                   select target;
               targetNodes.FirstOrDefault().SetValue(nodeValue);
               rootNode.Save(xmlPath);
               return true;
           }
           catch
           {
               return false;
           }
       }
    }
}
