using System.Text;
using Animal.Infrastructure;
using Animal.Infrastructure.Entities;
using Animal.Infrastructure.Interfaces;
using Animal.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PostgresProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var host = Host.CreateDefaultBuilder()
                    .ConfigureServices((context, services) =>
                    {
                        services.AddDbContext<AppAnimalContext>(options =>
                            options.UseNpgsql("Host=ep-damp-cell-a2taj2ik-pooler.eu-central-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_TnC7QlaA3bWx"));

                        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                    })
                    .Build();

            using var scope = host.Services.CreateScope();

            var serviceProvider = scope.ServiceProvider;
            var specieRepository = serviceProvider.GetRequiredService<IRepository<Specie>>();

            // Додаємо новий запис
            specieRepository.Add(new Specie { Name = "Lion" });
            specieRepository.SaveChanges();

            // Отримуємо всі записи
            var species = specieRepository.GetAll();
            foreach (var specie in species)
            {
                Console.WriteLine($"ID: {specie.Id}, Name: {specie.Name}");
            }

            //Console.InputEncoding = Encoding.Unicode;
            //Console.OutputEncoding = Encoding.Unicode;
            //Console.WriteLine("Передаю вітання нашим друзям Броненосцям. :)!");
            //var context = new AppAnimalContext();

            //var myRep = new Repository<Specie>(context);
            //var entity = new Specie();
            //entity.Name = "Кіт";
            //myRep.Add(entity);
            //myRep.SaveChanges();
        }
    }
}
