using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace Demo
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            ObservableCollection<Company> list1 = new ObservableCollection<Company>
                    { new Company { CompanyName = "com1 name1",Id="1",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name2",Id="2",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } },
                    new Company { CompanyName = "company name3",Id="3",
                    Employees = new List<Employee>
                    { new Employee {EmployeeName = "Ron"},
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Ron" },
                    new Employee { EmployeeName = "David" },
                    new Employee { EmployeeName = "Manu" },
                    new Employee { EmployeeName = "rony" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "Philip" },
                    new Employee { EmployeeName = "John" },
                    new Employee { EmployeeName = "David"  } } }};
            var groupedList = from model in list1
                              group model by new { model.CompanyName, model.Id, model.Employees } into wordCollection
                              orderby wordCollection.Key.CompanyName
                              select new GroupViewModel<Employee>(wordCollection.Key.CompanyName, wordCollection.Key.Id, wordCollection.Key.Employees);

            var list = new ListView();
            list.ItemsSource = groupedList;
            list.IsGroupingEnabled = true;
            list.GroupDisplayBinding = new Binding("Name");
            list.GroupShortNameBinding = new Binding("Name");
            list.GroupHeaderTemplate = new DataTemplate(() =>
              {
                  Label lbl = new Label();
                  lbl.TextColor = Color.White;
                  lbl.YAlign = TextAlignment.Center;
                  lbl.SetBinding(Label.TextProperty, "Name");
                  Label lbl2 = new Label();
                  lbl2.TextColor = Color.White;
                  lbl2.YAlign = TextAlignment.Center;

                  lbl2.SetBinding(Label.TextProperty, "Id");
                  return new ViewCell
                  {
                      View = new StackLayout
                      {
                          Children =
                          {
                              lbl,lbl2
                          },
                          BackgroundColor = Color.FromHex("#0563A8"),
                          Padding = new Thickness(10)
                      }
                  };
              });
            list.ItemTemplate = new DataTemplate(() =>
            {
                Label lbl = new Label();
                lbl.SetBinding(Label.TextProperty, "EmployeeName");
                return new ViewCell
                {
                    View = new StackLayout
                    {
                        Children =
                        {
                            lbl
                        }
                    }
                };
            });

            Content = new StackLayout
            {


                Children = {
                   list
                }
            };
        }
    }
}