using System.Text;
using System.Threading.Tasks;

namespace Nomenclature
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables en minuscula, en la segunda palabra la inicial va en mayunscula (camelCase)
            float jumpForce = 10.0f;
            int collectedCoins = 200;
            int enemyCount = 10;
            float frameTime = 0.016f; //16ms por frame (60FPS)
          
            // Program code
            Console.WriteLine("The player has a jump force of  " + jumpForce + ".");
            Console.WriteLine("The player has collected " + collectedCoins + " coins.");
            Console.WriteLine("There are " + enemyCount + " enemies in the level.");
            Console.WriteLine("The frame time is " + frameTime + " seconds.");
        }
        // Other functions
    }
}
