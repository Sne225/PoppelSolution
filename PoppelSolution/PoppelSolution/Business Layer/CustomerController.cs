using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PoppelSolution.DatabaseLayer;
using PoppelSolution.Presentation_Layer;

namespace PoppelSolution.Business_Layer
{
    internal class CustomerController
    {
        #region Data Members
        private CustomerDB customerDB;
        private Collection<Customer> customers;
        #endregion

        #region Properties
        public Collection<Customer> AllCustomers
        {
            get { return customers; }
        }
        #endregion

        #region Constructor
        public CustomerController()
        {
            //***instantiate the CustomerDB object to communicate with the database
            customerDB = new CustomerDB();
            customers = customerDB.AllCustomers;
        }
        #endregion

        #region Database Communication
        public void DataMaintenance(Customer aCustomer, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            customerDB.DataSetModified(aCustomer, operation);//calling method to do the insert
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the customer to the Collection
                    customers.Add(aCustomer);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(aCustomer);
                    customers[index] = aCustomer;  // replace customer at this index with the updated customer
                    break;
                case DB.DBOperation.Delete:
                    customers.Remove(aCustomer);
                    break;

            }
        }

        public bool FinalizeChanges()
        {
            //***call the CustomerDB method that will commit the changes to the database
            return customerDB.UpdateDataSource();

        }
        #endregion

        #region Search Object

        //using a Boolean Expression to initialise found
        public int FindIndex(Customer aCustomer)
        {
            int counter = 0;
            bool found = false;
            found = (aCustomer.ID == customers[counter].ID);  
            while (!(found) & counter < customers.Count - 1)
            {
                counter += 1;
                found = (aCustomer.ID == customers[counter].ID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion
    }
}
