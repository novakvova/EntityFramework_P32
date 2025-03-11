using System.Text;
using Animal.Infrastructure.Interfaces;
using Animal.Infrastructure.Models.Animal;
using Microsoft.Extensions.DependencyInjection;

namespace PostgresProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            var sp = DIConfiguration.GetServiceProvider();
            Console.WriteLine("Передаю вітання нашим друзям Броненосцям. :)!");
            var specieService = sp.GetService<ISpecieService>();
            var animalService = sp.GetService<IAnimalService>();
            //try
            //{
            //    var model = new AnimalCreateModel
            //    {
            //        Name = "Зелеиий бобер",
            //        Description = "Весною стає зелений",
            //        SpecieId = 14
            //    };

            //    animalService.Create(model);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Щось пішло не так {ex.Message}");
            //}


            var list = animalService.GetAll();
            foreach (var animal in list)
            {
                Console.WriteLine($"{animal.Id}\t{animal.Name}\t{animal.SpecieName}");
            }



            //try
            //{
            //    specieService.CreateSpecie("Кiт");
            //    specieService.CreateSpecie("Собака");
            //    specieService.CreateSpecie("Білка");
            //    specieService.CreateSpecie("Хом'як");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Виникла проблема {ex.Message}");
            //}

            //var list = specieService.GetAllSpecies();
            //foreach (var item in list)
            //{
            //    Console.WriteLine($"---{item.Id}-{item.Name}------");
            //}




        }
    }
}
