using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using RPGProductivity.Contracts.ViewModels;
using RPGProductivity.Core.Contracts.Services;
using RPGProductivity.Core.Models;

namespace RPGProductivity.ViewModels;

public partial class DailyTasksViewModel : ObservableRecipient, INavigationAware
{
    private readonly IDailyTasksService _sampleDataService;

    [ObservableProperty]
    private TaskToDo? selected;

    public ObservableCollection<TaskToDo> SampleItems { get; private set; } = new ObservableCollection<TaskToDo>();

    public DailyTasksViewModel(IDailyTasksService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        SampleItems.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetListDetailsDataAsync();

        foreach (var item in data)
        {
            SampleItems.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }

    public void EnsureItemSelected()
    {
        Selected ??= SampleItems.First();
    }
}
