using System.Windows;

using ViewModel.ViewModels;

namespace Task18.Views
{
    /// <summary>
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();

            this.DataContext = new AddVM<AddWindow>();
        }
    }
}
