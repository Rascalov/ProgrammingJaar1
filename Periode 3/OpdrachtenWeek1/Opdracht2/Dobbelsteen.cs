using System;
class Dobbelsteen
{
    public int waarde;
    
    public Dobbelsteen(Random rnd)
    {
        rnd = new Random();
    }
    public void Gooi()
    {
        waarde = this.rnd.Next(1, 7);
    }
    public void ToonWaarde()
    {
        Console.Write(waarde + " ");
    }

}