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
            get; 
            set;
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


    }

    public class Customer
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
