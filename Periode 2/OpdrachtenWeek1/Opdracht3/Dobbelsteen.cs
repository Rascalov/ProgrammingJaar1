using System;
class Dobbelsteen
{
    public int waarde;
    static Random rnd = new Random();



    public void Gooi()
    {
        waarde = rnd.Next(1, 7);
    }
    public void ToonWaarde()
    {
        Console.Write(waarde + " ");
    }

}