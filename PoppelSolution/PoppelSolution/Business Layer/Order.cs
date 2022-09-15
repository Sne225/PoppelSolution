using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSolution.Business_Layer
{
    internal class Order
    {
        #region Data Members
        private string orderID, customerId;
        private DateTime dateCreated;

        Customer customer;
        List<Products> products;
        #endregion

        #region Properties
        public string OrderID { get { return orderID; } set { orderID = value; } }
        public DateTime DateCreated { get { return dateCreated; } set { dateCreated = value; } }
        public string CustomerId { get { return customerId; } set { customerId = value; } }
        #endregion

    }
}
