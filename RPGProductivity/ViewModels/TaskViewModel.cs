using RPGProductivity.Core.Models;

namespace RPGProductivity.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        private readonly TaskToDo _taskToDo;

        public TaskViewModel(TaskToDo taskToDo)
        {
            _taskToDo = taskToDo;
        }

        public static TaskViewModel TaskToDoToVM(TaskToDo taskToDo)
        {
            //Title = taskToDo.Title;
            //Description = taskToDo.Description;
            //SymbolCode = taskToDo.SymbolCode;
            //SymbolName = taskToDo.SymbolName;

            return new TaskViewModel(taskToDo);
        }

        public int Id => _taskToDo.Id;

        public string Title
        {
            get => _taskToDo.Title;
            set
            {
                if (_taskToDo.Title != value)
                {
                    _taskToDo.Title = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string Description
        {
            get => _taskToDo.Description;
            set
            {
                if (_taskToDo.Description != value)
                {
                    _taskToDo.Description = value;
                    RaisePropertyChanged();
                }
            }
        }

        public TaskDifficulty TaskDifficulty
        {
            get => _taskToDo.TaskDifficulty;
            set
            {
                if (_taskToDo.TaskDifficulty != value)
                {
                    _taskToDo.TaskDifficulty = value;
                    RaisePropertyChanged();
                }
            }
        }

        public DateTime CreatedAt
        {
            get => _taskToDo.CreatedAt;
            set
            {
                if (_taskToDo.CreatedAt != value)
                {
                    _taskToDo.CreatedAt = value;
                    RaisePropertyChanged();
                }
            }
        }

        public TaskType TaskType
        {
            get => _taskToDo.TaskType;
            set
            {
                if (_taskToDo.TaskType != value)
                {
                    _taskToDo.TaskType = value;
                    RaisePropertyChanged();
                }
            }
        }

        public char Symbol => (char)SymbolCode;

        public int SymbolCode
        {
            get => _taskToDo.SymbolCode;
            set
            {
                _taskToDo.SymbolCode = value;
                RaisePropertyChanged();
            }
        }

        public string SymbolName
        {
            get => _taskToDo.SymbolName;
            set
            {
                _taskToDo.SymbolName = value;
                RaisePropertyChanged();
            }
        }
    }
}
