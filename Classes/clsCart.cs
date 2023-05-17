using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for clsCart
/// </summary>
public class clsCart
{

    /// <summary>
    /// this class defines some tyical attributes of a shopping cart
    ///
    /// clsCart
    /// ___________________________________________________________________________________
    /// Properties
    /// public DateTime OrderDate (note that the value of this is set in the constructor)
    /// public Int32 UserNo
    /// public string CardNo
    /// public List<clsCartItem> Products
    /// ___________________________________________________________________________________
    /// Methods
    /// public void Checkout()
    /// ___________________________________________________________________________________
    /// </summary>

    List<clsCartItem> mProducts = new List<clsCartItem>();
    public clsCart()
    {

    }
    public void AddItem(clsCartItem item)
    {
        Products.Add(item);
    }
    private Int32 mUserNo;
    public Int32 UserNo
    {
        get
        {
            return mUserNo;
        }
        set
        {
            mUserNo = value;
        }
    }

    private string mCardNo;
    public string CardNo
    {
        get
        {
            return mCardNo;
        }
        set
        {
            mCardNo = value;
        }
    }

    public List<clsCartItem> Products
    {
        get
        {
            return mProducts;
        }
    }

    public decimal GetTotalPrice()
    {
        decimal total = 0;

        foreach (clsCartItem item in Products)
        {
            total += item.ActivityPrice * item.QTY;
        }

        return total;
    }

    public void Checkout()
    {
        //create an instance of the order class
        clsOrder Order = new clsOrder();
        //invoke the ProcessCart method
        Order.ProcessCart(this);
    }
}