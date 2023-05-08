using System;
using System.Collections.Generic;

using Model.Entities.Animals;
using Model.Services.DataReaders;
using Model.Services.DataSavers;

namespace Model.Repositories
{
    /// <summary>
    /// Репозиторий, содержащий информацию о животных
    /// </summary>
    public class AnimalRepository : IAnimalRepository
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="animalReader">Объект для считывания данных</param>
        /// <param name="animalWriter">Объект для записи данных</param>
        public AnimalRepository(
            IAnimalReader animalReader,
            IAnimalWriter animalWriter)
        {
            _dataBase = new List<AnimalBase>();

            _animalReader = animalReader;
            _animalWriter = animalWriter;
        }

        /// <summary>
        /// База данных с животными
        /// </summary>
        public List<AnimalBase> DataBase => _dataBase;

        /// <summary>
        /// Загрузка данных
        /// </summary>
        /// <param name="path">Путь к данным</param>
        public void Load(string path)
        {
            _dataBase = _animalReader.Read(path);
        }

        /// <summary>
        /// Сохранение данных
        /// </summary>
        /// <param name="path">Путь к данным</param>
        public void Save(string path)
        {
            _animalWriter.Save(_dataBase, path);
        }

        /// <summary>
        /// Метод добавления нового животного в базу данных
        /// </summary>
        /// <param name="animal">Новое животное</param>
        /// <exception cref="ArgumentNullException">Исключение</exception>
        public void Add(AnimalBase animal)
        {
            if (animal == null) throw new ArgumentNullException();

            _dataBase.Add(animal);
        }

        /// <summary>
        /// Метод удаления животного из базы данных
        /// </summary>
        /// <param name="animal">Животное, которое требуется удалить</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">Исключение</exception>
        public bool Remove(AnimalBase animal)
        {
            if (animal == null) throw new ArgumentNullException();

            return _dataBase.Remove(animal);
        }

        private List<AnimalBase> _dataBase;

        private IAnimalReader _animalReader;

        private IAnimalWriter _animalWriter;
    }
}
