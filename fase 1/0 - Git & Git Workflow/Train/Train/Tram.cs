namespace Train;

public class Tram : Vervoersmiddel
{
    public int aantalOvPaaltjes;

    public Tram(int wielAantal, int plaatsen, int aantalPaaltjes) : base(wielAantal, plaatsen)
    {
        this.aantalOvPaaltjes = aantalPaaltjes;
    }
}