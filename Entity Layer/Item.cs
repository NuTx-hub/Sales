using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Layer
{
    public class Item
    {
        private string name = string.Empty;
        private long id = 0;
        private string description = string.Empty;
        private decimal price = 0;
        private DateOnly expireDate = DateOnly.MinValue;
        private int barcode = 0;
        private int stock = 0   ;
        
        public string Name { get => name; set => name = value; }
        public long Id { get => id; set => id = value; }
        public string Description { get => description; set => description = value; }
        public decimal Price { get => price; set => price = value; }
        public DateOnly ExpireDate { get => expireDate; set => expireDate = value; }
        public int Barcode { get => barcode; set => barcode = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
