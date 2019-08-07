﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cart
{
    public interface IProduct
    {
        string Name { get; set; }
        int Price { get; set; }
        Discount Discount { get; set; }
        double GetPriceAfterProductDiscount();
    }
}
