using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class clsCheckout
    {
        // List to store cart items
        public List<clsCartItem> CartItems { get; set; }

        // Constructor
        public clsCheckout()
        {
            CartItems = new List<clsCartItem>();
        }

        // Method to add an item to the cart
        public void AddItem(clsCartItem item)
        {
            CartItems.Add(item);
        }

        // Method to remove an item from the cart
        public void RemoveItem(int index)
        {
            if (index >= 0 && index < CartItems.Count)
            {
                CartItems.RemoveAt(index);
            }
        }

        // Method to calculate the total price of the items in the cart
        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;

            foreach (clsCartItem item in CartItems)
            {
                totalPrice += item.ActivityPrice * item.Quantity;
            }

            return totalPrice;
        }
    }
}

