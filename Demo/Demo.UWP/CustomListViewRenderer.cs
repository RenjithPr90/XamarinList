using Demo;
using Demo.UWP;
using System.ComponentModel;
using Windows.UI.Xaml.Controls;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomListView), typeof(CustomListViewRenderer))]
namespace Demo.UWP
{
    public class CustomListViewRenderer : ListViewRenderer
    {
        ListView listView;
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);
            listView = Control as ListView;

            if (e.OldElement != null)
            {
                // Unsubscribe
                listView.SelectionChanged -= OnSelectedItemChanged;
            }
            if (e.NewElement != null)
            {
                listView.SelectionMode = ListViewSelectionMode.Single;
                listView.IsItemClickEnabled = false;
                listView.ItemsSource = e.NewElement.ItemsSource;
                listView.ItemTemplate = App.Current.Resources["ListViewItemTemplate"] as Windows.UI.Xaml.DataTemplate;

                // Subscribe
                listView.SelectionChanged += OnSelectedItemChanged;
            }
        }
            protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == CustomListView.ItemsProperty.PropertyName)
            {
                listView.ItemsSource = ((CustomListView)Element).Items;
            }
        }
        void OnSelectedItemChanged(object sender, SelectionChangedEventArgs e)
        {
            ((CustomListView)Element).NotifyItemSelected(listView.SelectedItem);
        }
    }
}
