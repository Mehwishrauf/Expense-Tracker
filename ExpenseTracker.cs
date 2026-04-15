using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpenseApp
{
    public class ExpenseTracker
    {
        private List<Expense> expenses;
        private FileManager fileManager = new FileManager();

        public ExpenseTracker()
        {
            expenses = fileManager.Load(); // 🔥 LOAD ON START
        }

        public void AddExpense()
        {
            Console.WriteLine("\n--- ADD EXPENSE ---");

            Console.Write("Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine() ?? "0");

            Console.Write("Category: ");
            string category = Console.ReadLine() ?? "";

            Console.Write("Date (yyyy-mm-dd): ");
            DateTime date = Convert.ToDateTime(Console.ReadLine() ?? DateTime.Now.ToString());

            expenses.Add(new Expense
            {
                Amount = amount,
                Category = category,
                Date = date
            });

            fileManager.Save(expenses); // 🔥 SAVE
            Console.WriteLine("✅ Saved to file!");
        }

        public void ViewExpenses()
        {
            Console.WriteLine("\nID | Date       | Category   | Amount");
            Console.WriteLine("--------------------------------------");

            int i = 0;
            foreach (var e in expenses)
            {
                Console.WriteLine($"{i++}  | {e.Date:yyyy-MM-dd} | {e.Category,-10} | {e.Amount}");
            }
        }

        public void DeleteExpense()
        {
            ViewExpenses();

            Console.Write("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine() ?? "0");

            if (id >= 0 && id < expenses.Count)
            {
                expenses.RemoveAt(id);
                fileManager.Save(expenses); // 🔥 SAVE AFTER DELETE
                Console.WriteLine("❌ Deleted & Updated file!");
            }
        }

        public void SearchByCategory()
        {
            Console.Write("Category: ");
            string cat = (Console.ReadLine() ?? "").ToLower();

            var result = expenses.Where(e => (e.Category ?? "").ToLower() == cat);

            foreach (var e in result)
            {
                Console.WriteLine($"{e.Date:yyyy-MM-dd} | {e.Category} | {e.Amount}");
            }
        }

        public void MonthlyReport()
        {
            var data = expenses.Where(e =>
                e.Date.Month == DateTime.Now.Month &&
                e.Date.Year == DateTime.Now.Year);

            double total = 0;

            foreach (var e in data)
            {
                Console.WriteLine($"{e.Date:yyyy-MM-dd} | {e.Category} | {e.Amount}");
                total += e.Amount;
            }

            Console.WriteLine($"\n💰 Total: {total}");
        }
    }
}