using PersonalTracking.DB;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonalTracking
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (PersoneltrackingContext db = new PersoneltrackingContext())
            {
                // Perform database operations here. For example:
                // db.Employees.Add(new Employee { Name = "John Doe", Position = "Developer" });
                // db.SaveChanges();}
            }
        }
    }
}