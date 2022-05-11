using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stunde15_Eingabeprüfung
{
    class Program
    {
        static void Main(string[] args)
        {
            int z;
            bool erfolgreich;
            string eingabe;
            double d;
            //while (true)
            //{
            //    do
            //    {
            //        //GANZE ZAHLEN,
            //        //Console.WriteLine("Ganze zahl eingeben: ");
            //        //Console.Write("z=");

            //        //eingabe = Console.ReadLine();
            //        //erfolgreich = int.TryParse(eingabe, out z);

            //        //DEZIMAL ZAHLEN:
            //        Console.WriteLine("Dezimal zahl eingeben: ");
            //        Console.Write("d=");

            //        eingabe = Console.ReadLine();
            //        erfolgreich = double.TryParse(eingabe, out d);

            //        //analog für char, bool, short, float usw

            //        if (!erfolgreich) Console.WriteLine("Ungültige Eingabe!");

            //    } while (!erfolgreich); // !erfolgreich <-> Umkehrung (Negation)


            //}

            // PASSWORTÜBERPRÜFUNG:

            string passwort;
            bool korrekt;
            int zähler = 0;
            Console.WriteLine("Password erstellen: ");
            Console.WriteLine("Das Passwort soll \n" +
                "-mindestens acht zeichen enthalten \n" +
                "-mindestens eine Ziffer \n" +
                "-mindestens ein Groß- und ein Kleinbuchstabe");

            while (true)
            {
                do
                {
                    Console.Write("Passwort eingeben: ");
                    passwort = Console.ReadLine();

                    if (passwort.Length >= 8) zähler++;
                    
                    if (!EnthältZiffern(passwort)) zähler++;

                    if (!EnthältGroßbuchstaben(passwort)) zähler++;

                    if (!EnthältKleinbuchstaben(passwort)) zähler++;

                    if (zähler == 4) korrekt = true;

                    else
                    {
                        korrekt = false;
                        Console.WriteLine("Ungültige Eingabe");
                    }

                } while (!korrekt); // nicht korrekt = true  wenn  korrekt = false

            }

        }

        static bool EnthältZiffern(string testString)
        {
            bool ergebnis = false;

            for (int i = 0; i < testString.Length; i++)
            {
                if (Char.IsDigit(testString[i]))
                {
                    ergebnis = true;
                }
            }

            return ergebnis;
        }

        static bool EnthältGroßbuchstaben(string testString)
        {
            bool ergebnis = false;

            for (int i = 0; i < testString.Length; i++)
            {
                if (Char.IsUpper(testString[i]) && Char.IsLetter(testString[i]))
                {
                    ergebnis = true;
                }
            }

            return ergebnis;
        }

        static bool EnthältKleinbuchstaben(string testString)
        {
            bool ergebnis = false;

            for (int i = 0; i < testString.Length; i++)
            {
                if (Char.IsLower(testString[i]) && Char.IsLetter(testString[i]))
                {
                    ergebnis = true;
                }
            }

            return ergebnis;
        }
    }
}
