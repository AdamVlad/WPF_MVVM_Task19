using System;

namespace Model.Exceptions
{
    /// <summary>
    /// Исключение, предназначенное для чтения базы данных с животными
    /// </summary>
    public class AnimalsReaderException : Exception
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="text">Сообщение</param>
        public AnimalsReaderException(string text) :
            base("AnimalsReaderException: " + text)
        {
        }
    }
}
