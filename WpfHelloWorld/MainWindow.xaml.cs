using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfHelloWorld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly MainWindowViewModel model;
        public MainWindow()
        {
            model = new MainWindowViewModel();
            InitializeComponent();
            DataContext = model;
            model.Items.Add(new MainWindowViewModel
            {
                Name = "刘德华",
                Age = 10,
                Gender = "男",
                Score = 10

            });
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            model.Items.Add(new MainWindowViewModel
            {
                Name=model.Name,
                Age = model.Age,
                Gender = model.Gender,
                Score = model.Score,
            });
        }
    }

    public class MainWindowViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Score { get; set; }
        public ObservableCollection<MainWindowViewModel> Items { get; set; } = new ObservableCollection<MainWindowViewModel>();
    }

   
}
