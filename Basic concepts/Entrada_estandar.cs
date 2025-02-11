using System.Text;
using System.Threading.Tasks;

namespace ImplicitConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your character's name: ");
            string? playerName = Console.ReadLine();
            Console.WriteLine($"Welcome, {playerName}! Your adventure begins now...");
        }
        //Other functions
    }
}
