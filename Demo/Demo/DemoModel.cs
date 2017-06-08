using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Demo
{
    public class Company
    {
        public string CompanyName { get; set; }
        public string Id { get; set; }
        public List<Employee> Employees { get; set; }
    }
    public class Employee
    {
        public string EmployeeName { get; set; }
    }
    
    public class CompanyGrouped: ObservableCollection<Employee>
    {
        public string CompanyName { get; set; }
    }
}
