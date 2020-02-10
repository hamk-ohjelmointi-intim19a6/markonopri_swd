using System;

namespace FizzBuzzHarjoitusConsole
{
    /**
     * FizzBuzz -harjoitus
     * ###################
     * 
     * -Jos luku on kolmella jaollinen, luvun sijaan tulostetaan "Fizz".
     * -Jos luku on viidellä jaollinen luvun sijaan tulostetaan "Buzz.
     * -Jos luku on kolmella sekä viidellä jaollinen, luvun sijaan tulostetaan "Fizzbuzz".
     * 
     * Esimerkki:
     * 
     * 1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,FizzBuzz,16,17,Fizz,19,Buzz ... aina lukuun 100 asti.
    **/
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz -harjoitus");
            Console.WriteLine("####################");
            Console.WriteLine("Anna Luku väliltä 0-100 ja paina Enter.");

            int kayttajanSyote = int.Parse(Console.ReadLine());

            var fizzBuzz = new FizzBuzz();
            var vastaus = fizzBuzz.Luku(kayttajanSyote);

            Console.WriteLine();
            Console.WriteLine(vastaus);
        }
    }
}
