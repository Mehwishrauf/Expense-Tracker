# ExpenseTracker

Lightweight console-based expense tracker built with C# and .NET 7. Provides simple CLI for adding, viewing, deleting and reporting expenses. Suitable as a learning project or small local utility.

## Features

- Add and store expenses (date, category, amount, notes)
- View all expenses
- Delete expenses
- Search expenses by category
- Generate a monthly report
- File-based persistence

## Requirements

- .NET 7 SDK
- Visual Studio 2022/2026 or any editor that supports .NET 7
- (Optional) Docker for containerized runs

## Setup

1. Clone the repository or copy the project folder to your machine.
2. Open the solution or project in Visual Studio or use the command line.

From the project root (where the `.csproj` is located):

```powershell
# Restore and build
dotnet restore
dotnet build
```

## Run

From the project folder:

```powershell
# Run the console app
dotnet run
```

When running, the program shows a menu where you can choose options to add, view, delete, search, and generate monthly reports.

## Run in Visual Studio

- Open the solution in Visual Studio and press `F5` or choose "Start Debugging".

## Docker (optional)

If you want to run the app inside a container and a `Dockerfile` is provided:

```powershell
# Build image
docker build -t expensetracker .
# Run container
docker run --rm -it expensetracker
```

## Project structure

- `Program.cs` - Entry point and CLI menu
- `ExpenseTracker.cs` - Core application logic and user interactions
- `Expense.cs` - Expense model
- `FileManager.cs` - File persistence helpers
- `ReportManager.cs` - Report generation logic
- `Dockerfile` - Optional container configuration

## Structure

Suggested project layout (root of the repository):

```
ExpenseTracker/                # repository root
├─ README.md                   # this file
├─ Dockerfile                  # optional container image
├─ ExpenseTracker.csproj       # project file (if present)
├─ Program.cs                  # application entry point
├─ Expense.cs                  # expense model
├─ ExpenseTracker.cs           # core CLI and logic
├─ FileManager.cs              # file persistence helpers
├─ ReportManager.cs            # report generation logic
├─ data/                       # optional folder for persisted files
│  └─ expenses.json            # example data file
└─ LICENSE                     # license (optional)
```

## Data

The app uses simple file-based persistence (see `FileManager.cs`). Back up or inspect the data files if needed.

## Contributing

Contributions are welcome. Open issues or submit pull requests. Keep changes small and focused.

## License

This project is provided under the MIT License. See `LICENSE` if present.
