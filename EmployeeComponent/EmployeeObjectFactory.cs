using System;
using System.Collections.Generic;
using System.Text;
using EmployeeComponent.Data;
using EmployeeComponent.Views;

namespace EmployeeComponent
{   
    public static class EmployeeObjectFactory
    {
        private static EmployeeCreateView _employeeCreateView = null;
        private static EmployeeReadView _employeeReadView = null;
        private static EmployeeUpdateView _employeeUpdateView = null;
        private static EmployeeDeleteView _employeeDeleteView = null;
        public static Employee CreateNewEmployeeObject(string firstName, string lastName, decimal annualSalary, char gender, bool isManager)
        {
            return new Employee
            {
                FirstName = firstName,
                LastName = lastName,
                AnnualSalary = annualSalary,
                Gender = gender,
                IsManger = isManager
            };

        }

        public static EmployeeRecordsView EmployeeRecordsViewObject(Employees employees)
        {
            return new EmployeeRecordsView(employees);
        }

        public static EmployeeCreateView EmployeeCreateViewObject(Employees employees)
        {
            if (_employeeCreateView == null)
            {
                _employeeCreateView = new EmployeeCreateView(employees);
            }

            return _employeeCreateView;
        }
        public static EmployeeReadView EmployeeReadViewObject(Employees employees)
        {
            if (_employeeReadView == null)
            {
                _employeeReadView = new EmployeeReadView(employees);
            }

            return _employeeReadView;
        }
        public static EmployeeUpdateView EmployeeUpdateViewObject(Employees employees)
        {
            if (_employeeUpdateView == null)
            {
                _employeeUpdateView = new EmployeeUpdateView(employees);
            }

            return _employeeUpdateView;
        }
        public static EmployeeDeleteView EmployeeDeleteViewObject(Employees employees)
        {
            if (_employeeDeleteView == null)
            {
                _employeeDeleteView = new EmployeeDeleteView(employees);
            }

            return _employeeDeleteView;
        }
    }

}
