using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1task.lab1classes
{
    public class Reporting
    {
        private Warehouse warehouse;

        public Reporting()
        {
            warehouse = new Warehouse();
        }

        public void RegisterIncome(Product product, string unit, int quantity, DateTime date)
        {
            warehouse.AddProduct(product, unit, quantity, date);
        }

        public void RegisterOutgoing(string productName, int quantity)
        {
            warehouse.ReduceQuantity(productName, quantity);
        }

        public string GenerateInventoryReport()
        {
            return warehouse.InventoryReport();
        }
    }
}
