using Animal.Infrastructure.Entities;

namespace Animal.Infrastructure;

public class DatabaseSeeder(AppAnimalContext context)
{
    public void SeedData()
    {
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
    }
}
