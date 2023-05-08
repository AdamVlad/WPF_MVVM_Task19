namespace Model.Entities.Animals.Concretes
{
    /// <summary>
    /// Класс Птица
    /// </summary>
    public class Bird : AnimalBase
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название животного</param>
        public Bird(string name) : base(name, "Птицы")
        {
        }

        /// <summary>
        /// Пустой конструктор нужен для сериализации и дессериализации
        /// </summary>
        public Bird() : this("Не определено")
        {
        }
    }
}
