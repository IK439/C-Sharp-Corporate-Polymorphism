# C-Sharp-Corporate-Polymorphism

## Overview

This project is a C# console application that demonstrates key **object-oriented programming (OOP) concepts**, including **inheritance**, **polymorphism**, **upcasting**, and **downcasting**.  

It models a simple corporate environment with different types of employees: **Engineer**, **Manager**, **Intern**, and **HR**. Each employee type has its own implementation of work behaviour and report submission, while sharing common functionality through the base **Employee** class.

---

## Features

- **Abstract Base Class**: `Employee` defines common methods like `ClockIn()`, `Work()`, and `SubmitDailyReport()`.  
- **Inheritance**: `Engineer`, `Manager`, `Intern`, and `HR` inherit from `Employee`.  
- **Polymorphism**: Overridden methods `Work()` and `SubmitDailyReport()` demonstrate dynamic behaviour.  
- **Upcasting**: Derived class objects (e.g., `Engineer`) are assigned to base class references (`Employee`).  
- **Downcasting**: Base class references are safely cast back to derived types using the `as` operator.  
- **List Iteration**: Employees are stored in a list and processed consistently to demonstrate uniform handling of different types.  

---

## Example Output

```
*** HR Test ***
Employee clocks in.
HR handles employee matters.
HR submits daily report.

*** Upcasting: Engineer to Employee ***
Engineer works on a project.
Engineer submits daily report.

*** Manager Test ***
Employee clocks in.
Manager oversees the project.
Manager submits daily report.

*** Intern Test ***
Employee clocks in.
Intern assists with the project.
Intern submits daily report.

*** Downcasting: Employee to Engineer ***
Engineer submits daily report.

*** Employee List Iteration ***
Employee clocks in.
Engineer works on a project.
Engineer submits daily report.

This is an Engineer.

Employee clocks in.
Manager oversees the project.
Manager submits daily report.

This is a Manager.

Employee clocks in.
Intern assists with the project.
Intern submits daily report.

This is an Intern.
```
