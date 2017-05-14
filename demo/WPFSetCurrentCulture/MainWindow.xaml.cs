using System;
using System.Threading;
using System.Windows;

namespace WPFSetCurrentCulture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Date.Text = DateTime.Today.ToLongDateString();
            var currentCulture = Thread.CurrentThread.CurrentCulture;
            this.Weekday.Text = currentCulture.DateTimeFormat.DayNames[(int)DateTime.Today.DayOfWeek]; 
        }
    }
}
