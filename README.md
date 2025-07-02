# ZP Payroll Management System (WinForms)

A C# Windows Forms-based payroll management system tailored for Zilla Parishad (ZP) and similar government administrative bodies. This desktop application enables efficient handling of employee records, salary computation, hospital registrations, and medical bill tracking.

---

## 🧰 Features

- 👥 Employee record management
- 🏥 Hospital and doctor master forms
- 🧾 Payroll calculation with tax and allowance integration
- 🏡 Family member registration
- 🏛️ Head/Sub office registrations
- 📜 Service history tracking
- 📄 Payslip and report generation using iTextSharp
- 🔐 Role-based login system
- 🌐 MySQL database integration

---

## 🏗️ Tech Stack

| Component         | Technology                            |
|-------------------|----------------------------------------|
| Language          | C#                                     |
| Framework         | .NET Framework 3.5                     |
| UI Framework      | Windows Forms                          |
| Database          | MySQL                                  |
| PDF Generator     | [iTextSharp](https://github.com/itext/itextsharp) |
| JSON Handling     | Newtonsoft.Json                        |
| API Handling      | Custom HTTP API consumption (WinForms) |

---

## 📂 Project Structure

ZP-payroll-management-/
├── menuMasters/ # Masters: Employee, Disease, Hospital, etc.
├── regMasters/ # Registration forms (Emp, Hospital, Family, etc.)
├── sysBase/ # System files: Login, API consumption, Dashboard
├── Resources/ # Icons and images
├── Properties/ # App settings, resources
├── WinApp.csproj # Project configuration file
└── Program.cs # Application entry point

## 🛠️ Setup Instructions
 ### Prerequisites
  Visual Studio (2010 or newer)
  .NET Framework 3.5
   MySQL Server
   Git

## Clone the Repo
<pre><code> git clone https://github.com/SiddhiKhandarkar/ZP-payroll-management-.git 
cd ZP-payroll-management- 
</code></pre>
## Database Setup
  Create a MySQL database.
  Import the .sql schema file (if available).
  Update your DB connection string inside the relevant code file

## Build & Run
Open the solution in Visual Studio.
Restore NuGet packages (manually if needed).
Build the solution.
Press F5 or click Start to run the app.

## 🚫 Known Dependencies
MySql.Data.dll
iTextSharp.dll
Newtonsoft.Json.dll
These might be located under bin/Debug/ or should be restored using NuGet. If not, you’ll need to manually add them via "Add Reference".

## 🧑‍💻 Author
Siddhi Khandarkar

## 📜 License
This project is licensed under the MIT License.
You may modify or redistribute according to the terms of the license.

## 🤝 Contributing
Contributions are welcome!

Fork the repo
Create a new branch (git checkout -b feature-name)
Commit your changes (git commit -m "Add cool feature")
Push to the branch (git push origin feature-name)
Open a pull request

## ❓ Support
Have questions or run into issues?
Open an issue on GitHub
Or start a discussion if you're unsure
Thanks for checking out this project! 👩‍💻👨‍💻
