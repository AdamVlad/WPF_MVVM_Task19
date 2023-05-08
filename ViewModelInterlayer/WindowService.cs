using System.Windows;

using Model.Entities.Animals;

namespace ViewModelInterLayer
{
    /// <summary>
    /// Сервис для создания нового окна
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public static class WindowService<T> where T : Window, new()
    {
        public static AnimalBase NewAnimal { get; set; }

        public static void ShowNewWindow()
        {
            _activeWindow = new T();
            _activeWindow.ShowDialog();
        }

        public static void CloseActiveWindow()
        {
            _activeWindow?.Close();
        }

        private static T _activeWindow;
    }
}
