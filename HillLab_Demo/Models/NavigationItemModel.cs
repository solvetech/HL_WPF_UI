﻿using System.Collections.ObjectModel;

namespace HillLab_Demo.Models
{
    public class NavigationItemModel
    {
        public string Title { get; set; }
        public string IconGlyph { get; set; }
        public ObservableCollection<NavigationItemModel> Children { get; set; }
    }
}
