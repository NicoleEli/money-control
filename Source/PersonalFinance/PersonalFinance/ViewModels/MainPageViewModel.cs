using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonalFinance.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private BudgetSheetViewModel budgetSheet = new();
        public BudgetSheetViewModel BudgetSheet
        {
            get => budgetSheet;
            set
            {
                budgetSheet= value;
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
                columns.Add(new TimePeriodColumn { StartDate = runningDate });
                runningDate= runningDate.AddDays(7);
            }
            budgetSheet.TimePeriodColumns = columns;
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
