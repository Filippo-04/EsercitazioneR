using Microsoft.VisualStudio.TestTools.UnitTesting;
using EsercitazioneLib;

namespace EsercitazioneLib_Test
{
    [TestClass]
    public class Gestione_Test
    {
        [TestMethod]
        public void TestSconto1()
        {
            double a = 100;
            double risultato_effettivo = 10;
            double risultato_calcolato = Gestione.Sconto(a);
            Assert.AreEqual(risultato_effettivo, risultato_calcolato);
        }
        [TestMethod]
        public void TestSconto2()
        {
            double a = -2;
            double risultato_effettivo = 0;
            double risultato_calcolato = Gestione.Sconto(a);
            Assert.AreEqual(risultato_effettivo, risultato_calcolato);
        }
    }
}
