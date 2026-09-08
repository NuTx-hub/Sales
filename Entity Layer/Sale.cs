using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Layer
{
    public class Sale
    {
        public SaleDetails SaleDetails { get; set; } = null;
        public Client Client { get; set; } = null;
    }
}
