using System;
using MerkkijonoLaskinConsole;
using NUnit.Framework;


namespace MerkkijonoLaskinTests
{
    /**
    
        Merkkijonolaskimen testit.
    
    **/

    public class MerkkijonoLaskinTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //[ ] Tyhjä merkkinojo palauttaa nollan.

        [Test]
        public void TyhjaMerkkijonoPalauttaaNollan()
        {
            // Arrange
            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            // Act
            int vastaus = laskin.Laske("");

            // Assert
            Assert.AreEqual(0, vastaus);
        }

        //[ ] Yksi numero, laskin palauttaa annetun numeron arvon..
        [Test]
        public void PalauttaaYhdenNumeron()
        {
            // Arrange
            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            // Act
            int vastaus = laskin.Laske("1");

            // Assert
            Assert.AreEqual(1, vastaus);
        }

        //[ ] Kaksi numeroa, pilkulla erotettuna, palauttaa lukujen summan.
        [Test]
        public void PalauttaaKaksiNumeroaPilkullaErottaen()
        {
            // Arrange
            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            // Act
            int vastaus = laskin.Laske("2,5");

            // Assert
            Assert.AreEqual(7, vastaus);
        }

        //[ ] Toteuta ominaisuus, että numeroita voidaan antaa pilkulla erotettuna rajoittamaton määrä ja laskin palauttaa lukujen summan.
        [Test]
        public void PalauttaaUseanNumeronSumman()
        {
            // Arrange
            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            // Act
            int vastaus = laskin.Laske("1,2,3,4,5,6,7,8,9,10,100");

            // Assert
            Assert.AreEqual(155, vastaus);
        }
        //[ ] Toteuta ominaisuus, että pilkkujen tilalla voidaan käyttää newline merkintää lukujen erottimena pilkkujen sijaan. (newline = \n)
        //Esimerkiksi arvo "1\n2,3" palauttaisi summan 6.
        //Ei tarvitse tukea muotoa, jossa erottimet seuraavat toisiaan.Esimerkiksi "1,\n". Voidaan olettaa, ettei tällaisia syötteitä anneta.
        [Test]
        public void PalauttaaSummanMuttaKayttaaNewlineaEikaPilkkua()
        {
            // Arrange
            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            // Act
            int vastaus = laskin.Laske("6\n6");

            // Assert
            Assert.AreEqual(12, vastaus);
        }
        //[ ] Negatiivinen luku, pienempi kuin nolla, aiheuttaa virheen. (Exception)
        [Test]
        public void NegatiivinenLukuAiheuttaaVirheen()
        {
            // Arrange
            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            // Assert
            Assert.Throws<ApplicationException>(
               () => { laskin.Laske("-1"); });
         
        }
        //[ ] Luvut, jotka ovat yli 1000, ei huomioida yhteenlaskussa.
        [Test]
        public void LuvutJotkaYliTuhatEiHuomioidaSummassa()
        {
            // Arrange
            MerkkijonoLaskin laskin = new MerkkijonoLaskin();

            // Act
            int vastaus = laskin.Laske("1,2,3,1001,2002");

            // Assert
            Assert.AreEqual(6, vastaus);

        }
    }

}