using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfHomeWork8
{
    class MyCommands        //библиотека команд
    {
        public static RoutedUICommand Bold { get; set; }
        public static RoutedUICommand Italic { get; set; }
        public static RoutedUICommand Underline { get; set; }
        public static RoutedCommand Black { get; set; }
        public static RoutedCommand Red { get; set; }
        static MyCommands()
        {
            InputGestureCollection inputs1 = new InputGestureCollection();
            inputs1.Add(new KeyGesture(Key.B, ModifierKeys.Control, "Ctrl+B"));
            Bold = new RoutedUICommand("Жирный", "Bold", typeof(MyCommands), inputs1);

            InputGestureCollection inputs2 = new InputGestureCollection();
            inputs2.Add(new KeyGesture(Key.I, ModifierKeys.Control, "Ctrl+I"));
            Italic = new RoutedUICommand("Наклонный", "Italic", typeof(MyCommands), inputs2);

            InputGestureCollection inputs3 = new InputGestureCollection();
            inputs3.Add(new KeyGesture(Key.U, ModifierKeys.Control, "Ctrl+U"));
            Underline = new RoutedUICommand("Подчеркнутый", "Underline", typeof(MyCommands), inputs3);

            Black = new RoutedCommand();
            Red = new RoutedCommand();
        }
    }
}