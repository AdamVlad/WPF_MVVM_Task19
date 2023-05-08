using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

using Model.Entities.Animals;
using Model.Exceptions;

namespace Model.Services.DataSavers
{
    /// <summary>
    /// Класс, предоставляющий метод сохранения базы данных в xml-файл
    /// </summary>
    public class AnimalsToXmlSaver : IAnimalWriter
    {
        /// <summary>
        /// Сохраняет информацию с животными в xml-файл
        /// </summary>
        /// <param name="animals">Информация о животных</param>
        /// <param name="path">Путь к файлу</param>
        /// <exception cref="AnimalsSaverException">Исключение</exception>
        public void Save(List<AnimalBase> animals, string path)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<AnimalBase>));

                using (Stream fStream = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    xmlSerializer.Serialize(fStream, animals);
                }
            }
            catch(Exception e)
            {
                throw new AnimalsSaverException(e.Message);
            }
        }
    }
}
