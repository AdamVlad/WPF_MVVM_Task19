using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

using Model.Entities.Animals;
using Model.Exceptions;

namespace Model.Services.DataReaders
{
    /// <summary>
    /// Класс, предоставляющий метод чтения данных из xml-файла
    /// </summary>
    public class AnimalsFromXmlReader : IAnimalReader
    {
        /// <summary>
        /// Считывает данные из xml-файла
        /// </summary>
        /// <param name="path">Пусть к файлу</param>
        /// <returns>Список с информацией о животных</returns>
        /// <exception cref="AnimalsReaderException">Исключение</exception>
        public List<AnimalBase> Read(string path)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<AnimalBase>));

                using (Stream fStream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    return xmlSerializer.Deserialize(fStream) as List<AnimalBase>;
                }
            }
            catch(Exception e)
            {
                throw new AnimalsReaderException(e.Message);
            }
        }
    }
}
