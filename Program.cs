using System;

namespace ExpenseApp
{
    class Program
    {
        static ExpenseTracker tracker = new ExpenseTracker();

        static void Main()
        {
            while (true)
            {
                ShowMenu();

                Console.Write("\n Enter your choice: ");
                string choice = Console.ReadLine() ?? "";

                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        tracker.AddExpense();
                        Pause();
                        break;

                    case "2":
                        tracker.ViewExpenses();
                        Pause();
                        break;

                    case "3":
                        tracker.DeleteExpense();
                        Pause();
                        break;

                    case "4":
                        tracker.SearchByCategory();
                        Pause();
                        break;

                    case "5":
                        tracker.MonthlyReport();
                        Pause();
                        break;

                    case "6":
                        Console.WriteLine(" Exiting system... Goodbye!");
                        return;

                    default:
                        Console.WriteLine(" Invalid choice! Try again.");
                        Pause();
                        break;
                }
            }
        }

        // 🎨 MENU UI
        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("        EXPENSE TRACKER SYSTEM     ");
            Console.WriteLine("====================================");
            Console.WriteLine("1️.  Add Expense");
            Console.WriteLine("2️.  View All Expenses");
            Console.WriteLine("3️.  Delete Expense");
            Console.WriteLine("4️.  Search by Category");
            Console.WriteLine("5️.  Monthly Report");
            Console.WriteLine("6️.  Exit");
            Console.WriteLine("====================================");
        }

        // ⏳ PAUSE SCREEN
        static void Pause()
        {
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}