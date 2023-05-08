namespace Model.Entities.Animals
{
    /// <summary>
    /// Интерфейс, описывающий поведение класса AnimalBase
    /// </summary>
    public interface IAnimal
    {
        /// <summary>
        /// Тип животного
        /// </summary>
        string Type { get; set; }

        /// <summary>
        /// Название животного
        /// </summary>
        string Name{ get; set; }
    }
}
