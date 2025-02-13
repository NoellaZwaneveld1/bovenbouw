using System;

namespace Trainapp
{
    class Train
    {
        public int aantalWielen;
        public int aantalPlaatsen;
        public string conducteur;

        public Train(int wielaantal, int plaatsen, string conducteursnaam)
        {
            this.aantalWielen = wielaantal;
            this.aantalPlaatsen = plaatsen;
            this.conducteur = conducteursnaam;
        }

        public int rijden()
        {
            return 130;
        }

        public int remmen()
        {
            return 0;
        }
    } 

    class Program
    {
        public static void Main(string[] args)
        {
            Train eigenTrain = new Train(7, 30, "Eugene");

            Train nieuweTrain = new Train(20, 29, "Sinterklaas");
            Console.WriteLine(eigenTrain.aantalWielen);
            Console.WriteLine(nieuweTrain.aantalWielen);

        }
    }
}