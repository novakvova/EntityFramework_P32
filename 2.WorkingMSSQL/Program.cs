using System.Text;
using _2.WorkingMSSQL.Data;

namespace _2.WorkingMSSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            DatabaseSeeder.SeedData();
            //Console.WriteLine("Класна погода. Треба іти купатися. :)!");
        }
    }
}
