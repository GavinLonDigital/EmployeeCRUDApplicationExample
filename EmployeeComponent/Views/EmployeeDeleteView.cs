using EmployeeComponent.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeComponent.Views
{
    public class EmployeeDeleteView
    {
        private Employees _employees;
        public EmployeeDeleteView(Employees employees)
        {
            _employees = employees;
        }

        public void RunDeleteView()
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the Id of the employee you wish to delete.");

            int id = Convert.ToInt32(Console.ReadLine());

            int index = _employees.Find(id);



            if (index != -1)
            {
                Employee employee = _employees[index];

                Console.WriteLine($"Are you sure you wish to delete employee with Id({employee.Id})? (y/n)");

                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Y)
                {
                    _employees.Delete(index);
                }

            }
            else
            {
                Console.Clear();
                Console.WriteLine(EmployeeCommonOutputText.GetApplicationHeading());
                Console.WriteLine(EmployeeCommonOutputText.GetEmployeeNotFoundMessage(id));
                Console.ReadKey();
            }
        }
    }
}
