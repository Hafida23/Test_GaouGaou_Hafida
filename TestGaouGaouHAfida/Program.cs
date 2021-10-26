using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGaouGaouHAfida
{
    class Program
    {
        static void Main(string[] args)
        {
            #region eerste vraag
            Console.WriteLine("*******************************1 Vraag*********************************************");

            bool stayInBool = true;
            while (stayInBool)
            {
                Console.Write("Voer een eerste getaal in :  ");
                int getal1 = int.Parse(Console.ReadLine());
                Console.Write("Voer de tweede getaal in :  ");
                int getal2 = int.Parse(Console.ReadLine());
                Console.Write("Voer de derde getaal in :  ");
                int getal3 = int.Parse(Console.ReadLine());
                if (getal1 > getal2 && getal1 > getal3)
                {
                    Console.WriteLine($"De grootste getaal is  eerste : {getal1}");

                }
                else if (getal2 > getal3 && getal2 > getal1)
                {

                    Console.WriteLine($"De grootste getaal is de tweede  : {getal2}");

                }
                else
                {
                    Console.WriteLine($"De grootste getaal is de derde  : {getal3}");

                }
                Console.WriteLine();

                Console.WriteLine("u wilt het opnieuw proberen ? ja of nee");

                string aantword = Console.ReadLine();
                if (aantword == "nee")
                    stayInBool = false;

            }
            #endregion
            Console.WriteLine("*******************************2 Vraag*********************************************");
            #region TweedeVrag
            int totaal = 0;
            int gemiddelde;
            bool stayInWhile = true;

            while (stayInWhile)
            {
                Console.Write("Voer uw naam in ");
                string naam = Console.ReadLine();
                Console.Write("Uw Engels punt is : ");
                int puntEngels = int.Parse(Console.ReadLine());
                Console.Write("Uw Programatie punt is : ");
                int puntProgramatie = int.Parse(Console.ReadLine());
                Console.Write("Uw Netwerken punt is : ");
                int puntNetwerken = int.Parse(Console.ReadLine());

                if ((puntEngels >= 5 && puntEngels <= 10) && (puntProgramatie >= 5 && puntProgramatie <= 10) && (puntNetwerken >= 5 && puntNetwerken <= 10))
                    stayInWhile = true;
                else break;


                totaal = puntEngels + puntNetwerken + puntNetwerken;
                gemiddelde = totaal / 3;
                Console.WriteLine($"De totaal punten voor engels,programatie en netwerken van {naam}  is : {totaal} ");
                Console.WriteLine($"het gemiddelde van {naam} is : {gemiddelde} ");

                Console.WriteLine("u wilt het opnieuw proberen ? ja of nee");

                string aantword = Console.ReadLine();
                if (aantword == "nee")
                    stayInWhile = false;
            }
            #endregion

            #region de derde vraag
            Console.WriteLine("*******************************3 Vraag*********************************************");

            for (int i = 0; i < 20; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine($"het even getaal van 1 tem 20 is : {i}\t ");
                }

            }
            #endregion
        }




    }
    
}
