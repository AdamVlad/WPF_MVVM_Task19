using System.Windows;

using Model.Factories;

using ViewModel.Tools;

using ViewModelInterLayer;

namespace ViewModel.ViewModels
{
    /// <summary>
    /// Класс, объединяющий представление и модель
    /// </summary>
    public class AddVM<TAddW> where TAddW : Window, new()
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public AddVM()
        {
            AddButtonClickCommand = new RelayCommand(AddButtonClick);
        }

        public RelayCommand AddButtonClickCommand { get; }

        public string AnimalType { get; set; }
        public string AnimalName { get; set; }

        /// <summary>
        /// Обработчик нажатия кнопки добавления животного
        /// </summary>
        private void AddButtonClick()
        {
            WindowService<TAddW>.NewAnimal = AnimalFactory.GetAnimal(AnimalType, AnimalName);
            WindowService<TAddW>.CloseActiveWindow();
        }
    }
}

