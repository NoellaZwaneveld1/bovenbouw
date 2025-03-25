namespace Train;

public class Vervoersmiddel
{
    public int aantalWielen;
    public int aantalPlaatsen;
    public Person conducteur;

    public Vervoersmiddel(int aantalWielen, int aantalPlaatsen)
    {
        this.aantalWielen = aantalWielen;
        this.aantalPlaatsen = aantalPlaatsen;
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