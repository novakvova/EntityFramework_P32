using Animal.Infrastructure.Entities;

namespace Animal.Infrastructure.Interfaces
{
    public interface IAnimalService
    {
        bool CreateAnimal(string name, string description, int specie_id);
        List<AnimalEntity> GetAllAnimals();
        AnimalEntity? GetAnimalById(int id);
        bool UpdateAnimal(int id, string newName = "", string newDescription = "", int specie_id = 0);
        bool DeleteAnimal(int id);
    }
}
