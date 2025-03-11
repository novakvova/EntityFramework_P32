using Animal.Infrastructure;
using Animal.Infrastructure.Interfaces;
using Animal.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace PostgresProject
{
    public static class DIConfiguration
    {
        public static IServiceProvider GetServiceProvider()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    //Прописумо налаштування для різних обєктів
                    services.AddDbContext<AppAnimalContext>(options =>
                        options.UseNpgsql("Host=ep-damp-cell-a2taj2ik-pooler.eu-central-1.aws.neon.tech;Database=neondb;Username=neondb_owner;Password=npg_TnC7QlaA3bWx"));

                    //Якщо у коді потрібно репозіторій, то на основі IRepository буде створюватися
                    //Repository
                    services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
                    services.AddScoped<ISpecieService, SpecieService>();
                    services.AddScoped<IAnimalService, AnimalService>();
                })
                .Build();

            //Створити об'єкт score, який згідно налаштувань може видавти різні обєкти по DI
            var score = host.Services.CreateScope();
            //Отримуємо провайдер, який може видавати потрібні нам об'єкти
            return score.ServiceProvider;
        }
    }
}
