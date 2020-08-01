using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DevHobby.Common.Tests
{
    [TestClass()]
    public class LogowanieServiceTests
    {
        [TestMethod()]
        public void LogowanieTest()
        {
           
            var oczekiwana = "Akcja: Test Akcja" ;

            var aktualna = LogowanieService.Logowanie("Test Akcja");
            Assert.AreEqual(oczekiwana, aktualna);
        }
    }
}