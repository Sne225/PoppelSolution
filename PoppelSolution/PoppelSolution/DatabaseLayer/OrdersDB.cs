using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using PoppelSolution.Business_Layer;

namespace PoppelSolution.DatabaseLayer
{
    internal class OrdersDB : DB
    {
        #region Tables and Queries

        private string table1 = "Orders";
        private string sqlLocal1 = "SELECT * FROM Orders";
        private Collection<Order> Orders;

        #endregion


        #region Properties
        public Collection<Order> AllOrders
        {
            get { return Orders; }
        }

        #endregion

        #region Constructor
        public OrdersDB() : base()
        {
            Orders = new Collection<Order>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);
        }
        #endregion

        #region Utility Methods
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and a Customer object
            DataRow myRow = null;
            Order orders;


            foreach (DataRow rowVariable in dsMain.Tables[table].Rows)
            {
                myRow = rowVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Order object
                    orders = new Order();
                    orders.OrderID = Convert.ToString(myRow["OrderID"]).TrimEnd();
                    orders.DateCreated = Convert.ToDateTime(myRow["dateCreated"]);
                    orders.CustomerId = Convert.ToString(myRow["CustomerID"]).TrimEnd();
  ;

                    Orders.Add(orders);

                }

            }


        }
        private void FillRow(DataRow aRow, Order aOrder)
        {

            aRow["OrderID"] = aOrder.OrderID;
            aRow["dateCreated"] = aOrder.DateCreated;  //NOTE square brackets to indicate index of collections of fields in row.
            aRow["CustomerID"] = aOrder.CustomerId;
        }
        #endregion

        #region Adding Orders To Database
        public void DataSetModified(Order aOrder)
        {
            DataRow row = null;
            string dataTable = table1;

            row = dsMain.Tables[dataTable].NewRow();
            FillRow(row, aOrder);
            dsMain.Tables[dataTable].Rows.Add(row);
        }
        #endregion


        #region Creating INSERT SQL
        private void Construct_INSERT_SQL_Paramaters()
        {
            //Creating SQL Parameters to communicate with SQL INSERT...
            //add the input parameter and set its properties.

            SqlParameter sqlParameter = default(SqlParameter);

            sqlParameter = new SqlParameter("@OrderID", SqlDbType.NVarChar, 15, "OrderID");
            daMain.InsertCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter("@dateCreated", SqlDbType.DateTime, 100, "DateCreated");
            daMain.InsertCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter("@CustomerID", SqlDbType.Int, 15, "CustomerID");
            daMain.InsertCommand.Parameters.Add(sqlParameter);

        }

        private void Commands_INSERT()
        {
            //Create the command that must be used to insert values into the table..

            daMain.InsertCommand = new SqlCommand("INSERT into Orders (OrderID, DateCreated, CustomerID) VALUES (@OrderID, @dateCreated, @CustomerID)", cnMain);

            Construct_INSERT_SQL_Paramaters();
        }

        
        public bool UpdateDataSource()
        {
            Commands_INSERT();

            bool success = UpdateDataSource(sqlLocal1, table1);

            return success;

        }
        #endregion
    }
}
