namespace HardwareStore
{
    class Hardware
    {
        //class attributes
        int itemNo;
        string prodName = "";
        int qty;
        decimal price;

        #region gets and sets
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
            get {
                return prodName;
            }
            set {
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

        public Hardware(int itemNum, string productName, 
            int quantity, decimal cost)
        {
            itemNo = itemNum;
            prodName = productName;
            qty = quantity;
            price = cost;
        }
        public override string ToString()
        {
            return 
                itemNo.ToString() 
                + "     " + prodName.ToString()
                //+ "     " + qty.ToString() //commented out to hide quantity
                + "     " + price.ToString("C")
                ;
        }
    }
}
