using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class Cart
    {
        CartItem _cartItem;
        Discount _discount = new Discount(10);

        public Cart(CartItem cartItem)
        {
            _cartItem = cartItem;
        }

        public Cart(CartItem cartItem,Discount discount)
        {
            _cartItem = cartItem;
            _discount = discount;
        }
        public Double GetTotal()
        {
            double totalPrice = 0;
            foreach (var item in _cartItem.ItemList())
            {
                totalPrice += _cartItem.GetPrice(item.Key);
            }
            if(_discount.GetDiscountPercent()==null)
                return totalPrice;
            else
                return totalPrice - (totalPrice * (double)_discount.GetDiscountPercent()) / 100;

        }

    }
}
