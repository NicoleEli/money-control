using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersonalFinance.ViewModels
{
    /// <summary>
    /// Cell representing the entry for a budget line in a particular time period
    /// </summary>
    public class BudgetCell : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int BudgetLineId { get; set; }
        public List<TransactionEntry> TransactionEntries { get; set; }

        public decimal TransactionsTotal { get; set; }  //TODO: make dynamic

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

    public class TransactionEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
    }
}