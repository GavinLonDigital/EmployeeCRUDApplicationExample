using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using EmployeeComponent.Data;

namespace EmployeeComponent.Views
{
    public class EmployeeCreateView
    {
        private Employees _employees;

        public EmployeeCreateView(Employees employees)
        {
            _employees = employees;
        }

        public void RunCreateView()
        {
            string firstName = null;
            string lastName = null;
            decimal annualSalary = 0;
            char gender = '\0';
            bool isManager = false;

            Console.Clear();

            Console.WriteLine(EmployeeCommonOutputText.GetApplicationHeading());

            Console.WriteLine();
            Console.WriteLine(EmployeeCommonOutputText.GetCreateHeading());

            Console.Write("First Name: ");
            firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            lastName = Console.ReadLine();

            Console.Write("Annual Salary: ");
            annualSalary = decimal.Parse(Console.ReadLine(),NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);

            Console.Write("Gender (m/f): ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Manager (true/false): ");
            isManager = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Please press the [S] key to save the new employee record to the system or any other key to cancel.");

            ConsoleKey consoleKey = Console.ReadKey().Key;

            if (consoleKey == ConsoleKey.S)
            {
                _employees.Add(EmployeeObjectFactory.CreateNewEmployeeObject(firstName,lastName,annualSalary,gender,isManager));
            }
        }
    }
}

