using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string? yourName = null;

            Console.WriteLine("Welcome to the game!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Write("Enter your character's name: ");
            yourName = Console.ReadLine();

            Console.WriteLine($"Welcome, {yourName}! Your adventure begins now!");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Loanding...");
        }
    }
}
