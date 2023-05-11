using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsProduct
/// </summary>
public class clsCartItem
{
    public clsCartItem()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    private Int32 mProductID;
    public Int32 ProductID
    {
        get
        {
            return mProductID;
        }

        set
        {
            mProductID = value;
        }
    }

    private string mActivityName;
    public string ActivityName
    {
        get
        {
            return mActivityName;
        }

        set
        {
            mActivityName = value;
        }
    }

    private decimal mActivityPrice;
    public decimal ActivityPrice
    {
        get
        {
            return mActivityPrice;
        }

        set
        {
            mActivityPrice = value;
        }
    }


    private Int32 mQTY;
    public Int32 QTY
    {
        get
        {
            return mQTY;
        }

        set
        {
            mQTY = value;
        }
    }

    public decimal Total
    {
        get
        {
            return mQTY * mActivityPrice;
        }
    }

}