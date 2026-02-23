using System;
using System.Globalization;
using Avalonia.Data.Converters;
using RPGDiceProgram.Models;

namespace RPGDiceProgram.Views.ValueConverters {
    public class RPGDiceTypeStringConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is RPGDiceType diceType)
                return diceType.ToString().ToLower();
            return value?.ToString();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            if (value is string s && Enum.TryParse<RPGDiceType>(s, ignoreCase: true, out RPGDiceType result))
                return result;
            return value;
        }
    }
}
