using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Student Andrzej = new Student("Andrzej", "Andrzejewicz", 3.78f, 10);
            Console.WriteLine("Student nr 1 " + Andrzej.GetName() + " " + Andrzej.GetSurname() +
                " ma aktualnie średnią na poziome " + Andrzej.GetAvarage());
            Console.WriteLine("Wpisz ocenę, jaka ma być przypisana do średniej Andrzeja");
            string newGradeAndrzej = Console.ReadLine();
            float newGradefloatAndrzej = float.Parse(newGradeAndrzej);
            Andrzej.GetNewAvarage(newGradefloatAndrzej);
            Console.WriteLine("Nowa średnia Andrzeja to " + Andrzej.GetAvarage());
            Console.WriteLine("Jesli chcesz sprawdzic, czy srednia Andrzeja kwalifikuje sie na stypendium, wcisnij 1. " + Environment.NewLine +

                " Jesli nie obchodzi Cię średnia Andrzeja, zobacz kolejnego studenta, klikając dowolny klawisz!");
            string pressoneAndrzej = Console.ReadLine();
            char pressoneintAndrzej = char.Parse(pressoneAndrzej);
            if (pressoneintAndrzej == '1')
            {
                Andrzej.DoesHeGetAPrice();

            }
            
                else
            {
                Console.WriteLine("Przeszedłeś do kolejnego studenta");
            }

            
            Student Marek = new Student("Marek", "Markowski", 5.12f, 6);
            Console.WriteLine("Student nr 2 " + Marek.GetName() + " " + Marek.GetSurname() + " to niezły prymus!!!" + Environment.NewLine +  "Uzyskał średnią " + Marek.GetAvarage());
            Console.WriteLine("Wpisz dowolną ocenę, jaka ma być dodana do średniej Marka");
            string newGradeMarek = Console.ReadLine();
            float newGradefloatMarek = float.Parse(newGradeMarek);
            Marek.GetNewAvarage(newGradefloatMarek);
            Console.WriteLine("Nowa średnia Marka to " + Marek.GetAvarage());
            Console.WriteLine("Jesli chcesz sprawdzic, czy srednia Marka kwalifikuje się na stypendium wcisnij 1."
                + " Jeśli masz to gdzieś, kliknij dowolny klawisz ");
            string pressoneMarek = Console.ReadLine();
            char pressoneintMarek = char.Parse(pressoneMarek);
            if (pressoneintMarek == '1')
            {
                Marek.DoesHeGetAPrice();

            }

            else
            {
                Console.WriteLine("Jedziemy dalej! :)");
            }

            Student Anna = new Student("Anna", "Annowska", 4.75f, 12);
            Console.WriteLine("Kolejnym studentem jest " + Anna.GetName() + " " + Anna.GetSurname() + " Jej średnia wynosi " + Anna.GetAvarage());
            Console.WriteLine("Wpisz dowolną ocenę, jaka ma być przypisana do średniej Anny." + Environment.NewLine + "Pamiętaj, że od tego moze zalezec jej stypendium!");
            string newGradeAnna = Console.ReadLine();
            float newGradefloatAnna = float.Parse(newGradeAnna);
            Anna.GetNewAvarage(newGradefloatAnna);
            Console.WriteLine("Nowa średnia Anny wynosi " + Anna.GetAvarage());
            Console.WriteLine("Jesteś ciekawy co z jej stypendium? Jeśli tak, wciśnij 1. Jeśli Cię to nie obchodzi, kliknij jakiś klawisz");
            string pressoneAnna = Console.ReadLine();
            char pressoneintAnna = char.Parse(pressoneAnna);
            if (pressoneintAnna == '1')
            {
                Anna.DoesHeGetAPrice();

            }

            else
            {
                Console.WriteLine("Czyli Cię to nie obchodzi :) W takim razie czas na ostatniego Studenta");
            }

            Student Ryszard = new Student("Ryszard" , "Ryszardowski", 1.24f, 32);
            Console.WriteLine("Ostatni z naszej listy to student " + Ryszard.GetName() + " " + Ryszard.GetSurname() + " a jego średnia to zaledwie " + Ryszard.GetAvarage());
            Console.WriteLine(" Być może ocena, ktora dasz Ryśkowi poprawi jego sytuacje. Daj mu jakas ocene!");
            string newGradeRyszard = Console.ReadLine();
            float newGradefloatRyszard = float.Parse(newGradeRyszard);
            Ryszard.GetNewAvarage(newGradefloatRyszard);
            Console.WriteLine(" No i super! Teraz średnia Ryszarda wynosi " + Ryszard.GetAvarage());
            Console.WriteLine("Może Cię to rozbawi, ale możesz sprawdzić, czy zasluguje on na stypendium, wciskajac 1. " + Environment.NewLine + "Jesli wiesz, ze nie ma opcji, kliknij cokolwiek");
            string pressoneRyszard = Console.ReadLine();
            char pressoneintRyszard = char.Parse(pressoneRyszard);
            if (pressoneintRyszard == '1')
            {
                Ryszard.DoesHeGetAPrice();

            }

            else
            {
                Console.WriteLine("Wiesz, ze nie zasluzyl wiec nie trzeba sprawdzac, co?");
            }
            Console.WriteLine("Jesli znasz juz oceny wszystkich studentow, mozesz teraz zmienic ich nazwiska." + Environment.NewLine + "Czy ktorys z uczniow zmienil nazwisko podczas studiow? Jesli tak, wcisnij 1. Jesli nie i chcialbys wyjsc, kliknij cokolwiek");
            string presssth = Console.ReadLine();
            char presssthchar = char.Parse(presssth);
            if (presssthchar == '1')
            {
                Console.WriteLine("Wpisz zatem liczbe od 1 do 4, zeby wybrac studenta, ktoremu zmienimy nazwisko");
            }
            else
            {
                Environment.Exit(1);
            }
            string choseSurname = Console.ReadLine();
            char choseSurnamechar = char.Parse(choseSurname);

            if (choseSurnamechar == '1' )
            {
                Console.WriteLine("Wybrałeś Studenta nr 1, czyli Andrzeja. Wpisz jego nowe nazwisko");
                string newsurname = Console.ReadLine();
                Andrzej.ChangeSurname(newsurname);
                Console.WriteLine("Super! Nazwisko zostało zmienione! Od teraz Andrzej widnieje w bazie studentów jako Andrzej " + Andrzej.GetSurname());

            }
            if (choseSurnamechar == '2')
            {
                Console.WriteLine("Wybrałeś Studenta nr 2, czyli Marka. Wpisz jego nowe nazwisko");
                string newsurname = Console.ReadLine();
                Marek.ChangeSurname(newsurname);
                Console.WriteLine("Super! Nazwisko zostało zmienione! Od teraz Marek widnieje w bazie studentów jako Marek " + Marek.GetSurname());

            }
            if (choseSurnamechar == '3')
            {
                Console.WriteLine("Wybrałeś Studenta nr 3, czyli Annę. Wpisz jej nowe nazwisko");
                string newsurname = Console.ReadLine();
                Anna.ChangeSurname(newsurname);
                Console.WriteLine("Super! Nazwisko zostało zmienione! Od teraz Anna widnieje w bazie studentów jako Anna " + Anna.GetSurname());

            }
            if (choseSurnamechar == '4')
            {
                Console.WriteLine("Wybrałeś Studenta nr 4, czyli Ryszarda. Wpisz jego nowe nazwisko");
                string newsurname = Console.ReadLine();
                Ryszard.ChangeSurname(newsurname);
                Console.WriteLine("Super! Nazwisko zostało zmienione! Od teraz Ryszard widnieje w bazie studentów jako Ryszard " + Ryszard.GetSurname());

            }
            Console.WriteLine("Okej, czy ktoś jeszcze zmienił nazwisko? Jeśli tak, wpisz ponownie liczbę od 1 do 4. Jeśli nie, kliknij cokolwiek.");
            string choseSurnametwo = Console.ReadLine();
            char choseSurnamechartwo = char.Parse(choseSurnametwo);
            if (choseSurnamechartwo == '1')
            {
                Console.WriteLine("Wybrałeś Studenta nr 1, czyli Andrzeja. Wpisz jego nowe nazwisko");
                string newsurname = Console.ReadLine();
                Andrzej.ChangeSurname(newsurname);
                Console.WriteLine("Super! Nazwisko zostało zmienione! Od teraz Andrzej widnieje w bazie studentów jako Andrzej " + Andrzej.GetSurname());

            }
            if (choseSurnamechartwo == '2')
            {
                Console.WriteLine("Wybrałeś Studenta nr 2, czyli Marka. Wpisz jego nowe nazwisko");
                string newsurname = Console.ReadLine();
                Marek.ChangeSurname(newsurname);
                Console.WriteLine("Super! Nazwisko zostało zmienione! Od teraz Marek widnieje w bazie studentów jako Marek " + Marek.GetSurname());

            }
            if (choseSurnamechartwo == '3')
            {
                Console.WriteLine("Wybrałeś Studenta nr 3, czyli Annę. Wpisz jej nowe nazwisko");
                string newsurname = Console.ReadLine();
                Anna.ChangeSurname(newsurname);
                Console.WriteLine("Super! Nazwisko zostało zmienione! Od teraz Anna widnieje w bazie studentów jako Anna " + Anna.GetSurname());

            }
            if (choseSurnamechartwo == '4')
            {
                Console.WriteLine("Wybrałeś Studenta nr 4, czyli Ryszarda. Wpisz jego nowe nazwisko");
                string newsurname = Console.ReadLine();
                Ryszard.ChangeSurname(newsurname);
                Console.WriteLine("Super! Nazwisko zostało zmienione! Od teraz Ryszard widnieje w bazie studentów jako Ryszard " + Ryszard.GetSurname());

            }
            Console.ReadKey();

        }
    }
}
