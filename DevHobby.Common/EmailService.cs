namespace DevHobby.Common
{
    public class EmailService
    {
        /// <summary>
        /// Wysyła wiadomość email.
        /// </summary>
        /// <param name="temat">Temat wiadomosci</param>
        /// <param name="wiadomosc">wiadomosc tekstowa</param>
        /// <param name="odbiorca">adres email odbiorcy wiadomosci</param>
        /// <returns></returns>
        public string WyslijWiadomosc(string temat, string wiadomosc, string odbiorca)
        {

            // Kod, ktory wysyla wiadomosc email

            var potwierdzenie = "Wiadomość wysłana: " + temat;
             LogowanieService.Logowanie(potwierdzenie);

            return potwierdzenie;

        }
    }
}
