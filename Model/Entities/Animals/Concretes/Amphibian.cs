namespace Model.Entities.Animals.Concretes
{
    /// <summary>
    /// Класс Земноводные
    /// </summary>
    public class Amphibian : AnimalBase
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название животного</param>
        public Amphibian(string name) : base(name, "Земноводные")
        {
        }

        /// <summary>
        /// Пустой конструктор нужен для сериализации и дессериализации
        /// </summary>
        public Amphibian() : this("Не определено")
        {
        }
    }
}
