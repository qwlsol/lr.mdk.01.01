using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesAplication
{
    public class Report
    {
        private List<StructProduct> productList;

        public Report()
        { 
            productList = new List<StructProduct>();
        }
        public void AddProduct(string name, int price, int quantity)
        {
            StructProduct row = new StructProduct();
            row.Name = name;
            row.Price = price;
            row.Quantity = quantity;

            productList.Add(row);
        }
        public static string ConvertRowToString(StructProduct row) 
        {
            return "Название - " + row.Name + ", цена - " + row.Price + ", количество - " + row.Quantity;
        }
        public int GetReportItemCount()
        {
            return productList.Count;
        }
    }
}
