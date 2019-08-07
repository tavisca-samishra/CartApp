using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public class Discount
    {
        int? percent;

        public Discount(int? percent)
        {
            this.percent = percent;
        }
        public int? GetDiscountPercent()
        {
            return percent;
        }
    }
}
