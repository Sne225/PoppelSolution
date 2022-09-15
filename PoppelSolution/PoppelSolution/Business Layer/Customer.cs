using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelSolution.Business_Layer
{
    internal class Customer
    {
        #region Data Members

        private string Id, name, phone, email, address;

        #endregion

        #region Properties
        //encapsulation
        public string ID
        {
            get { return Id; }
            set { Id = value; } 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }


        #endregion

        #region Constructor
        public Customer()
        {
           
            name = "";
            phone = "";
            email = "";
            address = "";
        }
        #endregion
    }
}
