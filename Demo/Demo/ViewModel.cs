using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ViewModel: ViewModelBase
    {
        public ViewModel()
        {
            for (var i = 0; i < 1000; i++)
            {
                NameList.Add("Item" + i);
            }
        }

        private List<string> nameList;
        public List<string> NameList
        {
            get { return nameList; }
            set { nameList = value;
                OnPropertyChanged("NameList");
            }
        }

    }
}
