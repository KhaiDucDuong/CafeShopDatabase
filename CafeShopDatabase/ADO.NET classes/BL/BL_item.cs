using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CafeShopDatabase.ADO.NET_classes.DB;

namespace CafeShopDatabase.ADO.NET_classes.BL
{
    internal class BL_item
    {
        string databaseName = "item";
        string primaryKeyCol = "itemID";
        string secondCol = "itemName";
        string thirdCol = "itemPrice";

        DB_Main db = null;
        public BL_item() 
        {
            db = new DB_Main();
        }

        public DataSet getItem()
        {
            return db.ExecuteQueryDataSet("select * from " + databaseName, CommandType.Text);
        }

        public bool addItem(string itemID, string itemName, string itemPrice, ref string error)
        {
            string sqlString = "INSERT INTO " + databaseName +
                " VALUES (" + itemID + ", N'" + itemName + "', " + itemPrice + ")"; 
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool removeItem(string itemID, ref string error) 
        {
            string sqlString = "DELETE FROM " + databaseName + "WHERE " + primaryKeyCol + " = " + itemID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }

        public bool updateItem(string itemID, string itemName, string itemPrice, ref string error)
        {
            string sqlString = "UPDATE " + databaseName + 
                "SET " + secondCol + " = N'" + itemName + ", " + thirdCol + " = " + itemPrice +
                "WHERE " + primaryKeyCol + " = " + itemID;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref error);
        }
    }
}
