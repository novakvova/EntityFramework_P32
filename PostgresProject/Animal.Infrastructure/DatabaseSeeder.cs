using Animal.Infractructure.Entities;
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

        if (!context.Adopters.Any())
        {
            var adopters = new List<AdopterEntity>
            {
                new AdopterEntity
                {
                    FirstName = "Олександр",
                    LastName = "Петров",
                    PhoneNumber = "+380931234567",
                    Email = "petrov@example.com",
                    Address = "вул. Шевченка, 15, Київ"
                },
                new AdopterEntity
                {
                    FirstName = "Марія",
                    LastName = "Іваненко",
                    PhoneNumber = "+380671112233",
                    Email = "ivanenko@example.com",
                    Address = "вул. Лесі Українки, 20, Львів"
                }
            };
            context.Adopters.AddRange(adopters);
            context.SaveChanges();
        }

        if (!context.Employees.Any())
        {
            var employees =
                new List<EmployeeEntity>()
                {
                    new EmployeeEntity
                    {
                        FirstName = "Анна",
                        LastName = "Сидоренко",
                        Position = "Ветеринар",
                        HireDate = DateOnly.Parse("2022-06-01"),
                        ShelterLocationId = 1
                    },
                    new EmployeeEntity
                    {
                        FirstName = "Ігор",
                        LastName = "Коваленко",
                        Position = "Адміністратор",
                        HireDate = DateOnly.Parse("2023-02-15"),
                        ShelterLocationId = 2
                    }
                };
            context.Employees.AddRange(employees);
            context.SaveChanges();
        }

        if (!context.Adoptions.Any())
        {
            context.Adoptions.Add(new AdoptionEntity
            { AdopterId = 1, AnimalId = 1, AdoptedOn = DateTime.Parse("2024-02-01").ToUniversalTime() });
            context.SaveChanges();
        }

        if (!context.MedicalRecords.Any())
        {
            context.MedicalRecords.Add(new MedicalRecordEntity()
            {
                AnimalId = 1,
                VisitDate = DateTime.Parse("2024-02-05").ToUniversalTime(),
                Diagnosis = "Здоровий",
                Treatment = "Не потебує лікування",
                VetName = "Анна Сидоренко"
            });
            context.SaveChanges();
        }
    }
}
