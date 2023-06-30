using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonalFinance.ViewModels
{
    public class TimePeriodAccount : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int AccountId { get; set; }
        public List<BudgetCell> InBudgetCells { get; set; }
        public List<BudgetCell> OutBudgetCells { get; set; }
        public decimal AccountBalance { get; set; }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
