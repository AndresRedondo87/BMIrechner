using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string vorname, nachname, name;
            double bmi = 0;
            Console.Write("Gib deinen Vorname ein: ");
            vorname = Console.ReadLine();
            Console.Write("Gib deinen Nachnamen ein: ");
            nachname = Console.ReadLine();
            name = vorname + " " + nachname;
            try
            {
                bmi = BMI();
                Console.WriteLine(Ausgabe(name, bmi));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            warteBenutzerEingabe();
        }
        static double BMI()
        {
            string alt;
            int alter;
            double gewicht, größe, bmi;
            Console.Write("Dein Alter: ");
            alt = Console.ReadLine();


            alter = Convert.ToInt16(alt);
            if (alter <= 10)
            {
                throw new Exception("Du bist ein wenig jung, um dir wegen deiner Form sorgen zu machen.\n");
            }
            else if (alter >= 130)
            {
                throw new Exception("Du bist zu alt, um dir wegen sowas sorgen zu machen.\n");
            }
            gewicht = GEWICHT();
            größe = GRÖßE();
            bmi = gewicht / ((größe / 100) * (größe / 100));
            return bmi;
        }
        static string Ausgabe(string name, double bmi)
        {
            string message;
            if (bmi <= 16)
            {
                message = name + " ihr BMI ist " + bmi + ". Das heißt, Sie sind stark untergewichtig.\nSprechen Sie mit einem Arzt.";
            }
            else if (bmi <= 16.9)
            {
                message = name + " ihr BMI ist " + bmi + ". Das heißt, Sie sind mäßig untergewichtig.\nSprechen Sie mit Burger King.";
            }
            else if (bmi <= 18.4)
            {
                message = name + " ihr BMI ist " + bmi + ". Das heißt, Sie sind leicht untergewichtig.\nNehmen Sie nicht weiter ab.";
            }
            else if (bmi <= 24.9)
            {
                message = name + " ihr BMI ist " + bmi + ". Das heißt, Sie sind normalgewichtig.\nBleib genauso wie du bist.";
            }
            else if (bmi <= 29.9)
            {
                message = name + " ihr BMI ist " + bmi + ". Das heißt, Sie sind leicht übergewichtig.\nNehmen Sie nicht weiter zu, versuchen Sie Gewicht zu verlieren.";
            }
            else if (bmi <= 34.9)
            {
                message = name + " ihr BMI ist " + bmi + ". Das heißt, Sie sind mäßig übergewichtig.\nStreben Sie eine Diät an.";
            }
            else if (bmi <= 39.9)
            {
                message = name + " ihr BMI ist " + bmi + ". Das heißt, Sie sind stark übergewichtig.\nMeiden Sie fettiges Essen und suchen Sie einen Arzt auf.";
            }

            else
            {
                // message = name + " ihr BMI ist " + bmi + ". Das heißt, Du bist ne fette Sau.\nSprechen Sie mit einem Arzt.";
                message = string.Format("{0} ihr BMI ist {1}. Das heißt, du bist ne fette Sau.\nSprechen Sie mit einem Arzt.", name, bmi);
            }
            return message;
        }
        static double GEWICHT()
        {
            string gew;
            double gewicht;
            Console.Write("Gib dein Gewicht ein: ");
            gew = Console.ReadLine();
            bool gewi = double.TryParse(gew, out gewicht);
            if (gewi == false)
            {
                Console.WriteLine("Du kannst keine Buchstaben bei Gewicht angeben.");
                Console.Read();
            }
            return gewicht;
        }
        static double GRÖßE()
        {
            string gr;
            double größe;
            Console.Write("Gib deine Körpergröße ein: ");
            gr = Console.ReadLine();

            bool grö = double.TryParse(gr, out größe);
            if (grö == false)
            {
                Console.WriteLine("Du kannst keine Buchstaben bei Körpergröße angeben.");
                Console.Read();
            }
            return größe;
        }
        static void warteBenutzerEingabe()
        {
            Console.ReadLine();
        }
    }
}
