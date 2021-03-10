using System;

namespace EsercitazioneLib
{
    public class Gestione
    {
        public static double Sconto(double a)
        {
            if (a > 0 && a < 100)
            {
                double sconto = (a / 100) * 10;
                return sconto;
            }
            else
            {
                return 0;
            }
        }
        

    }
}
