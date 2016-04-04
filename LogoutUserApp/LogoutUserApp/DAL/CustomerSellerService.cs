using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogoutUserApp.DAL
{
    public class CustomerSellerService
    {
        private static ServiceReference1.Service1Client customerSellerClient;

        CustomerSellerService()
        {
            customerSellerClient = new ServiceReference1.Service1Client();
        }

        public static ServiceReference1.Service1Client getService()
        {
            if (customerSellerClient == null)
            {
                customerSellerClient = new ServiceReference1.Service1Client();
            }

            return customerSellerClient;
        }
    }
}
