using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;


namespace ShowCase
{
    public class StatusToEnabledConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return "Open".Equals(value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new System.NotImplementedException();
        }
    }


    public static class FrameworkElementFactoryExtension
    {
        public static void SetTextButton(this FrameworkElementFactory b) {

              b.SetValue(Button.ContentProperty, "Extention");

            //Row row;
            //bool c = true;
            //for (int i = 0; i < dataGrid_case.Items.Count; i++)
            //{
            //    c = true;
            //    row = dataGrid_case.Items[i] as Row;
            //    foreach (int u in listIdProduct)
            //    {
            //        if (row.Tag == u)
            //        {
            //            b.SetValue(Button.ContentProperty, "Cancel");
            //            c = false;
            //            break;
            //        }
            //    }

            //    if (c)
            //        b.SetValue(Button.ContentProperty, "To buy");
            //}
        }
    }
}
