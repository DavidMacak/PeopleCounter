using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleCounter.Controllers
{
    public class GeneratorPruchodu
    {

        static public void Generuj()
        {
            int prichody;
            int odchody;
            int celkovePrichody = 0;
            int celkoveOdchody = 0;
            int pracovniDobaZacatek = 9;
            int pracovniDobaZacatekZvysujici = pracovniDobaZacatek;
            int pracovniDobaKonec = 21;
            var rand = new Random();

            for (int i = pracovniDobaZacatek; i < pracovniDobaKonec; i++)
            {
                prichody = rand.Next(0, 100);
                odchody = rand.Next(0, 100);

                celkovePrichody += prichody;

                if(i == pracovniDobaKonec - 1)
                {
                    if(celkoveOdchody < celkovePrichody)
                        odchody = celkovePrichody - celkoveOdchody;
                    else
                        odchody = celkoveOdchody - celkovePrichody;

                    celkoveOdchody += odchody;
                }
                else
                {

                    celkoveOdchody += odchody;
                }


                Console.WriteLine("{0}:00 - {1}:00      Příchody: {2}       Odchody: {3}        Rozdíl: {4}", pracovniDobaZacatekZvysujici, pracovniDobaZacatekZvysujici + 1, prichody, odchody, prichody-odchody);

                pracovniDobaZacatekZvysujici++;
            }
            Console.WriteLine("Celkem: {0} {1}", celkovePrichody, celkoveOdchody);
        }
    }
}
