
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
    public class FizzBuzz
    {
        public FizzBuzz()
        {
        }

        public string Luku(int syote)
        {
            if (OnkoJaollinenViidellätoista(syote))
            {
                return "FizzBuzz";
            }
            if (OnkoJaollinenKolmella(syote))
            {
                return "Fizz";
            }
            if (OnkoJaollinenViidellä(syote))
            {
                return "Buzz";
            }

            return syote.ToString();
        }

        private bool OnkoJaollinenViidellätoista(int syote)
        {
            return OnkoJaollinenKolmella(syote) && OnkoJaollinenViidellä(syote);
        }

        private bool OnkoJaollinenKolmella(int syote)
        {
            return syote % 3 == 0;
        }

        private bool OnkoJaollinenViidellä(int syote)
        {
            return syote % 5 == 0;
        }
    }
}