using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.ViewModels
{
    /// <summary>
    /// Cell representing the entry for a budget line in a particular time period
    /// </summary>
    public class BudgetCell
    {
        public int BudgetLineId { get; set; }
        public List<TransactionEntry> TransactionEntries { get; set; }
    }

    public class TransactionEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
    }
}