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
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            var sp = DIConfiguration.GetServiceProvider();
            Console.WriteLine("Передаю вітання нашим друзям Броненосцям. :)!");

            var specieService = sp.GetService<ISpecieService>();
            specieService.CreateSpecie("Коти мурчик");
            var list = specieService.GetAllSpecies();
            foreach (var item in list)
            {
                Console.WriteLine($"----{item.Name}------");
            }
        }
    }
}
