using Model.Repositories;
using Model.Services.DataReaders;
using Model.Services.DataSavers;

namespace Model.Factories
{
    /// <summary>
    /// Фабрика для создания репозитория
    /// </summary>
    public static class AnimalRepositoryFactory
    {
        /// <summary>
        /// Создает новый xml-репозиторий
        /// </summary>
        /// <returns></returns>
        public static IAnimalRepository GetXmlRepository()
        {
            return new AnimalRepository(new AnimalsFromXmlReader(), new AnimalsToXmlSaver());
        }
    }
}
