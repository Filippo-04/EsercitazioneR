using System;

namespace EsercitazioneLib
{
    public class Gestione
    {
        public static double Sconto(double a)
        {
            if (a > 0 && a <= 100)
            {
                double sconto= a/100 * 10;
                return sconto;
            }
            else
            {
                return 0;
            }
        }
        public static double Incremento(double a)
        {
            double num = a / 2;
            double incremento = a + num;
            return incremento;
        }
        public static double LatoQuadrato(double a)
        {
            if (a > 0)
            {
                double lato = Math.Sqrt(a);
                return lato;
            }
            else
            {
                return 0;
            }
        }
        public static string Binario(int a, int b)
        {
            string s = Convert.ToString(a, b);
            return s;
        }
    }
}
