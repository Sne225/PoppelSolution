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
    internal class orderController
    {
        #region Data Member
        private OrdersDB orderDb;
        private Collection<Order> orders;
        #endregion

        #region Property
        public Collection<Order> AllOrders
        {
            get { return orders; }
        }
        #endregion

        #region Constructor
        public orderController()
        {
            //***instantiate the orderDB object to communicate with the database
            orderDb = new OrdersDB();
            orders = orderDb.AllOrders;
        }
        #endregion

        #region Add Orders to DB - DB Communication
        public void DataMaintenance(Order aOrder)
        {
            //*** Add the order to the Collection
            orders.Add(aOrder);
        }
        public bool FinalizeChanges()
        {
            //***call the CustomerDB method that will commit the changes to the database
            return orderDb.UpdateDataSource();

        }
        #endregion
    }
}
