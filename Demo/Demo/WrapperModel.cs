
using System.ComponentModel;

namespace Demo
{
    public class WrapperModel<T> : INotifyPropertyChanged
    {
        public T Model { get; set; }
        public event PropertyChangedEventHandler PropertyChanged = delegate { };
        bool listVisibility = false;
        public bool ListVisibility
        {
            get
            {
                return listVisibility;
            }
            set
            {
                if (listVisibility != value)
                {
                    listVisibility = value;
                    PropertyChanged(this, new PropertyChangedEventArgs("ListVisibility"));
                }
            }
        }
    }
}
