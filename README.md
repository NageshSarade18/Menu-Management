Menu Management System 🛠️ Prerequisites Ensure you have the following installed:

.NET SDK

SQL Server

Git

Visual Studio with ASP.NET & Web Development workload

💻 Tech Stack Frontend: HTML, CSS, JavaScript

Backend: C# (ASP.NET Core MVC)

Database: SQL Server

📦 Steps to Run Locally 1️⃣ Clone the Repository

git clone https://github.com/NageshSarade18/Menu-Management.git
cd my-first-project
2️⃣ Set Up Database Open SQL Server Management Studio (SSMS).

Create a new database named Menu_Database.

Update the connection string in appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=Menu_Database;Trusted_Connection=True;"
}
3️⃣ Apply Migrations & Update Database Open Visual Studio and go to Tools → NuGet Package Manager → Package Manager Console

Run the following commands on Package Manager Console:

Add-Migration InitialCreate

Update-Database
