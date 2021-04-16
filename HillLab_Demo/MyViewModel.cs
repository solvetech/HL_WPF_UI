using HillLab_Demo.Models;
using Inventory.Data.Services;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using Telerik.Windows.Controls;

namespace HillLab_Demo
{
    public class MyViewModel : ViewModelBase
    {

        private ObservableCollection<NavigationItemModel> items;

        private SQLiteDb sourceDb;

        public MyViewModel()
        {
            var path = System.AppDomain.CurrentDomain.BaseDirectory;
            string connectionString = @"Data source=" + path + @"\Database\Inventory.db";
            sourceDb = new SQLiteDb(connectionString);
        }

        public ObservableCollection<NavigationItemModel> Items
        {
            get
            {
                if (this.items == null)
                {
                    this.items = this.GenerateItems();
                }

                return this.items;
            }
        }

        private ObservableCollection<Customer> GenerateCustomers()
        {
            var customers = new ObservableCollection<Customer>();
            for (int i = 1; i <= 100; i++)
            {
                var customer = new Customer() { Name = "Customer " + i, Age = 25 + i };
                customers.Add(customer);
            }

            return customers;
        }


        public ObservableCollection<NavigationItemModel> GenerateItems()
        {
            var source = new ObservableCollection<NavigationItemModel>()
            {
                new NavigationItemModel()
                {
                    Title = "File",
                    IconGlyph = "&#xe10b;",
                },
                new NavigationItemModel()
                {
                    Title = "DashBoards",
                    IconGlyph = "&#xe024;",
                },
                 new NavigationItemModel()
                {
                    Title = "Order",
                    IconGlyph = "&#xe10b;",
                },
                new NavigationItemModel()
                {
                    Title = "Dispatch",
                    IconGlyph = "&#xe024;",
                },
                new NavigationItemModel()
                {
                    Title = "Catalouge",
                    IconGlyph = "&#xe10b;",

                     Children = new ObservableCollection<NavigationItemModel>()
                    {
                        new LayoutControlItemModel() { Title = "Analytical Tests",DataList=sourceDb.Orders,LayoutControlItems=GenerateCustomers() },
                        new LayoutControlItemModel() { Title = "Catagories", DataList=sourceDb.Categories,LayoutControlItems=GenerateCustomers() }
                    }

                },
                new NavigationItemModel()
                {
                    Title = "Customer",
                    IconGlyph = "&#xe024;",
                },
                new NavigationItemModel()
                {
                    Title = "System",
                    IconGlyph = "&#xe024;",
                },
                new NavigationItemModel()
                {
                    Title = "User Administration",
                    IconGlyph = "&#xe10b;",
                },
                new NavigationItemModel()
                {
                    Title = "Settings",
                    IconGlyph = "&#xe024;",
                }
            };

            return source;
        }
    }
}
