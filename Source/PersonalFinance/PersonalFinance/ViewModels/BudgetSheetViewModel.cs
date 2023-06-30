using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace PersonalFinance.ViewModels
{
    public class BudgetSheetViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string testName;
        public string TestName
        {
            get => testName;
            set
            {
                testName = value;
                OnPropertyChanged();
            }
        }

        private List<TimePeriodColumn> timePeriodColumns = new();
        public List<TimePeriodColumn> TimePeriodColumns
        {
            get => timePeriodColumns;
            set
            {
                timePeriodColumns = value;
                OnPropertyChanged();
            }
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
