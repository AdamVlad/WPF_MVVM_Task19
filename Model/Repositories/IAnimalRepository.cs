using System.Collections.Generic;

using Model.Entities.Animals;

namespace Model.Repositories
{
    /// <summary>
    /// Интерфей, описывающий поведение репозитория
    /// </summary>
    public interface IAnimalRepository
    {
        /// <summary>
        /// База данных, содержащая информацию о животных
        /// </summary>
        List<AnimalBase> DataBase { get; }

        /// <summary>
        /// Загрузка данных
        /// </summary>
        /// <param name="path">Путь к данным</param>
        void Load(string path);

        /// <summary>
        /// Сохранение данных
        /// </summary>
        /// <param name="path">Путь к данным</param>
        void Save(string path);

        /// <summary>
        /// Метод добавления нового животного в базу данных
        /// </summary>
        /// <param name="animal">Новое животное</param>
        void Add(AnimalBase animal);

        /// <summary>
        /// Метод удаления животного из базы данных
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        bool Remove(AnimalBase animal);
    }
}
