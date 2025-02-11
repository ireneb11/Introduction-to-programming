using System.Text;
using System.Threading.Tasks;

namespace Nomenclature
{
     class Program
    {
        static void Main(string[] args)
        {
            // Variables en minuscula, en la segunda palabra la inicial va en mayunscula (camelCase)
            float playerSpeed = 5.5f;
            int ammoCount = 30;
            bool isJumping = false;
            string weaponName = "Riffle";
            // Program code
            Console.WriteLine("Player Speed: " + playerSpeed);           
            Console.WriteLine("Ammo Count: " + ammoCount);
            Console.WriteLine("Is Jumping: " + isJumping);
            Console.WriteLine("Weapon Name: " + weaponName);
        }
        // Other functions
    }
}
