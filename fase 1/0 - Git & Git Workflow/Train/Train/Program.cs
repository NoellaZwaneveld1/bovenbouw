namespace Train;
    class Program
    {
        public static void Main(string[] args)
        {

            Person persoon1 = new Person(FirstName: "Kees", LastName: "Panda", age: 93);

            // Train eigenTrain = new Train(7, 30);
            // Train nieuweTrain = new Train(20, 29);
            
            Tram tram1 = new Tram(38, 2, aantalPaaltjes: 8);
            Console.WriteLine(tram1.aantalOvPaaltjes);
            Console.WriteLine(tram1.aantalPlaatsen);
            
            // persoon1.BemanTrein(eigenTrain);
            // Console.WriteLine(eigenTrain.conducteur.FirstName);

            // Console.WriteLine(eigenTrain.aantalWielen);
            // Console.WriteLine(nieuweTrain.aantalWielen);

        }
    }
