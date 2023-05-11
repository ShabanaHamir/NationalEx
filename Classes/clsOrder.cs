using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsOrder
/// </summary>
public class clsOrder
{
    public clsOrder()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public void ProcessCart(clsCart ShoppingCart)
    {
        ///at this point all the data has been captured by the presentation layer
        ///this is the stage where all of the data is passed to the data layer via the two stored procedures like so
        ///

        //first we add the order to the database using data from the cart's private data member s
        //connect to the database
        clsDataConnection DB = new clsDataConnection();
        //pass the data as parameters to the data layer
        DB.AddParameter("@OrderDate", DateTime.Now.Date);
        DB.AddParameter("@CustomerNo", ShoppingCart.UserNo);
        DB.AddParameter("@CardNo", ShoppingCart.CardNo);
        //execute the stored procedure capturing the primary key of the new record in the variable OrderNo
        Int32 NewOrderNo;
        NewOrderNo = DB.Execute("sproc_tblOrder_Insert");

        //now we need to loop through all the products adding them to the order line table
        Int32 Index = 0;
        Int32 Count = ShoppingCart.Products.Count;
        while (Index < Count)
        {
            //reset the connection to the database
            DB = new clsDataConnection();
            DB.AddParameter("@OrderNo", NewOrderNo);
            DB.AddParameter("@ProductNo", ShoppingCart.Products[Index].ProductID);
            DB.AddParameter("@Quantity", ShoppingCart.Products[Index].QTY);
            Int32 OrderNo = DB.Execute("sproc_tblOrderLine_Insert");
            Index++;
        }
        //now look in the tables and the order should be present
        //we could also do other things here such as adjust stock levels
    }
}