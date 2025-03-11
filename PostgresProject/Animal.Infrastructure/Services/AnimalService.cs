using Animal.Infrastructure.Entities;
using Animal.Infrastructure.Interfaces;

namespace Animal.Infrastructure.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IRepository<AnimalEntity> _repository;
        private readonly IRepository<Specie> _specieRepository;

        public AnimalService(IRepository<AnimalEntity> repository, IRepository<Specie> specieRepository)
        {
            _repository = repository;
            _specieRepository = specieRepository;
        }

        public bool CreateAnimal(string name, string description, int specie_id)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Animal name cannot be empty.");
            if (!_specieRepository.GetQuery().Any(x => x.Id == specie_id))
                throw new ArgumentException("Specie by id not found.");
            if (string.IsNullOrWhiteSpace(description))
                throw new ArgumentException("Animal description cannot be empty.");

            if (!_repository.GetQuery().Any(x => x.Name == name))
            {
                _repository.Add(new AnimalEntity { Name = name, Specie = _specieRepository.GetById(specie_id), Description = description, SpecieId = specie_id });
                _repository.SaveChanges();
                Console.WriteLine("Animal added");
                return true;
            }
            Console.WriteLine("Animal with name {0} already exists.", name);
            return false;
        }

        public List<AnimalEntity> GetAllAnimals()
        {
            return _repository.GetAll().ToList();
        }

        public AnimalEntity? GetAnimalById(int id)
        {
            return _repository.GetById(id);
        }

        public bool UpdateAnimal(int id, string newName = "", string newDescription = "", int specie_id = 0)
        {
            var animal = _repository.GetById(id);
            if (animal == null)
                throw new ArgumentException("Animal not found.");
            if (specie_id > 0)
            {
                Specie specie = _specieRepository.GetById(specie_id);
                if (specie == null)
                    throw new ArgumentException("Specie by id not found.");
                animal.Specie = specie;
                animal.SpecieId = specie_id;
            }

            if (!string.IsNullOrWhiteSpace(newName))
            {
                if (!_repository.GetQuery().Any(x => x.Name == newName))
                    animal.Name = newName;
                else throw new ArgumentException("Animal with name {0} already exists.", newName);
            }
            if (!string.IsNullOrWhiteSpace(newDescription))
                animal.Description = newDescription;
            _repository.Update(animal);
            _repository.SaveChanges();
            Console.WriteLine("Animal updated");
            return true;
        }

        public bool DeleteAnimal(int id)
        {
            var animal = _repository.GetById(id);
            if (animal != null)
            {
                _repository.Delete(animal);
                _repository.SaveChanges();
                Console.WriteLine("Animal deleted");
                return true;
            }
            return true;
        }
    }
}
