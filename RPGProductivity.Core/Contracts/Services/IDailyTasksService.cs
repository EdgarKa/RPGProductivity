using RPGProductivity.Core.Models;

namespace RPGProductivity.Core.Contracts.Services;

// Remove this class once your pages/features are using your data.
public interface IDailyTasksService
{
    Task<IEnumerable<TaskToDo>> GetListDetailsDataAsync();
}
