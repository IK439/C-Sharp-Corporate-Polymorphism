using System;

namespace CorporatePolymorphism
{
    public abstract class Employee
    {
        // Abstract method forces derived classes to implement report submission
        public abstract void SubmitDailyReport();

        // Virtual method can be overridden by derived classes
        public virtual void Work()
        {
            Console.WriteLine("Employee is working.");
        }

        // Base method for all employees
        public void ClockIn()
        {
            Console.WriteLine("Employee clocks in.");
        }
    }
}