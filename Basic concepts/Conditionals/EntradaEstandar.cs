using System.Text;
using System.Threading.Tasks;

namespace Entrada_Estandar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your character's name: ");
            string? playerName = Console.ReadLine();
            Console.Write("Enter your character's age: ");
            int? age = Convert.ToInt32(Console.ReadLine());
            if (age >= 18)
            {
                Console.WriteLine($"You are {age} years old, so you can play");
                Console.WriteLine($"Welcome, {playerName}! Your adventure begins now...");
            }
            else
            {
                Console.WriteLine("Sorry, you are not old enough to play this game");
            }
        }
        // Other functions
    }
}
