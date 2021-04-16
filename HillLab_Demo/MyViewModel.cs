using HillLab_Demo.Models;
using System.Collections.ObjectModel;
using Telerik.Windows.Controls;

namespace HillLab_Demo
{
    public class MyViewModel : ViewModelBase
    {
        private ObservableCollection<NavigationItemModel> items;

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
                        new LayoutControlItemModel() { Title = "RadTileView", DocumentationLink = "https://docs.telerik.com/devtools/wpf/controls/radtileview/getting-started/getting-started" },
                        new LayoutControlItemModel() { Title = "RadTileList", DocumentationLink = "https://docs.telerik.com/devtools/wpf/controls/radtilelist/getting-started/getting-started" },
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
