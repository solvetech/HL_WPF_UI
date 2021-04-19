using System.Collections.ObjectModel;
using Telerik.Windows.Controls;

namespace HillLab_Demo.Models
{
    public class NavigationItemModel : ViewModelBase
    {
        private string title;

        public string Title
        {
            get => title;
            set { title = value; OnPropertyChanged("Title"); }
        }
        public string IconGlyph { get; set; }
        public ObservableCollection<NavigationItemModel> Children { get; set; }
    }
}
