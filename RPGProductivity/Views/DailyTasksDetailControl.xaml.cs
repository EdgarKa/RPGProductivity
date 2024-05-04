using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using RPGProductivity.Core.Models;

namespace RPGProductivity.Views;

public sealed partial class DailyTasksDetailControl : UserControl
{
    public SampleOrder? ListDetailsMenuItem
    {
        get => GetValue(ListDetailsMenuItemProperty) as SampleOrder;
        set => SetValue(ListDetailsMenuItemProperty, value);
    }

    public static readonly DependencyProperty ListDetailsMenuItemProperty = DependencyProperty.Register("ListDetailsMenuItem", typeof(SampleOrder), typeof(DailyTasksDetailControl), new PropertyMetadata(null, OnListDetailsMenuItemPropertyChanged));

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
