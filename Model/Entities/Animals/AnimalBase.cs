using System.Xml.Serialization;

using Model.Entities.Animals.Concretes;

namespace Model.Entities.Animals
{
    /// <summary>
    /// Абстрактный класс AnimalBase
    /// </summary>
    [XmlInclude(typeof(Amphibian)), 
     XmlInclude(typeof(Bird)),
     XmlInclude(typeof(Mammal)),
     XmlInclude(typeof(NullAnimal))]
    public abstract class AnimalBase : IAnimal
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="name">Название животного</param>
        /// <param name="type">Тип животного</param>
        protected AnimalBase(string name, string type)
        {
            Type = type;
            Name = name;
        }

        /// <summary>
        /// Название животного
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Тип животного
        /// </summary>
        public string Name { get; set; }
    }
}
