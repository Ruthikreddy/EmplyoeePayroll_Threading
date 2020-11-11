using System;
using System.Collections.Generic;

namespace EmployeePayroll_Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails { EmpID = 1, EmpName = "Ruthik Reddy", PhoneNo = "5808983789", Address = "MBNR", Department = "IT", Gender = "Male" });
            employeeDetails.Add(new EmployeeDetails { EmpID = 2, EmpName = "Ishan", PhoneNo = "8521479630", Address = "HYD", Department = "HR", Gender = "Male" });
            employeeDetails.Add(new EmployeeDetails { EmpID = 3, EmpName = "Rohith", PhoneNo = "1234568798", Address = "Mumbai", Department = "SALES", Gender = "Male" });
            employeeDetails.Add(new EmployeeDetails { EmpID = 4, EmpName = "AXAR", PhoneNo = "9632587410", Address = "Chennai", Department = "HR", Gender = "Female" });
            EmployeePayrollOperations employeePayrolloperations = new EmployeePayrollOperations();
            // UC 1
            //DateTime startDateTime = DateTime.Now;
            //employeePayrolloperations.addEmployeeToPayroll(employeeDetails);
            //DateTime stopDateTime = DateTime.Now;
            //Console.WriteLine("Duration without thread: " + (stopDateTime - startDateTime));
            /// UC 2
            DateTime startDateTimeThread = DateTime.Now;
            employeePayrolloperations.addEmployeeToPayrollWithThread(employeeDetails);
            DateTime stopDateTimeThread = DateTime.Now;
            Console.WriteLine("Duration without thread: " + (stopDateTimeThread - startDateTimeThread));
            /// UC 4
            DateTime startDateTimeThreadSync = DateTime.Now;
            employeePayrolloperations.SynchronizingAddEmployeeWithThread(employeeDetails);
            DateTime stopDateTimeThreadSync = DateTime.Now;
            Console.WriteLine("Duration with thread: " + (stopDateTimeThreadSync - startDateTimeThreadSync));
        }
    }
}