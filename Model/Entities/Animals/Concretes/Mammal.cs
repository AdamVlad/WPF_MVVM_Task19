namespace Model.Entities.Animals.Concretes
{
    /// <summary>
    /// Класс Млекопитающие
    /// </summary>
    public class Mammal : AnimalBase
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название животного</param>
        public Mammal(string name) : base(name, "Млекопитающие")
        {
        }

        /// <summary>
        /// Пустой конструктор нужен для сериализации и дессериализации
        /// </summary>
        public Mammal() : this("Не определено")
        {
        }
    }
}
