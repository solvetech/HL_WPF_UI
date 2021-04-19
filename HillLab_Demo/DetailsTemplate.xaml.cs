using Inventory.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace HillLab_Demo
{
    /// <summary>
    /// Interaction logic for DetailsTemplate.xaml
    /// </summary>
    public partial class DetailsTemplate : UserControl
    {
        public DetailsTemplate()
        {
            InitializeComponent();
        }

        private void SampleTypeGridview_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangeEventArgs e)
        {
            if(this.childTab.Items.Count == 1)
            {
                this.gridTabItem.MinHeight = this.gridTabItem.MaxHeight = 50;
                this.gridTabItem.HeaderTemplate = null;
            }
            var templete = (DataTemplate)this.Resources["dynamicTab"];
            string header;
            if(e.AddedItems?.FirstOrDefault() is Product product)
            {
                header = product.Name;
            }
            else
            {
                header = $"Details {this.childTab.Items.Count}";
            }
            this.childTab.Items.Add(new RadTabItem() { Header = header, ContentTemplate = templete, HeaderTemplate = (DataTemplate)this.Resources["TabItemHeaderTemplate"] ,IsSelected=true });
            
        }

        private void RadButton_Click(object sender, RoutedEventArgs e)
        {
            this.childTab.Items.RemoveAt(this.childTab.Items.Count - 1);
            if (this.childTab.Items.Count == 1)
            {
                this.gridTabItem.MinHeight = this.gridTabItem.MaxHeight = 0;
                this.gridTabItem.HeaderTemplate = (DataTemplate)this.Resources["emptyHeader"];
            }
        }
    }
}
