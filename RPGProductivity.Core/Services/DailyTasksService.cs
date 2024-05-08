using RPGProductivity.Core.Contracts.Services;
using RPGProductivity.Core.Models;

namespace RPGProductivity.Core.Services;

public class DailyTasksService : IDailyTasksService
{
    private List<TaskToDo> _allDailyTasks;

    public DailyTasksService()
    {
    }

    private static IEnumerable<TaskToDo> AllToDoTasks()
    {
        return new List<TaskToDo>()
        {
            new()
            {
                Id = 1,
                Title = "Title1",
                Description = "Description1",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 2,
                Title = "Title2",
                Description = "Description2",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 3,
                Title = "Title3",
                Description = "Description3",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
        };
    }

    public async Task<IEnumerable<TaskToDo>> GetListDetailsDataAsync()
    {
        _allDailyTasks ??= new List<TaskToDo>(AllToDoTasks());

        await Task.CompletedTask;
        return _allDailyTasks;
    }
}
