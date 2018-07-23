using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ePOSClass
{
    public class ePOSClass
    {

    }

    public class SalesLine
    {
        public int _index { get; set; }
        public int _saleNo { get; set; }
        public String _stockRef { get; set; }
        public String _description { get; set; }
        public int _orderQty { get; set; }
        public double _retailPrice { get; set; }
        public double _extPrice { get; set; }
        public double _vatPaid {get; set;}
        public int _itemsReturned {get; set;}
        public double _refundAmount {get; set;}
        public DateTime _refundDate {get; set;}
        public string _deptCode {get; set;}
        public bool _taxApplicable {get; set;}
        public bool _sellByValue {get; set;}
        public int _taxCode {get; set;}
        public double _costPrice {get; set;}
        public string _catalogueCode {get; set;}
        public int _markUp { get; set; }
        public string _altBarcode { get; set; }

        public SalesLine(int saleNo, string stockref, string description, int orderQty, double retailPrice,
                         double extPrice, double vatPaid, int itemsReturned, double refundAmount, DateTime refundDate,
                         string deptCode,bool taxApplciable, bool sellByValue, int taxCode, double costPrice,string catalogueCode,
                         int markUp, string altBarcode)
                
        {
            
            _saleNo = saleNo;
            _stockRef = stockref;
            _description = description;
            _orderQty = orderQty;
            _retailPrice = retailPrice;
            _extPrice = extPrice;
            _vatPaid = vatPaid;
            _itemsReturned = itemsReturned;
            _refundAmount = refundAmount;
            _refundDate = refundDate;
            _deptCode = deptCode;
            _taxApplicable = taxApplciable;
            _sellByValue = sellByValue;
            _taxCode = taxCode;
            _costPrice = costPrice;
            _catalogueCode = catalogueCode;
            _markUp = markUp;
            _altBarcode = altBarcode;


        }



    }
    
    
    public class IndexedProduct
    {
        private int Index { get; set; }
        private string Product { get; set; }
        

        public IndexedProduct(int i, string str)
        {
            Index = i;
            Product = str;
        }

        public override string ToString() 
        {
            return Index.ToString() + " " + Product;
        }

        

    }
}
