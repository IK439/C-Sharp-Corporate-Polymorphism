using System;
using System.Collections.Generic;

namespace CorporatePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // Helper method to print a blank line / separator
            void PrintSeparator() => Console.WriteLine("\n---\n");

            // ===== HR Employee Test =====
            Employee hrRep = new HR();
            Console.WriteLine("*** HR Test ***");
            hrRep.ClockIn(); // Demonstrates base method
            hrRep.Work(); // Demonstrates override
            hrRep.SubmitDailyReport(); // Demonstrates override
            PrintSeparator();

            // ===== Upcasting Demonstration =====
            // Engineer object assigned to Employee reference (upcasting)
            Employee employee1 = new Engineer();
            Console.WriteLine("*** Upcasting: Engineer to Employee ***");
            employee1.Work(); // Calls overridden method
            employee1.SubmitDailyReport(); // Calls overridden method
            PrintSeparator();

            // ===== Manager and Intern Tests =====
            Employee employee2 = new Manager();
            Employee employee3 = new Intern();

            Console.WriteLine("*** Manager Test ***");
            employee2.ClockIn();
            employee2.Work();
            employee2.SubmitDailyReport();
            PrintSeparator();

            Console.WriteLine("*** Intern Test ***");
            employee3.ClockIn();
            employee3.Work();
            employee3.SubmitDailyReport();
            PrintSeparator();

            // ===== Downcasting Demonstration =====
            Engineer? engineer1 = employee1 as Engineer; // Safe downcast
            Console.WriteLine("*** Downcasting: Employee to Engineer ***");
            if (engineer1 != null)
            {
                engineer1.SubmitDailyReport();
                PrintSeparator();
            }
            else
            {
                Console.WriteLine("Downcasting failed using 'as' operator.");
                PrintSeparator();
            }

            // ===== Iterate over all employees in a uniform way =====
            List<Employee> employees = new List<Employee> { employee1, employee2, employee3 };
            Console.WriteLine("*** Employee List Iteration ***");
            foreach (Employee employee in employees)
            {
                employee.ClockIn();
                employee.Work();
                employee.SubmitDailyReport();
                PrintSeparator();

                // Identify employee type
                if (employee is Engineer)
                    Console.WriteLine("This is an Engineer.");
                else if (employee is Intern)
                    Console.WriteLine("This is an Intern.");
                else if (employee is Manager)
                    Console.WriteLine("This is a Manager.");

                PrintSeparator();
            }
        }
    }
}