using System.Collections.Generic;

using Model.Entities.Animals;

namespace Model.Services.DataSavers
{
    public interface IAnimalWriter
    {
        void Save(List<AnimalBase> animals, string path);
    }
}
