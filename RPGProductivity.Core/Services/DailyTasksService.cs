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
            new()
            {
                Id = 4,
                Title = "Title4",
                Description = "Description4",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 5,
                Title = "Title5",
                Description = "Description5",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 6,
                Title = "Title6",
                Description = "Description6",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 7,
                Title = "Title7",
                Description = "Description7",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 8,
                Title = "Title8",
                Description = "Description8",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 9,
                Title = "Title9",
                Description = "Description9",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 10,
                Title = "Title10",
                Description = "Description10",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 11,
                Title = "Title11",
                Description = "Description11",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 12,
                Title = "Title12",
                Description = "Description12",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 13,
                Title = "Title13",
                Description = "Description13",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 14,
                Title = "Title14",
                Description = "Description14",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 15,
                Title = "Title15",
                Description = "Description15",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 16,
                Title = "Title16",
                Description = "Description16",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 17,
                Title = "Title17",
                Description = "Description17",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            },
            new()
            {
                Id = 18,
                Title = "Title18",
                Description = "Description18",
                CreatedAt = DateTime.Now,
                TaskType = TaskType.Daily,
                SymbolCode = 57737,
                SymbolName = "Audio",
            }
        };
    }

    public async Task<IEnumerable<TaskToDo>> GetListDetailsDataAsync()
    {
        _allDailyTasks ??= new List<TaskToDo>(AllToDoTasks());

        await Task.CompletedTask;
        return _allDailyTasks;
    }
}
