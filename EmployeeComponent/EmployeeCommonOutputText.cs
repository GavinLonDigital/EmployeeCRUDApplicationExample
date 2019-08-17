using System;
using System.Collections.Generic;
using System.Text;
using EmployeeComponent.Data;

namespace EmployeeComponent
{
    public static class EmployeeCommonOutputText
    {

        public static string GetColumnHeadings()
        {
            string id = "Id";
            string firstName = "First Name";
            string lastName = "Last Name";
            string annualSalary = "Annual Salary";
            string gender = "Gender";
            string manager = "Manager";

            string heading = $"{id.PadRight(6)}\t{firstName.PadRight(15)}\t{lastName.PadRight(15)}\t{annualSalary.PadRight(15)}\t{gender.PadRight(6)}\t{manager.PadRight(7)}\n";
            heading += $"{new string('_',6)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 15)}\t{new string('_', 6)}\t{new string('_', 7)}\n";

            return heading;
        }

        private static string GetUnderlineForHeading(string heading)
        {
            return new string('_', heading.Length -1);
        }

        public static string GetApplicationHeading()
        {
            string heading = "Employee CRUD Application\n";

            string underline = GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetInstructions()
        {
            return "[C] Create, [R] Read, [U] Update, [D] Delete, Press any other key to end session";

        }
        public static string GetCreateHeading()
        {
            string heading = "Add Employee\n";
            string underline = GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";

        }
        public static string GetEmployeeNotFoundMessage(int id)
        {
            return $"Could not find employee with Id({id}). Please press any key to return to the main view...";

        }
        public static string GetEmployeeRecordHeading(Employee employee)
        {
            string heading = $"Employee Details for {employee.FirstName} {employee.LastName} Id: {employee.Id}\n";
            string underline = GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }

        public static string GetUpdateHeading(Employee employee)
        {
            string heading = $"Update Employee Details for {employee.FirstName} {employee.LastName} Id: {employee.Id}\n";
            string underline = GetUnderlineForHeading(heading);

            return $"{heading}{underline}\n\n";
        }
        public static string GetUpdateViewAdditionalInstructions()
        {
            return "Note: a blank field will leave relevant field unmodified.\n";
        }

    }
}
