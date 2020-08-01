using Microsoft.VisualStudio.TestTools.UnitTesting;
using DevHobby.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevHobby.BLL.Tests
{
    [TestClass()]
    public class ProduktTests
    {
        [TestMethod()]
        public void PowiedzWitajTest()
        {
            //arrange 
            Produkt produkt = new Produkt
            {
                NazwaProduktu = "Biurko",
                Opis = "Czerwone biurko",
                ProduktId = 1
            };
            produkt.DostawcaProduktu.NazwaFirmy = "DevHobby";


            var oczekiwana = "Witaj Biurko (1): Czerwone biurko Dostepny od : ";
            //act

            var aktualna = produkt.PowiedzWitaj();
            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void PowiedzWitaj_SparametryzowanyKonstruktorTest()
        {
            //arrange 
            var produkt = new Produkt(1, "Biurko", "Czerwone biurko");

            var oczekiwana = "Witaj Biurko (1): Czerwone biurko Dostepny od : ";
            //act

            var aktualna = produkt.PowiedzWitaj();
            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void PowiedzWitaj_InicjalizatorObiektuTest()
        {
            //arrange 
            var produkt = new Produkt
            {
                ProduktId = 1,
                NazwaProduktu = "Biurko",
                Opis = "Czerwone Biurko"


            };


            var oczekiwana = "Witaj Biurko (1): Czerwone Biurko Dostepny od : ";
            //act

            var aktualna = produkt.PowiedzWitaj();
            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void Produkt_NullTest()
        {
            //arrange 
            Produkt produkt = null;



            string oczekiwana = null;
            //act

            var aktualna = produkt?.DostawcaProduktu?.NazwaFirmy;
            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void KonwersjaCaliNaMetrTest()
        {
            //arrange 

            var oczekiwana = 194.35;
            //act

            var aktualna = 5 * Produkt.CaliNaMetr;
            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod()]
        public void MinimalnaCena_DomyslnaTest()
        {
            //arrange 

            var produkt = new Produkt();
            var oczekiwana = 10.50m;

            //act

            var aktualna = produkt.MinimalnaCena;

            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void MinimalnaCena_KrzesloTest()
        {
            //arrange 

            var produkt = new Produkt(1, "Krzesło obrotowe", "opis");
            var oczekiwana = 120.99m;

            //act

            var aktualna = produkt.MinimalnaCena;

            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void NazwaProduktu_FormatTest()
        {
            //arrange 

            var produkt = new Produkt();
            produkt.NazwaProduktu = " Krzeslo obrotowe ";
            var oczekiwana = "Krzeslo obrotowe";
            //act
            var aktualna = produkt.NazwaProduktu;

            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void NazwaProduktu_ZaKrotkaTest()
        {
            //arrange 

            var produkt = new Produkt();
            produkt.NazwaProduktu = "Krz";
            string oczekiwana = null;
            string oczekiwanaWiadomosc = "Nazwa produktu musi być dłuższa niż 4 znaki";
            //act
            var aktualna = produkt.NazwaProduktu;
            var aktualnaWiadomosc = produkt.Wiadomosc;
            //assert

            Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwanaWiadomosc, aktualnaWiadomosc);
        }
        [TestMethod()]
        public void NazwaProduktu_ZaDlugaTest()
        {
            //arrange 

            var produkt = new Produkt();
            produkt.NazwaProduktu = "Krzeslo obrotowe zbyt dluga nazwa ";
            string oczekiwana = null;
            string oczekiwanaWiadomosc = "Nazwa produktu musi być krótsza niż 30 znaków";
            //act
            var aktualna = produkt.NazwaProduktu;
            var aktualnaWiadomosc=produkt.Wiadomosc;
            //assert

            Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwanaWiadomosc, aktualnaWiadomosc);
        }
        [TestMethod()]
        public void NazwaProduktu_PrawidlowaTest()
        {
            //arrange 

            var produkt = new Produkt();
            produkt.NazwaProduktu = " Krzeslo obrotowe ";
            string oczekiwana = "Krzeslo obrotowe";
            string oczekiwanaWiadomosc = null;
            //act
            var aktualna = produkt.NazwaProduktu;
            var aktualnaWiadomosc = produkt.Wiadomosc;
            //assert

            Assert.AreEqual(oczekiwana, aktualna);
            Assert.AreEqual(oczekiwanaWiadomosc, aktualnaWiadomosc);
        }

        [TestMethod()]
        public void Kategoria_WartoscDomyslnaTest()
        {
            //arrange 

            var produkt = new Produkt();
            
            string oczekiwana = "Informatyka";
            
            //act
            var aktualna = produkt.Kategoria;
            
            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod()]
        public void Kategoria_NowaWartoscTest()
        {
            //arrange 

            var produkt = new Produkt();
            produkt.Kategoria = "Geografia";
            string oczekiwana = "Geografia";

            //act
            var aktualna = produkt.Kategoria;

            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void Numer_WartoscDomyslnaTest()
        {
            //arrange 

            var produkt = new Produkt();
           
            var oczekiwana = 1;

            //act
            var aktualna = produkt.Numer;

            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod()]
        public void Numer_NowaWartoscTest()
        {
            //arrange 

            var produkt = new Produkt();
            produkt.Numer = 400;
            var oczekiwana = 400;

            //act
            var aktualna = produkt.Numer;

            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }
        [TestMethod()]
        public void KodProduktu_WartoscDomyslnaTest()
        {
            //arrange 

            var produkt = new Produkt();


            var oczekiwana = "Informatyka - 1" ;

            //act
            var aktualna = produkt.KodProduktu;

            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }

        [TestMethod()]
        public void KodProduktu_NowaWartoscTest()
        {
            //arrange 

            var produkt = new Produkt();
            produkt.Kategoria = "Historia";
            produkt.Numer = 10;

            var oczekiwana = "Historia - 10";

            //act
            var aktualna = produkt.KodProduktu;

            //assert

            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}