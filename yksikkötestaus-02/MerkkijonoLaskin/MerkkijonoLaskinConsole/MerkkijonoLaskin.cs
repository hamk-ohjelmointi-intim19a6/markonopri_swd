using System;

namespace MerkkijonoLaskinConsole
{
    // Merkkijonolaskin
    //#################
    /**
     * [ ] Tyhjä merkkinojo palauttaa nollan.
     * [ ] Yksi numero, laskin palauttaa annetun numeron arvon..
     * [ ] Kaksi numeroa, pilkulla erotettuna, palauttaa lukujen summan.
     * [ ] Toteuta ominaisuus, että numeroita voidaan antaa pilkulla erotettuna rajoittamaton määrä ja laskin palauttaa lukujen summan.
     * [ ] Toteuta ominaisuus, että pilkkujen tilalla voidaan käyttää newline merkintää lukujen erottimena pilkkujen sijaan. (newline = \n)
          Esimerkiksi arvo "1\n2,3" palauttaisi summan 6.
          Ei tarvitse tukea muotoa, jossa erottimet seuraavat toisiaan. Esimerkiksi "1,\n". Voidaan olettaa, ettei tällaisia syötteitä anneta.
     * [ ] Luvut, jotka ovat yli 1000, ei huomioida yhteenlaskussa.
     * [ ] Negatiivinen luku, pienempi kuin nolla, aiheuttaa virheen. (Exception)
    **/

    public class MerkkijonoLaskin
    {
        public MerkkijonoLaskin()
        {
        }

        public int Laske(string numerot)
        {
            if(string.IsNullOrEmpty(numerot))
            {
                return 0;
            }
            
            var yksittaisetNumerot = numerot.Split(',','\n');

            int summa = 0;

            const int vertailu = 1000;

            foreach (string numero in yksittaisetNumerot)
            {
                int NumYks = int.Parse(numero);
                
                if ( NumYks > vertailu)
                {
                    continue;
                }
                if (NumYks < 0)
                {
                    throw new ApplicationException("Numero ei voi olla negatiivinen. ");
                }
                
                summa += int.Parse(numero);
            }
            return summa;
            

        }
    }
}