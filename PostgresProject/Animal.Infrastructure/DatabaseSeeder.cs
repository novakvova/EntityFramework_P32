using Animal.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Animal.Infrastructure;

public class DatabaseSeeder(AppAnimalContext context)
{
    public void SeedData()
    {
        context.Database.Migrate();
        
        if(!context.ShelterLocations.Any())
        {
            var kyiv = new ShelterLocation
            {
                Adress = "вул. Центральна, 10, Київ",
                Name = "Центральний притулок",
                Phone = "+380501234567"
            };
            context.ShelterLocations.Add(kyiv);
            var lviv = new ShelterLocation
            {
                Adress = "вул. Західна, 5, Львів",
                Name = "Західний притулок",
                Phone = "+380671234567"
            };
            context.ShelterLocations.Add(lviv);
            context.SaveChanges();
        }

        if(!context.Species.Any())
        {
            context.Species.Add(new Specie { Name = "Кіт" });
            context.Species.Add(new Specie { Name = "Собака" });
            context.Species.Add(new Specie { Name = "Білка" });
            context.Species.Add(new Specie { Name = "Бобер" });
            context.SaveChanges();
        }

        if (!context.Animals.Any())
        {
            var cat = new AnimalEntity
            {
                Name = "Барсик",
                SpecieId = 1,
                Breed = "Персидський",
                Age = 3,
                Gender = "Чоловіча",
                ArrivalDate = DateOnly.FromDateTime(DateTime.Now.AddMonths(-2)),
                ShelterLocationId = 1
            };
            context.Animals.Add(cat);

            var dog = new AnimalEntity
            {
                Name = "Рекс",
                SpecieId = 2,
                Breed = "Німецька вівчарка",
                Age = 5,
                Gender = "Чоловіча",
                ArrivalDate = DateOnly.FromDateTime(DateTime.Now.AddYears(-1)),
                ShelterLocationId = 2
            };
            context.Animals.Add(dog);
            context.SaveChanges();
        }
    }
}
