using System;

namespace Model.Exceptions
{
    /// <summary>
    /// Исключение, предназначенное для сохранения базы данных с животными
    /// </summary>
    public class AnimalsSaverException : Exception
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="text">Сообщение</param>
        public AnimalsSaverException(string text) : 
            base("AnimalsSaverException: " + text)
        {
        }
    }
}
