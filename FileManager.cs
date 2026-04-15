using System.Text.Json;

namespace ExpenseApp
{
    public class FileManager
    {

        private string filePath = "expenses.json";
        public void Save(List<Expense> expenses)
        {
            string json = JsonSerializer.Serialize(expenses, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath, json);
        }

        public List<Expense> Load()
        {
            if (!File.Exists(filePath))
                return new List<Expense>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Expense>>(json) ?? new List<Expense>();
        }
    }
}