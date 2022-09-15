using PoppelSolution.Business_Layer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PoppelSolution.DatabaseLayer
{
    internal class CustomerDB : DB
    {
        #region
        private string table1 = "Customers";
        private string sqlLocal1 = "SELECT * FROM Customers";
        
       
        private Collection<Customer> customers;

        #endregion

        #region Property Method: Collection
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }
        #endregion

        #region Constructor
        public CustomerDB() : base()
        {
            customers = new Collection<Customer>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection(table1);

        } 
        #endregion

       #region Utility Methods
        public DataSet GetDataSet()
        {

            return dsMain;
        }
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and a Customer object
            DataRow myRow = null;
            Customer custmer;


            foreach (DataRow rowVariable in dsMain.Tables[table].Rows)
            {
                myRow = rowVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Customer object
                    custmer = new Customer();
                    custmer.ID = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                    custmer.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    //Do the same for all other attributes
                    custmer.Phone = Convert.ToString(myRow["Phone"]).TrimEnd();
                    custmer.Email = Convert.ToString(myRow["Email"]).TrimEnd();
                    custmer.Address = Convert.ToString(myRow["Address"]).TrimEnd();

                    customers.Add(custmer);

                }


            }


        }private void FillRow(DataRow aRow, Customer aCustomer, DB.DBOperation operation)
        {

            if (operation == DB.DBOperation.Add)
            {
                aRow["CustomerID"] = aCustomer.ID;
                aRow["Name"] = aCustomer.Name; 
                aRow["Phone"] = aCustomer.Phone;
                aRow["Email"] = aCustomer.Email;
                aRow["Address"] = aCustomer.Address;
            }

        }
        
        private int FindRow(Customer aCustomer, string table)
        {
            int rowIndex = 0;
            DataRow row;
            int returnValue = -1;
            foreach (DataRow loopVariable in dsMain.Tables[table].Rows)
            {
                row = loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(row.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it 
                    //is automatically known to the compiler when used as below
                    if (aCustomer.ID == Convert.ToString(dsMain.Tables[table].Rows[rowIndex]["CustomerID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        #region Operations CRUD
        public void DataSetModified(Customer aCustomer, DB.DBOperation operation)
        {
            DataRow row = null;
            string dataTable = table1;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    row = dsMain.Tables[dataTable].NewRow();
                    FillRow(row, aCustomer, operation);
                    dsMain.Tables[dataTable].Rows.Add(row);
                    break;
                case DB.DBOperation.Edit:
                    row = dsMain.Tables[dataTable].Rows[FindRow(aCustomer, dataTable)];
                    FillRow(row, aCustomer, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    row = dsMain.Tables[dataTable].Rows[FindRow(aCustomer, dataTable)];
                    row.Delete();

                    break;
            }

        }
        #endregion
        #region SQL INSERT, BUILD, CREATE Parameters
        private void Construct_INSERT_SQL_Paramaters()
        {
            //Creating SQL Parameters to communicate with SQL INSERT...
            //add the input parameter and set its properties.

            SqlParameter sqlParameter = default(SqlParameter);

            sqlParameter = new SqlParameter("@CustomerID", SqlDbType.Int, 15, "CustomerID");
            daMain.InsertCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            daMain.InsertCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter("@Email", SqlDbType.NVarChar, 30, "Email");
            daMain.InsertCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter("@Address", SqlDbType.NVarChar, 100, "Address");
            daMain.InsertCommand.Parameters.Add(sqlParameter);


        }

        private void Construct_UPDATE_SQL_Parameters()
        {

            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter sqlParameter = default(SqlParameter);

            sqlParameter = new SqlParameter("@CustomerID", SqlDbType.Int, 15, "CustomerID");
            sqlParameter.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            sqlParameter.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter("@Phone", SqlDbType.NVarChar, 15, "Phone");
            sqlParameter.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter("@Email", SqlDbType.NVarChar, 100, "Email");
            sqlParameter.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter("@Address", SqlDbType.NVarChar, 100, "Address");
            sqlParameter.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(sqlParameter);

            sqlParameter = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "CustomerID");
            sqlParameter.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(sqlParameter);
        }

        private void Commands_INSERT()
        {
            //Create the command that must be used to insert values into the table..
           
            daMain.InsertCommand = new SqlCommand("INSERT into Customers (CustomerID, Name, Phone, Email, Address) VALUES (@CustomerID, @Name, @Phone, @Email, @Address)", cnMain);

            Construct_INSERT_SQL_Paramaters();
        }

        private void Commands_UPDATE()
        {
            //Create the command that must be used to insert values into the table
            
            daMain.UpdateCommand = new SqlCommand("UPDATE Customers SET Customers =@Customers, Name =@Name, Phone =@Phone, Email =@Email, Address =@Address " + "WHERE CustomerID = @Original_ID", cnMain);

            Construct_UPDATE_SQL_Parameters();
        }
        public bool UpdateDataSource()
        {
            Commands_INSERT();
            Commands_UPDATE();

            bool success = UpdateDataSource(sqlLocal1, table1);

            return success;
        }

        #endregion
    }
}
