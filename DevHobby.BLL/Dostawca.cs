using DevHobby.Common;

namespace DevHobby.BLL
{
    /// <summary>
    /// Zarządza dostawcami od których kupujemy nasze produkty.
    /// </summary>
    public class Dostawca
    {
        #region pola i wlasciwosci 
        public int DostawcaId { get; set; }
        public string NazwaFirmy { get; set; }
        public string Email { get; set; }
        #endregion


        /// <summary>
        /// Wysyła wiadomość email, aby powitać nowego dostwce.
        /// </summary>
        /// <param name="wiadomosc"></param>
        /// <returns></returns>
        public string WyslijEmailWitamy(string wiadomosc)
        {
            var emailService = new EmailService();
            var temat = ("Witaj " + this.NazwaFirmy).Trim();
            var potwierdzenie = emailService.WyslijWiadomosc(temat, wiadomosc, this.Email);

            return potwierdzenie;
        }
    }
}
