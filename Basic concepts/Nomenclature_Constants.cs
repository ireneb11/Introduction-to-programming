using System.Text;
using System.Threading.Tasks;

namespace Nomenclature
{
    class Program
    {
        static void Main(string[] args)
        {
            // CONSTANTS IN UPPERCASE LETTERS
            const float GRAVITY= 9.8f;  // Gravitational force
            const int MAX_LIVES = 3;  // Maximum number of lives
            const int MAX_ENEMIES = 20;  // Maximun number of enemies
            const float ANIMATION_DURATION = 2.5f; // Duration of an animation 
            // Program code
            Console.WriteLine("Gravity: " + GRAVITY);
            Console.WriteLine("Max lives: " + MAX_LIVES);
            Console.WriteLine("Max enemies: " + MAX_ENEMIES);
            Console.WriteLine("Animation duration: " + ANIMATION_DURATION);
        }
        // Other functions
    }
}
