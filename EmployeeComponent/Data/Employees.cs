using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace EmployeeComponent.Data
{
    public class Employees
    {
        ArrayList _employeeList = null;

        public Employees()
        {
           _employeeList = new ArrayList();
            SeedData();
        }

        public Employee this[int index]
        {
            get
            {
                return (Employee)_employeeList[index];
            }
        }

        private void SeedData()
        {
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Devin","Smith",60000,'m',false));
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Andrew", "Jones", 40000, 'm', false));
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Brenda", "Anderson", 100000, 'f', true));
            this.Add(EmployeeObjectFactory.CreateNewEmployeeObject("Angela", "Roberts", 30000, 'f', false));

        }
        public void Add(Employee employee)
        {
            _employeeList.Add(employee);

        }
        public void Update(Employee employee, string firstName, string lastName, decimal annualSalary, char gender, bool isManager)
        {
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.AnnualSalary = annualSalary;
            employee.Gender = gender;
            employee.IsManger = isManager;
        }

        public void Delete(int index)
        {
            _employeeList.RemoveAt(index);
        }

        public int Find(int id)
        {
            int count = 0;

            foreach (Employee employee in _employeeList)
            {
                if (employee.Id == id)
                {
                    return count;
                }
                count++;
            }

            return -1;
        }
        public int Count()
        {
            return _employeeList.Count;
        }

        public IEnumerator GetEnumerator()
        {
            return _employeeList.GetEnumerator();
        }

    }
}
