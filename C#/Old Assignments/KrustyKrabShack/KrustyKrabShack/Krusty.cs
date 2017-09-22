using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrustyKrabShack
{
    class Krusty
    {
        #region Local class variables - private
        private int itemNo;
        private string prodName;
        private int qty;
        private decimal price;
        #endregion
        #region Properties of our class - public
        public int ItemNo
        {
            get
            {
                return itemNo;
            }
            set
            {
                itemNo = value;
            }
        }
        public string ProdName
        {
            get
            {
                return prodName;
            }
            set
            {
                prodName = value;
            }
        }
        public int Qty
        {
            get
            {
                return qty;
            }
            set
            {
                qty = value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        #endregion
        public Krusty(int itemNo, string prodName,
            int qty, decimal price)
        {
            this.itemNo = itemNo;
            this.prodName = prodName;
            this.qty = qty;
            this.price = price;
        }
        public override string ToString()
        {
            return string.Format(
                "{0} {1, -40} {2, 22}",
                itemNo,
                prodName,
                price.ToString("C"))
                ;
        }
        public static decimal CalculateSubTotal(Krusty[] items)
        {
            decimal subTotal = 0;
            foreach (Krusty item in items)
            {
                if (item is Krusty)
                {
                    subTotal += item.Price;
                }
            }
            return subTotal;
        }
        public static decimal CalculateTax(Krusty[] items)
        {
            decimal tax = 0;
            foreach (Krusty item in items)
            {
                if (item is Krusty)
                {
                    tax += item.Price * 0.075m;
                }
            }
            return tax;
        }
        public static decimal CalculateTotal(Krusty[] items)
        {
            decimal total = 0;
            foreach (Krusty item in items)
            {
                if (item is Krusty)
                {
                    total += item.Price + (item.Price * 0.075m);
                }
            }
            return total;
        }
    }
}
