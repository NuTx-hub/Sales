using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Layer
{
    public class SaleDetails
    {
        public DateTime Date { get; set; }
        public Item [] Items { get; set; }
        public int Discount { get; set; }
        public decimal TotalWithDiscount { get; set {if(Items != null) TotalWithDiscount = TotalPriceSaleWithDiscount(Items, Discount); } }
        public decimal Total {  get; set { Total = TotalPriceSale(Items); } }
            

        private decimal TotalPriceSaleWithDiscount(Item[] itemList, int discount)
        {
            decimal count = 0;
            for (int i = 0; i < itemList.Length; i++)
            {
                count += itemList[i].Price;
            }

            return count - discount;
        }

        private decimal TotalPriceSale(Item[] itemList)
        {
            decimal count = 0;
            for (int i = 0; i < itemList.Length; i++)
            {
                count += itemList[i].Price;
            }

            return count;
        }
    }
}
