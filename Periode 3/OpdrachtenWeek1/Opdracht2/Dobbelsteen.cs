using System;
class Dobbelsteen
{
    public int waarde;
    Random rnd = new Random();
    public Dobbelsteen(Random rnd)
    {
        this.rnd = rnd;
    }
    public void Gooi()
    {
        waarde = rnd.Next(1, 7);
    }
    public void ToonWaarde()
    {
        Console.Write(waarde + " ");
    }

}