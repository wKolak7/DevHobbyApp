using DevHobby.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevHobby.Bll.Tests
{
    [TestClass]
    public class DostawcaTests
    {
        [TestMethod]
        public void WyslijEmailWitamy_PrawidlowaNazwaFirmy_Sukces()
        {
            //arrange
            var dostawca = new Dostawca();
            dostawca.NazwaFirmy = "DevHobby";
            var wartoscOczekiwana = "Wiadomość wysłana: Witaj DevHobby";

            //act

            var wartoscAktualna = dostawca.WyslijEmailWitamy("Wiadomość testowa");


            //assert
            Assert.AreEqual(wartoscOczekiwana, wartoscAktualna);
        }


        [TestMethod]
        public void WyslijEmailWitamy_PustaNazwaFirmy_Sukces()
        {
            //arrange
            var dostawca = new Dostawca();
            dostawca.NazwaFirmy = "";
            var wartoscOczekiwana = "Wiadomość wysłana: Witaj";

            //act

            var wartoscAktualna = dostawca.WyslijEmailWitamy("Wiadomość testowa");


            //assert
            Assert.AreEqual(wartoscOczekiwana, wartoscAktualna);


        }

        [TestMethod]
        public void WyslijEmailWitamy_NullNazwaFirmy_Sukces()
        {
            //arrange
            var dostawca = new Dostawca();
            dostawca.NazwaFirmy = null;
            var wartoscOczekiwana = "Wiadomość wysłana: Witaj";

            //act

            var wartoscAktualna = dostawca.WyslijEmailWitamy("Wiadomość testowa");


            //assert
            Assert.AreEqual(wartoscOczekiwana, wartoscAktualna);


        }


    }
}
