using System.Text;
using Animal.Infrastructure;
using Animal.Infrastructure.Entities;
using Animal.Infrastructure.Services;

namespace PostgresProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Передаю вітання нашим друзям Броненосцям. :)!");
            var context = new AppAnimalContext();

            var myRep = new Repository<Specie>(context);
            var entity = new Specie();
            entity.Name = "Кіт мурків";
            myRep.Add(entity);
            myRep.SaveChanges();

            var list = myRep.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine($"----{item.Name}------");
            }
        }
    }
}
