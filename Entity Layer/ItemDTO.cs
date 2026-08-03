using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Layer
{
    public record ItemDTO
    {
        public string Name { get; set; } = string.Empty;
        public long Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public DateOnly ExpireDate { get; set; }
        public int Barcode { get; set; }
        public int Stock { get; set; }
    }
}
