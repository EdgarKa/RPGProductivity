using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

using RPGProductivity.ViewModels;

namespace RPGProductivity.Views;

public sealed partial class DailyTasksPage : Page
{
    public DailyTasksViewModel ViewModel
    {
        get; set;
    }

    public DailyTasksPage()
    {
        ViewModel = App.GetService<DailyTasksViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
