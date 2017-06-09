using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Demo
{
    public class CustomListView:ListView
    {
        public static readonly BindableProperty ItemsProperty =
             BindableProperty.Create("Items", typeof(IEnumerable<string>), typeof(CustomListView), new List<string>());

        public IEnumerable<string> Items
        {
            get { return (IEnumerable<string>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        public void NotifyItemSelected(object item)
        {
            if (ItemSelected != null)
            {
                ItemSelected(this, new SelectedItemChangedEventArgs(item));
            }
        }
    }
}
