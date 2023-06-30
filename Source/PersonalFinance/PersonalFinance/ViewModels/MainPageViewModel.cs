using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonalFinance.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private BudgetSheet budgetSheet = new();
        public BudgetSheet BudgetSheet
        {
            get => budgetSheet;
            set
            {
                budgetSheet = value;
                OnPropertyChanged();
            }
        }

        public void SetTimePeriod(DateTime start, DateTime end)
        {
            while (start.DayOfWeek != DayOfWeek.Monday)
            {
                start = start.AddDays(-1);
            }
            while (end.DayOfWeek != DayOfWeek.Sunday)
            {
                end = end.AddDays(-1);
            }

            var runningDate = start;
            var columns = new List<TimePeriodColumn>();
            while (runningDate < end)
            {
                var column = new TimePeriodColumn { StartDate = runningDate };
                column.Accounts.Add(new TimePeriodAccount
                {
                    AccountBalance = 1500,
                    InBudgetCells = new List<BudgetCell>
                    {
                        new BudgetCell { TransactionsTotal = 50 },
                        new BudgetCell { TransactionsTotal = 60 }
                    },
                    OutBudgetCells = new List<BudgetCell>
                    {
                        new BudgetCell { TransactionsTotal = 10 },
                        new BudgetCell { TransactionsTotal = 20 }
                    }
                });

                columns.Add(column);
                runningDate = runningDate.AddDays(7);
            }
            budgetSheet.TimePeriodColumns = columns;
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
