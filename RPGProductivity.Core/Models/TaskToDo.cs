namespace RPGProductivity.Core.Models;

public class TaskToDo
{
    public int Id
    {
        get; set;
    }

    public string Title
    {
        get; set;
    }

    public string Description
    {
        get; set;
    }

    public TaskDifficulty TaskDifficulty
    {
        get; set; 
    }

    public DateTime CreatedAt
    {
        get; set;
    }

    public TaskType TaskType
    {
        get; set;
    }

    public int SymbolCode
    {
        get; set;
    }

    public string SymbolName
    {
        get; set;
    }

    public char Symbol => (char)SymbolCode;

    public ICollection<TaskToDo> Details
    {
        get; set;
    }

    public string ShortDescription => $"Order ID: {Id}";

    public override string ToString() => $"{Title}";
}
