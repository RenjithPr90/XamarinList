using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;

namespace Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // ObservableCollection<Company> list1 = new ObservableCollection<Company>
            // { new Company { CompanyName = "com1 name1",Id="1",
            //                 Employees = new List<Employee>
            //                 { new Employee {EmployeeName = "Ron"},
            //                   new Employee { EmployeeName = "John" },
            //                   new Employee { EmployeeName = "Ron" },
            //                   new Employee { EmployeeName = "David" },
            //                   new Employee { EmployeeName = "Manu" },
            //                   new Employee { EmployeeName = "rony" },
            //                   new Employee { EmployeeName = "John" },
            //                   new Employee { EmployeeName = "Philip" },
            //                   new Employee { EmployeeName = "John" },
            //                   new Employee { EmployeeName = "David"  } } },
            // new Company { CompanyName = "company name2",Id="2",
            //                 Employees = new List<Employee>
            //                 { new Employee {EmployeeName = "Ron"},
            //                   new Employee { EmployeeName = "John" },
            //                   new Employee { EmployeeName = "Ron" },
            //                   new Employee { EmployeeName = "David" },
            //                   new Employee { EmployeeName = "Manu" },
            //                   new Employee { EmployeeName = "rony" },
            //                   new Employee { EmployeeName = "John" },
            //                   new Employee { EmployeeName = "Philip" },
            //                   new Employee { EmployeeName = "John" },
            //                   new Employee { EmployeeName = "David"  } } },

            //new Company { CompanyName = "company name3",Id="3",
            //                 Employees = new List<Employee>
            //                 { new Employee {EmployeeName = "Ron"},
            //                   new Employee { EmployeeName = "John" },
            //                   new Employee { EmployeeName = "Ron" },
            //                   new Employee { EmployeeName = "David" },
            //                   new Employee { EmployeeName = "Manu" },
            //                   new Employee { EmployeeName = "rony" },
            //                   new Employee { EmployeeName = "John" },
            //                   new Employee { EmployeeName = "Philip" },
            //                   new Employee { EmployeeName = "John" },
            //                   new Employee { EmployeeName = "David"  } } }};
            // var result = list1
            //              .SelectMany(a => a.Employees.Select(b => new { EmployeeName = b.EmployeeName }))
            //              .GroupBy(x => x.EmployeeName);
            // var fda = from item in list1
            //           group item by new { item.CompanyName, item.Employees } into groupItems
            //           select new
            //           {
            //               groupItems.Key.CompanyName,
            //               groupItems.Key.Employees
            //           };
            // var groupedList = from model in list1
            //           group model by new { model.CompanyName,model.Id, model.Employees } into wordCollection
            //           orderby wordCollection.Key.CompanyName
            //           select new GroupViewModel<Employee>(wordCollection.Key.CompanyName, wordCollection.Key.Id, wordCollection.Key.Employees);

            var list = new CustomListView();

            var list22 = new List<string>();
            for (var i = 0; i < 1000; i++)
            {
                list22.Add("Item" + i);
            }
            list.ItemsSource = list22;
            stackk.Children.Add(list);
        }
    }
    class GroupViewModel<T> : IEnumerable<T>
    {
        public IEnumerable<T> Items { get; private set; }

        public string Name { get; private set; }
        public string Id { get; private set; }
        public GroupViewModel(string name,string id, IEnumerable<T> items)
        {
            this.Id = id;
            this.Name = name;
            this.Items = items;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.Items.GetEnumerator();
        }
    }
}
