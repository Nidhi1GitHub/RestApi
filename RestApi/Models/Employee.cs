using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestApi.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
    }
    public class Employees
    {
        readonly List<Employee> _employees = new List<Employee>();

        public List<Employee> GetEmployees()
        {
            _employees.Add(new Employee() { EmployeeId = 1, EmployeeName = "Nidhi", Address = "Katargam" });
            _employees.Add(new Employee() { EmployeeId = 2, EmployeeName = "Naineta", Address = "Motibaug" });
            _employees.Add(new Employee() { EmployeeId = 3, EmployeeName = "Krish", Address = "Motibaug" });

            return _employees;
        }
    }   
}