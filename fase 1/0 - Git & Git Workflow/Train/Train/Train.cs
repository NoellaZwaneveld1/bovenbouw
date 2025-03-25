namespace Train;

    public class Train : Vervoersmiddel
    {

        public Train(int wielAantal, int plaatsen) : base(wielAantal, plaatsen)
        {

        }

        public void GiveControl(Person NieuweConducteur)
        {
            this.conducteur = NieuweConducteur;
        }
    }