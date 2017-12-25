using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)

        {
            Uczestnik Pierwszyuczestnik, Drugiuczestnik;
            string Sprawdzenie;
            Sprawdzenie = "Jeśli chcesz sprawdzić ile musi wpłacić jeszcze pieniędzy, wciśnij 1, jeśli chcesz przejść do kolejnego uczestnika, wciśnij 2 ";
            Pierwszyuczestnik = new Uczestnik("Barbara", 56);
            Drugiuczestnik = new Uczestnik("Katarzyna", 32);

            Console.WriteLine("Pierwsza uczestniczka ma na imię ");
            Pierwszyuczestnik.ReturnName();
            Console.WriteLine("Kwota, którą wpłaciła na kulig wynosi ");
            Pierwszyuczestnik.ReturnMoneyHeGave();
            
            Console.WriteLine(Sprawdzenie);
            Sprawdzenie = Console.ReadLine();
            int sprawdzenieint = int.Parse(Sprawdzenie);
            if (sprawdzenieint == 1)
            {
                
                
                Console.WriteLine("Musi zapłacić jeszcze ");
                Pierwszyuczestnik.LeftMoney();
            }
            if (sprawdzenieint == 2)

            {

                Console.WriteLine("Przeszedłeś do kolejnego uczestnik ");
            }

            Console.WriteLine("Kolejny uczestnik ma na imię ");
            Drugiuczestnik.ReturnName();
            Console.Write(" Ktowa jaką wpłaciła wynosi");
            Drugiuczestnik.ReturnMoneyHeGave();
            Console.WriteLine("Jeśli chcesz zobaczyć ile zostało jej do spłaty, wciśnij 1, jeśli chcesz zakończyć, wciśnij 2");
            string sprawdzeniedwa = Console.ReadLine();
            int sprawdzenieintdwa = int.Parse(sprawdzeniedwa);
            if (sprawdzenieintdwa == 1)
            {
                Console.WriteLine("Do zapłaty zostało jej");
                Drugiuczestnik.LeftMoney();
            }

                Console.ReadKey();
        }

        
    }
}
