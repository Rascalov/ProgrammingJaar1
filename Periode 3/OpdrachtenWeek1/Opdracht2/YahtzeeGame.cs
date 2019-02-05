using System;
using System.Linq;
class YahtzeeGame
{
    // initialize de array
    public Dobbelsteen[] dobbelstenen = new Dobbelsteen[5];
    public YahtzeeGame()
    {
        Random rnd = new Random();
        for (int i = 0; i < dobbelstenen.Length; i++)
        {
            dobbelstenen[i] = new Dobbelsteen(rnd);
        }
    }
    public void Gooi()
    {
        for (int i = 0; i < dobbelstenen.Length; i++)
        {
            dobbelstenen[i].Gooi();
        }
        
    }

    public void ToonWorp()
    {
        for (int i = 0; i < dobbelstenen.Length; i++)
        {
            dobbelstenen[i].ToonWaarde();
        }
        Console.WriteLine();

    }

    public bool Yahtzee()
    {
        if (dobbelstenen[0].waarde == dobbelstenen[1].waarde && dobbelstenen[0].waarde == dobbelstenen[2].waarde && dobbelstenen[0].waarde == dobbelstenen[3].waarde &&
            dobbelstenen[0].waarde == dobbelstenen[3].waarde && dobbelstenen[0].waarde == dobbelstenen[4].waarde)
        {
            return true;
        }
        return false;
    }
    public bool ThreeOfAKind()
    {
        int g1 = 0, g2 = 0, g3 = 0, g4 = 0, g5 = 0, g6 = 0;

        for (int i = 0; i < dobbelstenen.Length; i++)
        {
            switch (dobbelstenen[i].waarde)
            {
                case 1:
                    g1++;
                    break;
                case 2:
                    g2++;
                    break;
                case 3:
                    g3++;
                    break;
                case 4:
                    g4++;
                    break;
                case 5:
                    g5++;
                    break;
                case 6:
                    g6++;
                    break;
            }

        }
        if (g1 == 3 || g2 ==3 || g3 == 3 || g4 == 3 || g5 == 3 || g6 == 3)
        {
            return true;
        }
        return false;
    }

    public bool FourOfAKind()
    {
        int g1 = 0, g2 = 0, g3 = 0, g4 = 0, g5 = 0, g6 = 0;

        for (int i = 0; i < dobbelstenen.Length; i++)
        {
            switch (dobbelstenen[i].waarde)
            {
                case 1:
                    g1++;
                    break;
                case 2:
                    g2++;
                    break;
                case 3:
                    g3++;
                    break;
                case 4:
                    g4++;
                    break;
                case 5:
                    g5++;
                    break;
                case 6:
                    g6++;
                    break;
            }

        }
        if (g1 == 4 || g2 == 4 || g3 == 4 || g4 == 4 || g5 == 4 || g6 == 4)
        {
            return true;
        }
        return false;
    }
}