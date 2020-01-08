using System;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args) {


             primeFactors(getInput());
        }
        /// <summary>
        /// Funksjon for å finne og vise primtallene til original tallet
        /// </summary>
        /// <param name="originalnumber"></param>
        public static void primeFactors(int originalnumber)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            // Så lenge tallet kan divideres med 2, legg det til i stringbuilderen og del tallet med 2
            while (originalnumber % 2 == 0)
            {
                sb.Append(2 + " ");
                originalnumber /= 2;
            }
            //Siden tallet nå må være oddetall, loop gjennom fra 3 til roten av tallet og pluss på med 2 for å beholde oddetallet
            for (int i = 3; i < Math.Sqrt(originalnumber); i+=2)
            {
                //Så lenge n kan deles med i, legg till "i" i stringen og divider tallet
                while (originalnumber % i == 0)
                {
                    sb.Append(i + " ");
                    originalnumber /= i;
                }
            }
            //Her sjekkes det om tallet er et primtall større enn 2
            if (originalnumber > 2)
            {
                sb.Append(originalnumber);
            }
            Console.WriteLine(sb.ToString());
        }
        /// <summary>
        /// Sjekk om input er riktig
        /// </summary>
        /// <returns></returns>
        public static int getInput()
        {
            Console.Write("Skriv inn ett tall og få tilbake primtallene som det kan faktorieres med: ");
            bool sjekk = int.TryParse(Console.ReadLine(), out int tall);
            if (!sjekk)
            {
                Console.WriteLine("Det oppstod en feil! programmet aksepterer bare tall!");
                tall = getInput();
            }

            return tall;
        }
    }
}
