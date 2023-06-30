using PersonalFinance.ViewModels;
using System.Collections.ObjectModel;

namespace PersonalFinance;

public partial class MainPage : ContentPage
{
    int count = 0;

    public ObservableCollection<DateTime> ColumnStartDates { get; set; } = new ObservableCollection<DateTime>();

    private MainPageViewModel ViewModel { get => BindingContext as MainPageViewModel; set => BindingContext = value; }

    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();
        ViewModel = viewModel;
        ViewModel.SetTimePeriod(new DateTime(2023, 01, 02), new DateTime(2023, 12, 31));
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        count++;

        if (count == 1)
            CounterBtn.Text = $"Clicked {count} time";
        else
            CounterBtn.Text = $"Clicked {count} times";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}

