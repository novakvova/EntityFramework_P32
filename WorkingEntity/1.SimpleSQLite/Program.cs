using System.Text;
using _1.SimpleSQLite.Data;
using _1.SimpleSQLite.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace _1.SimpleSQLite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            MyApplicationContext context = new MyApplicationContext();
            context.Database.Migrate(); //створює БД у тому місці де є exe файл

            foreach (var item in context.Categories)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}\t{item.Description}");
            }

            //Console.WriteLine("Вкажіть назву категорії:");
            //String catName = Console.ReadLine();
            //Category cat = new Category();
            //cat.Name = catName;

            //context.Categories.Add(cat);
            //context.SaveChanges();
            //Console.WriteLine($"Успішно збережно! Id =  {cat.Id}");


            //Console.WriteLine("Привіт коту:) Кіт герой");
        }
    }
}
