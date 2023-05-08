using Model.Entities.Animals;
using Model.Entities.Animals.Concretes;

namespace Model.Factories
{
    /// <summary>
    /// Фабрика для создания нового животного
    /// </summary>
    public static class AnimalFactory
    {
        /// <summary>
        /// Создает новое животное по заданным параметрам
        /// </summary>
        /// <param name="animalType">Тип животного</param>
        /// <param name="animalName">Название животного</param>
        /// <returns>Новое животное</returns>
        public static AnimalBase GetAnimal(
            string animalType,
            string animalName)
        {
            switch (animalType)
            {
                case "Птицы": return new Bird(animalName);
                case "Земноводные": return new Amphibian(animalName);
                case "Млекопитающие": return new Mammal(animalName);

                default: return new NullAnimal();
            }
        }
    }
}
