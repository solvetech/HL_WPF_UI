using Inventory.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace HillLab_Demo.Models
{
    public class LayoutControlItemModel : ControlItemModel
    {
        private ObservableCollection<Customer> layoutControlItems;

        public ObservableCollection<Customer> LayoutControlItems
        {
            get
            {
                if (this.layoutControlItems == null)
                {
                    this.layoutControlItems = this.GenerateCustomers();
                }

                return this.layoutControlItems;
            }

        }

        public object DataList { get; set; }

        //public DbSet<DbVersion> DbVersion { get; set; }

        //public DbSet<Inventory.Data.Customer> Customers { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderItem> OrderItems { get; set; }
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<CountryCode> CountryCodes { get; set; }
        //public DbSet<PaymentType> PaymentTypes { get; set; }
        //public DbSet<TaxType> TaxTypes { get; set; }
        //public DbSet<OrderStatus> OrderStatus { get; set; }
        //public DbSet<Shipper> Shippers { get; set; }


        private ObservableCollection<Customer> GenerateCustomers()
        {
            var customers = new ObservableCollection<Customer>();
            for (int i = 1; i <= 5; i++)
            {
                var customer = new Customer() { Name = "Customer " + i, Age = 25 + i };
                customers.Add(customer);
            }

            return customers;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
