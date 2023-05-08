using System;
using System.Collections.ObjectModel;
using System.Windows;

using ViewModel.Constants;
using ViewModel.Tools;

using Model.Entities.Animals;
using Model.Factories;
using Model.Repositories;
using Model.Exceptions;

using ViewModelInterLayer;

namespace ViewModel.ViewModels
{
    /// <summary>
    /// Класс, объединяющий представление и модель
    /// </summary>
    public class MainVM<TAddW> where TAddW : Window, new()
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public MainVM()
        {
            try
            {
                // Создаю репозиторий
                _animalsRepository = AnimalRepositoryFactory.GetXmlRepository();
                _animalsRepository.Load(AnimalsConstants.DatabasePath);

                // Инициализирую коллекцию, которая будет представленна в качестве
                // контекста для представления
                Animals = new ObservableCollection<AnimalBase>(_animalsRepository.DataBase);
            }
            catch (AnimalsReaderException e)
            {
                MessageBox.Show(e.Message);
                Application.Current.Shutdown();
            }

            // Инициализирую команды
            ChangeSelectedAnimalCommand = new RelayCommandT(ChangeSelectedAnimal);
            AddAnimalCommand = new RelayCommand(AddAnimal);
            RemoveAnimalCommand = new RelayCommand(Remove);
            SaveTableCommand = new RelayCommand(Save);
        }

        public ObservableCollection<AnimalBase> Animals { get; set; }

        public RelayCommandT ChangeSelectedAnimalCommand { get; }
        public RelayCommand AddAnimalCommand { get; }
        public RelayCommand RemoveAnimalCommand { get; }
        public RelayCommand SaveTableCommand { get; }

        /// <summary>
        /// Меняет выделенное животное
        /// </summary>
        /// <param name="parameter"></param>
        private void ChangeSelectedAnimal(object parameter)
        {
            _selectedAnimal = parameter as AnimalBase;
        }

        /// <summary>
        /// Добавляет новое животное
        /// </summary>
        public void AddAnimal()
        {
            try
            {
                // С помощью сервиса окон открываю новое диалоговое окно
                WindowService<TAddW>.ShowNewWindow();

                // Добавляю новое животное
                _animalsRepository.Add(WindowService<TAddW>.NewAnimal);
                Animals.Add(WindowService<TAddW>.NewAnimal);
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("Добавить новое животное не удалось\n\n" + e.Message);
            }
        }

        /// <summary>
        /// Удаляет выделенное животное
        /// </summary>
        private void Remove()
        {
            try
            {
                _animalsRepository.Remove(_selectedAnimal);
                Animals.Remove(_selectedAnimal);
            }
            catch (ArgumentNullException e)
            {
                MessageBox.Show("Ошибка при удалении животного\n\n" + e.Message);
            }
        }

        /// <summary>
        /// Метод, сохраняющий базу данных с информацией о животных
        /// </summary>
        private void Save()
        {
            try
            {
                _animalsRepository.Save(AnimalsConstants.DatabasePath);
                MessageBox.Show("Таблица успешно сохранена");
            }
            catch (AnimalsSaverException e)
            {
                MessageBox.Show("Не удалось сохранить таблицу\n\n" + e.Message);
            }
        }

        private IAnimalRepository _animalsRepository;

        private AnimalBase _selectedAnimal;
    }
}

