# HR-Payroll-System (C# Console-Application)
A simple HR Payroll Management System built using C# and .NET, demonstrating core object-oriented programming concepts, Repository pattern, Singleton pattern, and async operations.

📌 Features

-Employee management (Add, Update, Remove)

-Salary calculation (Basic + Allowance − Deduction)

-Search employees by:

   -Name

   -Designation

   -ID

   -Net Salary

-Asynchronous search support

-Clean architecture using interfaces and repository pattern

-Singleton repository implementation

-Enumeration for employee designations

🧱 Project Structure

HRPayrollSystem
│

├── Program.cs

├── Employee.cs

├── EmployeeRepository.cs

├── Designation.cs

├── IModel.cs

├── IRepository.cs

└── README.md

🧑‍💼 Employee Model

-Each employee contains:

-Id (GUID)

-Name

-Designation

-BasicSalary

-Allowance

-Deduction

-JoinDate

-NetSalary (calculated property)

🏷️ Designations
-public enum Designation
{
    Manager,
    Developer,
    HR,
    Accountant
}

🗂 Repository Pattern

-IRepository<T> defines standard CRUD and search operations

-EmployeeRepository implements:

    -Singleton pattern

    -In-memory data storage

    -LINQ-based searching

    -Async search using Task

🚀 How It Works

1.Employees are added to the repository

2.Data is stored in memory using a list

3.Users can:

   -View all employees

   -Update employee salary details

   -Remove employees

   -Search by keyword

4.Net salary is calculated automatically


⚙️ Technologies Used

      1.C#

      2..NET (Console Application)

      3.LINQ

      4.Async/Await

Object-Oriented Programming (OOP)

📦 How to Run

1.Clone the repository

git clone https://github.com/FarzanaTithi/HRPayrollSystem.git


2.Open in Visual Studio

3.Build and run the project

4.View output in the console

