using System;
using System.Linq;

namespace ExpenseApp
{
    public class ReportManager
    {
        private ExpenseTracker tracker;

        public ReportManager(ExpenseTracker tracker)
        {
            this.tracker = tracker;
        }

        public void Print()
        {
            Console.WriteLine("Report Module Ready");
        }
    }
}