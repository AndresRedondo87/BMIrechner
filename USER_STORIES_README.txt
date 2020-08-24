ORIGINAL NACHRICHT
Ich folge jetzt einfach mal der Anweisung und stelle meinen Code online, den ich mit der Hilfe hier erstellt habe. Wolf · Clase 62 · hace 3 años
Ich habe bis jetzt noch nie gecoddet deswegen werden wahrscheinlich ein paar Fehler drin sein. Mir war der Taschenrechner auf dauer doch zu langweilig, 
deswegen habe ich einen BMI-Rechner erstellt.


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
            double bmi =0;
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
An einigen Stellen ist er mit farbiger Sprache und Gemeinheiten gesprenkelt, da dachte ich mir aber: "Hey, soll ja mir Spaß machen!"

---------------------------------------------------------------------------------------------------------------------------------------
3x ANTWORTEN:
Jan Suchotzki Jan— InstructorRespuesta hace 3 años
Hallo Wolf,
Super Klasse! Vielen Dank für die tolle Idee und vor allem, dass du deinen Quellcode hier veröffentlichst! Es gibt ein paar Punkte die ich anmerken würde. Das würde ich dir allerdings am liebsten in Form eines Videos (#FragLernMoment) zur Verfügung stellen.
Da ich gerade ziemlich hinten dran bin mit meinen Videos, wird es wenige Wochen dauern. Ich denke, dass du dann trotzdem mit der Rückmeldung noch etwas anfangen kannst.
Kurze Zusammenfassung:
Dafür das du kompletter Einsteiger bist ist das Resultat super! Bei den Fehlerfällen wird wahrscheinlich noch etwas schief laufen (z.B. Zeile 101 und 116). Du erkannt zwar die Fehler und machst auch eine Ausgabe, aber das Programm läuft einfach weiter. Wenn beispielsweise die Größe falsch eingegeben wurde, dann bräuchtest du den Rest nicht mehr machen. Hier könntest du auch mit Exceptions arbeiten oder einfach innerhalb der Methoden GRÖßE und GEWICHT solange die Eingabe wiederholen, bis eine gültige Eingabe erfolgt.

Dann gibt es bezüglich deinem "Style" noch ein paar Punkte. Die übliche Schreibweise ist, dass du Methodennamen mit einem Großbuchstaben beginnst und wenn der Name aus mehreren Wörtern besteht jeden Anfangsbuchstaben eines Wortes ebenfalls groß schreibst. Alles groß schreiben ist nicht falsch und funktioniert auch (wie du siehst ;-), aber es ist schwerer zu lesen.
Die Verwendung von "Sonderzeichen" wie ß, ä, ö und ü in Namen (z.B. der Methodennamen GRÖßE) ist grundsätzlich möglich, aber auch hier kommt es durchaus mal zu Problemen. 
Die beiden letzten Punkte sind für dich momentan wahrscheinlich noch nicht so relevant, aber wenn du mit anderen Entwicklern zusammen arbeitest, kann das zu einem Problem werden.
Wie gesagt, diese Anmerkungen sind wirklich nur Kleinigkeiten die du auch später noch verbessern kannst. Wichtig ist erstmal, dass du Spaß beim Entwickeln hast. Das scheint ja der Fall zu sein ;-)!
Ich hoffe einige andere folgen deinem Beispiel und zeigen auch etwas von ihren ersten Gehversuchen. Das ist ein weiterer wichtiger Punkt für das Lernen.
Mach weiter so und bis bald
Jan

Wolf Voigt Wolf hace 3 años
Danke, sehr freundlich. Es war auch keinesfalls offensiv gemeint, dass ich was anderes mache. Ich bin nur einer, der gerne kompliziert einsteigt und dann Fehler ausräumt, dabei habe ich viel Stack Overflow und die Microsoft Hilfe benutzt.
Ich bin für jeden angemerkten Fehler offen und wenn es hilft, kann das was ich geschrieben habe auch gerne bei einem Video als Beispiel dienen. Dann musst du nicht ganz von vorne Anfangen.
Auf bald,
Wolf

Jan SuchotzkiJan— Instructorhace 3 años
Habe nichts offensiv verstanden ;-)!
Dein Ansatz andere Wege auszuprobieren ist genau richtig. Bei den meisten Dinge ist genau das der Punkt, an dem du es auch wirklich verstehst!
Bitte stelle jederzeit wieder Fragen und auch gerne weitere Programme. Sobald ich wieder etwas aufgeholt habe mit meinen Videos werde ich vermehrt versuchen Programme zu besprechen (Code Review). Ich denke das hilft allen die sich gerade intensiv mit dem Thema beschäftigen.
Ich freue mich schon auf deine nächsten Ideen
Jan

