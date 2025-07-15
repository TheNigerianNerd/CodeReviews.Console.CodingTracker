# 📘 Coding Tracker Console App

**Coding Tracker** is a .NET console application designed to let you track your coding sessions over time—recording dates, project names, time spent, and notes. It helps improve productivity, reflection, and consistency in your coding practice.

---

## 🛠️ Features

- **Record** coding sessions (date, project, duration, notes)
- **View** past sessions in styled console tables
- **Update** or **delete** entries
- **Seeded** with sample/mock data for initial testing
- Built with **C#**, **SQLite**, and **Spectre.Console**

---

## 🧱 Getting Started

### Prerequisites

- [.NET 8+ SDK](https://dotnet.microsoft.com/download)
- Visual Studio, VS Code, or another .NET IDE
- `appsettings.json` with your connection string

### Setup

1. Clone the repo:
   ```bash
   git clone https://github.com/TheNigerianNerd/CodeReviews.Console.CodingTracker.git
   cd CodeReviews.Console.CodingTracker
2. Add an appsettings.json:
   {
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=coding-tracker.db"
  }
}
3. Build and run:
   dotnet build
   dotnet run

The database is created automatically, along with seed data if it's empty.
🧠 How It Works
Entry Point: Program.cs

    Loads appsettings.json

    Initializes shared connectionString

    Builds and seeds database via Data.CreateDatabase()

    Starts console menu via SessionFunctions.MainMenu()

Core Components
Class / File	Responsibility
Data	Creates tables & seeds demo session data
SessionFunctions	CRUD operations and user menu with Spectre.Console
Session (Record Type)	Data model for coding sessions
🎛️ Menu Options

When running the app, you'll be prompted with:

    Add Session: Log a new coding session

    View Sessions: Display all sessions

    Update Session: Modify date, duration, or notes

    Delete Session: Remove a session

    Quit: Exit the app
    
| Id | Date        | Project        | Duration (min) | Notes               |
|----|-------------|----------------|----------------|---------------------|
| 1  | Jul 10, 2025| Habit Tracker  | 45             | Added Update & Delete features |
| 2  | Jul 11, 2025| Coding Tracker | 60             | Seed data & CLI menu |

🚀 Why Build This?

    Practice ADO.NET with raw SQL and SQLite

    Learn Spectre.Console for CLI app styling

    Manage dependencies manually (DI-style pattern)

    Gain hands-on experience with CRUD operations

## 🔄 Project Structure

```
CodingTracker/
├── Program.cs
├── Data.cs
├── SessionFunctions.cs
├── Session.cs
├── appsettings.json
├── bin/
├── obj/
└── README.md
```




❤️ Contribution

Feel free to:

    Add filtering or search features

    Implement data export (CSV/JSON)

    Switch to EF Core

    Add unit/integration tests

    Build a GUI version (MAUI, WinForms, etc.)

🧑‍💻 Author

Oche “TheNigerianNerd” Edache
💻 GitHub
