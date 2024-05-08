using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using RPGProductivity.Core.Models;

namespace RPGProductivity.Views;

public sealed partial class DailyTasksDetailControl : UserControl
{
    public TaskToDo? ListDetailsMenuItem
    {
        get => GetValue(ListDetailsMenuItemProperty) as TaskToDo;
        set => SetValue(ListDetailsMenuItemProperty, value);
    }

    public static readonly DependencyProperty ListDetailsMenuItemProperty = DependencyProperty.Register("ListDetailsMenuItem", typeof(TaskToDo), typeof(DailyTasksDetailControl), new PropertyMetadata(null, OnListDetailsMenuItemPropertyChanged));

    public DailyTasksDetailControl()
    {
        InitializeComponent();
    }

    private static void OnListDetailsMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is DailyTasksDetailControl control)
        {
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
