using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RPGProductivity.Core.Models;

namespace RPGProductivity.Commands
{
    public class DeleteTaskCommand : ICommand
    {
        private readonly ObservableCollection<TaskToDo> tasks;

        public DeleteTaskCommand(ObservableCollection<TaskToDo> tasks)
        {
            this.tasks = tasks;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter) => true;
        public void Execute(object? parameter)
        {
            if (parameter is TaskToDo task)
            {
                // Remove the task from the collection
                tasks.Remove(task);
            }
        }
    }
}
