using System.Windows;

using ViewModel.ViewModels;

namespace Task18.Views
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.DataContext = new MainVM<AddWindow>();
        }
    }
}
