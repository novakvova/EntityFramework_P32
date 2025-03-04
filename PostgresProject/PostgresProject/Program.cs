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
            entity.Name = "Кіт";
            myRep.Add(entity);
            myRep.SaveChanges();
        }
    }
}
