using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            string Firstnumber, Secondnumber, Operation;
           

            Firstnumber = "Podaj pierwsza liczbę";
            Secondnumber = "Podaj drugą liczbę";
            Operation = "Wybierz dodawanie, odejmowanie, mnożenie, bądź dzielenie, wybierając +, -, *, /";

            Console.WriteLine(Firstnumber);
            Firstnumber = Console.ReadLine();
            float Firstnumberfloat = float.Parse(Firstnumber);
            Console.WriteLine(Operation);
            Operation = Console.ReadLine();
            Console.WriteLine(Secondnumber);
            Secondnumber = Console.ReadLine();
            float Secondnumberfloat = float.Parse(Secondnumber);

            if (Operation == "+")

            {
                Console.WriteLine("Wynik wynisi " + (Firstnumberfloat + Secondnumberfloat));
            }

            if (Operation == "-")
            {
                Console.WriteLine("Wynik wynosi " + (Firstnumberfloat - Secondnumberfloat));
            }

            if (Operation == "*")
            {
                Console.WriteLine("Wynik wynosi " + (Firstnumberfloat * Secondnumberfloat));
            }

            if (Operation == "/")
            {
                Console.WriteLine("Wynik wynosi " + (Firstnumberfloat / Secondnumberfloat));
            }
            Console.ReadKey();
        
        }
    }
}
