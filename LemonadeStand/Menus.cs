using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LemonadeStand
{
    public class Menus
    {

        public static void StoreMenu()
        {
            int input;
            Console.WriteLine("Welcome to the Store! \n");
            Console.WriteLine("1. Buy Sugar \n");
            Console.WriteLine("2. Buy Lemons \n");
            Console.WriteLine("3. Buy Cups \n");
            Console.WriteLine("4. Buy Ice \n");
            Console.WriteLine("5. Leave Store \n");
            Console.ReadLine();
            
        }
        public static void InventoryMenu()
        {
            string input;
            Console.WriteLine("Inventory \n");
            Console.WriteLine("You have" + " Sugar \n");
            Console.WriteLine("You have " + " Lemons \n");
            Console.WriteLine("You have " + " Cups \n");
            Console.WriteLine("You have " + " Ice \n");
            Console.WriteLine("Would you like to change your recipe?");
            Console.ReadLine();
            
        }
        public static void ForecastMenu()
        {
            string input;
            Console.WriteLine("This is this weeks forecast! \n");
            Console.WriteLine("Sunday " + " Degrees and " + "\n");
            Console.WriteLine("Monday " + " Degrees and " + "\n");
            Console.WriteLine("Tuesday " + " Degrees and " + "\n");
            Console.WriteLine("Wednesday " + " Degrees and " + "\n");
            Console.WriteLine("Thursday " + " Degrees and " + "\n");
            Console.WriteLine("Friday " + " Degrees and " + "\n");
            Console.WriteLine("Saturday " + " Degrees and " + "\n");
            Console.WriteLine("Would you like to go back to the main menu?");
            input = Console.ReadLine();
        }
        public static void MainMenu()
        {
            Console.WriteLine("Welcome to the main menu! \n");
            Console.WriteLine("1. See inventory \n");
            Console.WriteLine("2. See forecast \n");
            Console.WriteLine("3. Go to store \n");
            Console.WriteLine("4. Start game \n");
            int.Parse(Console.ReadLine());
        }
        public static void RecipeMenu()
        {
            Console.WriteLine("Perfect your recipe here \n");
            Console.WriteLine("Enter how many cups of sugar \n");
            string sugarAmount = Console.ReadLine();
            Console.WriteLine("Enter how many lemons \n");
            Console.ReadLine();
            Console.WriteLine("Enter number of ice cubes \n");
            Console.ReadLine();

        }
        public static string GetString(string input)
        {
            Console.WriteLine(input);
            string result = Console.ReadLine();
            return result;
        }
    }
    
}