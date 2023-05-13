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

    //public decimal Total
    //{
    //    get
    //    {
    //        return mQTY * mActivityPrice;
    //    }
    //}

    private string mRoomName;
    public string RoomName
    {
        get
        {
            return mRoomName;
        }

        set
        {
            mRoomName = value;
        }
    }

    private decimal mRoomPrice;
    public decimal RoomPrice
    {
        get
        {
            return mRoomPrice;
        }

        set
        {
            mRoomPrice = value;
        }
    }

    private string mItemType; // "Room" or "Activity"
    public string ItemType
    {
        get
        {
            return mItemType;
        }

        set
        {
            mItemType = value;
        }
    }

    public decimal Total
    {
        get
        {
            // Calculate total based on item type
            if (ItemType == "Room")
                return mQTY * mRoomPrice;
            else // Assume "Activity"
                return mQTY * mActivityPrice;
        }
    }


}