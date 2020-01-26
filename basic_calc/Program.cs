using System;

namespace basic_calulator
{
    class Program
    { 
    static int yhteenLasku(int x, int y)    // Funktio yhteenlaskulle
    {
        return x + y;
    }
    static int vahennusLasku(int x, int y)  // Funktio vähennyslaskulle
    {
        return x - y;
    }
    static int kertoLasku(int x, int y)     // Funktio kertolaskulle
    {
        return x * y;
    }
    static int jakoLasku(int x, int y)     //Funktio jakolaskulle
    {
        return x / y;
    }

    
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on yksinkertainen laskin?\n");
            Console.WriteLine("Valitse toiminto neljästä vaihtoehdosta (1..4)\n\n");
            Console.WriteLine("1.Yhteenlasku\n2.Vähennyslasku\n3.kertolasku\n4.Jakolasku\n");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Anna ensimmäinen numero: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Anna vielä toinen numero: \n");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            if(userChoice == 1)
            {
                Console.WriteLine(yhteenLasku(numOne, numTwo));
            }
            else if(userChoice == 2)
            {
                Console.WriteLine(vahennusLasku(numOne, numTwo));
            }
            else if(userChoice == 3)
            {
                Console.WriteLine(kertoLasku(numOne, numTwo));
            }
            else if(userChoice == 4)
            {
                Console.WriteLine(jakoLasku(numOne, numTwo));
            }
            else
            {
                Console.WriteLine("Valintavirhe");
            }
        }
    }
}
