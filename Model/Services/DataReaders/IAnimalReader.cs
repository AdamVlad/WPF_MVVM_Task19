using System.Collections.Generic;

using Model.Entities.Animals;

namespace Model.Services.DataReaders
{
    public interface IAnimalReader
    {
        List<AnimalBase> Read(string path);
    }
}
