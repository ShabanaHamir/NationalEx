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
        // TODO:  constructor logic 
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

    private string mRoomType;
    public string RoomType
    {
        get
        {
            return mRoomType;
        }

        set
        {
            mRoomType = value;
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

    private string mRoomDescription;
    public string RoomDescription
    {
        get
        {
            return mRoomDescription;
        }

        set
        {
            mRoomDescription = value;
        }
    }
    private string mRoomFacilities;
    public string RoomFacilities
    {
        get
        {
            return mRoomFacilities;
        }

        set
        {
            mRoomFacilities = value;
        }
    }
  
    private int mRoomID;
    public int RoomID
    {
        get { return mRoomID; }
        set { mRoomID = value; }
    }

    private int mTripID;
    public int TripID
    {
        get { return mTripID; }
        set { mTripID = value; }
    }

    private int mTripDestination;
    public int TripDestination
    {
        get { return mTripDestination; }
        set { mTripDestination = value; }
    }

    private decimal mTicketCost;
    public Decimal TicketCost
    {
        get { return mTicketCost; }
        set { mTicketCost = value; }
    }
    private int mQuantity;
    public int Quantity
    {
        get
        {
            return mQuantity;
        }
        set
        {
            mQuantity = value;
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