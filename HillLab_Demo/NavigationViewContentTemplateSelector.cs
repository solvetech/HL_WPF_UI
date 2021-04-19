using HillLab_Demo.Models;
using System.Windows;
using System.Windows.Controls;

namespace HillLab_Demo
{
    public class NavigationViewContentTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EditorsTemplate { get; set; }
        public DataTemplate LayoutControlsTemplate { get; set; }
        public DataTemplate RadComboBoxTemplate { get; set; }
        public DataTemplate RadAutoCompleteBoxTemplate { get; set; }
        public DataTemplate RadTileListTemplate { get; set; }
        public DataTemplate RadTileViewTemplate { get; set; }

        public DataTemplate RadGridViewTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var navigationItemModel = item as NavigationItemModel;

            switch (navigationItemModel?.Title)
            {
                case "Analytical Tests": return this.RadGridViewTemplate;
                default:
                    return this.EditorsTemplate;
            }

            return base.SelectTemplate(item, container);
        }
    }
}
