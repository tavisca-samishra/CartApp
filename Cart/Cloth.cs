using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class Cloth:IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Discount Discount { get; set; }

        public double GetPriceAfterProductDiscount()
        {
            if (Discount.GetDiscountPercent() == null)
                return Price;
            else
                return Price - (Price * (double)Discount.GetDiscountPercent()) / 100;
        }
    }
}
