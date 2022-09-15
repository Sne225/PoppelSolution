using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSolution.Business_Layer
{
    internal class Products
    {
        #region Data Members
        int orderID;
        string name;
        #endregion

        #region Properties
        public int OrderID
        {
            get { return orderID; }
            set { orderID = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion
    }
}
