using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            bool inkorrekt;
            int zähler = 0;
            Console.WriteLine("Password erstellen: ");
            Console.WriteLine("Das Passwort soll \n" +
                "-mindestens acht zeichen enthalten \n" +
                "-mindestens eine Ziffer \n" +
                "-mindestens ein Groß- und ein Kleinbuchstabe \n" +
                "-mindestens ein Sonderzeichen.");

            while (true)
            {
                do
                {
                    Console.Write("Passwort eingeben: ");
                    passwort = Console.ReadLine();

                    if (passwort.Length < 8)
                    {
                        zähler++;
                        Console.WriteLine("zu wenig Zeichen.");
                    }
                    
                    if (!EnthältZiffern(passwort))
                    {
                        zähler++;
                        Console.WriteLine("keine Ziffern.");
                    }

                    if (!EnthältGroßbuchstaben(passwort))
                    {
                        zähler++;
                        Console.WriteLine("keine Großbuchstaben.");
                    }

                    if (!EnthältKleinbuchstaben(passwort))
                    {
                        zähler++;
                        Console.WriteLine("keine Kleinbuchstaben.");
                    }

                    if (!EnthältSonderzeichen(passwort))
                    {
                        zähler++;
                        Console.WriteLine("keine Sonderzeichen.");
                    }

                    if (zähler == 0)
                    {
                        inkorrekt = false;
                        Console.WriteLine("Gültige Eingabe");
                    }

                    else
                    {
                        inkorrekt = true;
                        Console.WriteLine("Ungültige Eingabe");
                    }

                    Console.WriteLine(zähler + "zähler");

                } while (inkorrekt = true); // nicht korrekt = true  wenn  korrekt = false

            }

        }

        static bool EnthältSonderzeichen(string testString)
        {
            bool ergebnis = false;
            for (int i = 0; i < testString.Length; i++)
            {
                if (!Char.IsLetterOrDigit(testString[i]) && Char.IsLetter(testString[i]))
                {
                    ergebnis = true;
                }
            }

            return ergebnis;
        }

        static bool EnthältZiffern(string testString)
        {
            bool ergebnis = false;

            //for (int i = 0; i < testString.Length; i++)
            //{
            //    if (Char.IsDigit(testString[i]))
            //    {
            //        ergebnis = true;
            //    }
            //}

            //Regex reg = new Regex("^[0-9]+$");

            //ergebnis = reg.IsMatch(testString);

            //return ergebnis;

            return Regex.IsMatch(testString, "^[0-9]+$");
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
