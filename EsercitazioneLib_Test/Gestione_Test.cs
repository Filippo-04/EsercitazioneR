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
        [TestMethod]
        public void TestIncremento1()
        {
            double a = 45;
            double risultato_effettivo = 67.5;
            double risultato_calcolato = Gestione.Incremento(a);
            Assert.AreEqual(risultato_effettivo, risultato_calcolato);
        }
        [TestMethod]
        public void TestLatoQuadrato1()
        {
            double a = 16;
            double risultato_effettivo = 4;
            double risultato_calcolato = Gestione.LatoQuadrato(a);
            Assert.AreEqual(risultato_effettivo, risultato_calcolato);
        }
        [TestMethod]
        public void TestLatoQuadrato2()
        {
            double a = -28;
            double risultato_effettivo = 0;
            double risultato_calcolato = Gestione.LatoQuadrato(a);
            Assert.AreEqual(risultato_effettivo, risultato_calcolato);
        }
        public void TestBinario1()
        {
            int a = 32;
            int b = 2;
            string risultato_effettivo = "100000";
            string risultato_calcolato = Gestione.Binario(a,b);
            Assert.AreEqual(risultato_effettivo, risultato_calcolato);
        }
    }
}
