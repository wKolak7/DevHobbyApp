using System;
using DevHobby.Common;
using static DevHobby.Common.LogowanieService;

namespace DevHobby.BLL
{

    /// <summary>
    /// Zarządza produktami
    /// </summary>
    public class Produkt
    {
        // stałe
        public const double CaliNaMetr = 38.87;
        public readonly decimal MinimalnaCena;


        #region konstruktory
        public Produkt()
        {
            Console.WriteLine("Produkt został utworzony.");
            //this.DostawcaProduktu = new Dostawca();
            this.MinimalnaCena = 10.50m;
            this.Kategoria = "Informatyka";
        }
        public Produkt(int produktId, string nazwaProduktu, string opis) : this()
        {
            this.ProduktId = produktId;
            this.NazwaProduktu = nazwaProduktu;
            this.Opis = opis;
            if (nazwaProduktu.StartsWith("Krzesło"))
            {
                this.MinimalnaCena = 120.99m;
            }
            Console.WriteLine("Produkt ma nazwe: " + nazwaProduktu);
        }
        #endregion


        #region pola i wlasciwosci
        private int produktId;

        public int ProduktId
        {
            get { return produktId; }
            set { produktId = value; }
        }

        private string nazwaProduktu;

        public string NazwaProduktu
        {
            get
            {
                var sformatowanaNazwaProduktu = nazwaProduktu?.Trim();
                return sformatowanaNazwaProduktu;
            }
            set
            {
                if (value.Length < 4)
                {
                    Wiadomosc = "Nazwa produktu musi być dłuższa niż 4 znaki";
                }
                else if (value.Length > 30)
                {
                    Wiadomosc = "Nazwa produktu musi być krótsza niż 30 znaków";
                }
                else { nazwaProduktu = value; }
                
            }
        }

        private string opis;

        public string Opis
        {
            get { return opis; }
            set { opis = value; }
        }


        private Dostawca dostawcaProduktu;

        public Dostawca DostawcaProduktu
        {
            get
            {
                if (dostawcaProduktu == null)
                {
                    dostawcaProduktu = new Dostawca();
                }
                return dostawcaProduktu;
            }
            set { dostawcaProduktu = value; }
        }

        private DateTime? dataDostepnosci;

        public DateTime? DataDostepnosci
        {
            get { return dataDostepnosci; }
            set { dataDostepnosci = value; }
        }

        public string Wiadomosc { get; private set; }

        internal string Kategoria { get; set; }
        public int Numer { get; set; } = 1;

        public string KodProduktu => this.Kategoria + " - " + this.Numer;


        #endregion
        public string PowiedzWitaj()
        {
            //var dostawca = new Dostawca();
            //dostawca.WyslijEmailWitamy("Wiadomość z produktu");

            var emailServices = new EmailService();
            var potwierdzenie = emailServices.WyslijWiadomosc("Nowy produkt", this.NazwaProduktu, "marketing@dev-hobby.pl");

            var wynik = Logowanie("Powiedziano witaj");

            return "Witaj " + NazwaProduktu + " (" + ProduktId + "): " + Opis
                + " Dostepny od : " + dataDostepnosci?.ToShortDateString();
        }

    }
}
