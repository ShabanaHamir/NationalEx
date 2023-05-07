using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class clsCart
    {
        public List<clsCartItem> CartItems { get; set; }

        public clsCart()
        {
            CartItems = new List<clsCartItem>();
        }

        public void AddToCart(int activityId, string activityName, decimal activityPrice, int quantity)
        {
            var existingItem = CartItems.FirstOrDefault(item => item.ActivityId == activityId);

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                CartItems.Add(new clsCartItem
                {
                    ActivityId = activityId,
                    ActivityName = activityName,
                    ActivityPrice = activityPrice,
                    Quantity = quantity
                });
            }
        }

        public decimal GetTotalPrice()
        {
            return CartItems.Sum(item => item.ActivityPrice * item.Quantity);
        }
    }

    public class clsCartItem
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public decimal ActivityPrice { get; set; }
        public int Quantity { get; set; }
    }
}

