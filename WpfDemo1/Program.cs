using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfDemo1
{
    internal class Program
    {
        private static Label label;
        private static int count = 0;

        [STAThread]
        public static void Main(string[] args)
        {
            var app = new Application();
            var window = new Window();
            window.Title = "Hallo verden!";


            var button = new Button
            {
                Content = "Trykk på meg!"
            };
            label = new Label();
            button.Click += ButtonClick;

            var stackPanel = new StackPanel();
            stackPanel.Children.Add(label);
            stackPanel.Children.Add(button);


            window.Content = stackPanel;

            app.Run(window);
        }

        private static void ButtonClick(object sender, RoutedEventArgs e)
        {
            count++;
            label.Content = count;
        }
    }
}
