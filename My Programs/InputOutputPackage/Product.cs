using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputPackage
{
    public  class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public  DateTime ProductExpDate {  get; set; }
        public string ProductType { get; set; }


        public Product(int productId,string productName,DateTime productexpDate,string roductType)
        {
            ProductId = productId;
            ProductName = productName;
            ProductExpDate = productexpDate;
            ProductType = roductType;

        }

        

        public override string ToString() 
        {
            return $" Product Details [ Product Id: {ProductId} , Product Name: {ProductName} , ProductExpDate: {ProductExpDate} , ProductType: {ProductType} ] ";
        }





    }


}
