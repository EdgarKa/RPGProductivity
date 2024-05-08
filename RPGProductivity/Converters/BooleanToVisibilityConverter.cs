﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Data;

namespace RPGProductivity.Converters;
public class BooleanToVisibilityConverter : IValueConverter
{
    public BooleanToVisibilityConverter()
    {
    }

    public object Convert(object value, Type targetType, object parameter, string language) => value is bool boolValue && boolValue ? Visibility.Collapsed : Visibility.Visible;
    public object ConvertBack(object value, Type targetType, object parameter, string language) => throw new NotImplementedException();
}
