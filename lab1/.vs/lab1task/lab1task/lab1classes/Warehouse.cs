using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lab1task.lab1classes
{
    public class Warehouse
    {

        public class WarehouseItem
        {
            public Product Product { get; set; }
            public string Unit { get; set; }
            public int Quantity { get; set; }
            public DateTime LastDeliveryDate { get; set; }
        }

        private List<WarehouseItem> products;

        public Warehouse()
        {
            products = new List<WarehouseItem>();
        }

        public void AddProduct(Product product, string unit, int quantity, DateTime lastDeliveryDate)
        {
            products.Add(new WarehouseItem
            {
                Product = product,
                Unit = unit,
                Quantity = quantity,
                LastDeliveryDate = lastDeliveryDate
            });
        }

        public void ReduceQuantity(string productName, int amount)
        {
            foreach (var item in products)
            {
                if (item.Product.Name == productName)
                {
                    item.Quantity -= amount;
                    if (item.Quantity < 0)
                    {
                        item.Quantity = 0;
                    }
                    break;
                }
            }
        }

        public string InventoryReport()
        {
            string report = "";
            foreach (var item in products)
            {
                report += $"Category: {item.Product.Category}, Product: {item.Product.Name}, Unit: {item.Unit}, Quantity: {item.Quantity}, Last Delivery Date: {item.LastDeliveryDate:yyyy-MM-dd}\n";
            }
            return report;
        }
    }
}
