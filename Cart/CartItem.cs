using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class CartItem
    {
        private Dictionary<IProduct, int> _cartItems = new Dictionary<IProduct, int>();
        public Dictionary<IProduct, int> ItemList()
        {
            return _cartItems;
        }
        public void AddItem(IProduct product)
        {
            if (_cartItems.ContainsKey(product))
            {
                _cartItems[product] += 1;
            }
            else
            {
                _cartItems[product] = 1;
            }
        }
        public Double GetPrice(IProduct product)
        {
            return _cartItems[product] * product.GetPriceAfterProductDiscount();
        }

    }
}
