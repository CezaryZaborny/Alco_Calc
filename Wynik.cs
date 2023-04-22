using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Piwo
{
    public class Wynik
    {
        // 450 x 280
        // 600 x 400
        // 26 Letters - "ABCDEFGHIJKLMNOPQRSTUVWXYZ"

        public bool gender;
        public int body;
        public int beer = 0;
        public int wine = 0;
        public int vodka = 0;
        public int resultNo = 0;
        public double resultPromile, timeDetox;
        public String resultMessage;
        public static String[] messages = {
            "Duzo wypiles",
            "...",
            "...",
            "Nie mozesz wstac",
            "Nie zyjesz"

        };

        public Wynik(bool gender, int body, int beer, int wine, int vodka)
        {
            this.gender = gender;
            this.body = body;
            this.beer = beer;
            this.wine = wine;
            this.vodka = vodka;
            ObliczWynik();


        }
        public void ObliczWynik()
        {
            double A, K = 0.7;
            if (gender) K = 0.6;
            // Beer 250ml
            // Wine 100ml
            // Vodka 30ml

            A = 20 * beer + 10 * wine + 16.6 * vodka;
            resultPromile = A / (K * body);
            resultPromile = Math.Round(resultPromile, 2);
            if (resultPromile > 5.0)
                resultNo = 4;
            else if (resultPromile > 4.0)
                resultNo = 3;
            else if (resultPromile > 3.0)
                resultNo = 2;
            else if (resultPromile > 2.0)
                resultNo = 1;
            else
                resultNo = 0;

            if (gender) timeDetox = A / 8.0;
            else timeDetox = A / 10.0;
            resultMessage = messages[resultNo];


        }
        
    }

}
