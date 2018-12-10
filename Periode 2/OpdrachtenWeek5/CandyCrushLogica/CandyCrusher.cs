using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyCrushLogica
{
    public class CandyCrusher
    {
        public static bool ScoreRijAanwezig(RegularCandies[,] candies)
        {
            // Standaard benodigde waardes
            int teller = 1;

            for (int r = 0; r < candies.GetLength(0); r++)
            {
                for (int k = 0; k < candies.GetLength(1); k++)
                {

                    if (k + 1 < candies.GetLength(1) && candies[r, k] == candies[r, k + 1])
                    {
                        teller++;
                        if (teller >= 3)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        teller = 1;
                    }
                }
            }
            return false;
        }


        public static bool ScoreKolomAanwezig(RegularCandies[,] candies)
        {
            int teller = 1;


            for (int r = 0; r < candies.GetLength(0); r++)
            {
                for (int k = 0; k < candies.GetLength(1); k++)
                {
                    if (r + 1 < candies.GetLength(0) && candies[r, k] == candies[r + 1, k])
                    {
                        teller++;
                        r++;

                        if (r + 1 < candies.GetLength(0) && candies[r, k] == candies[r + 1, k])
                        {
                            teller++;
                        }
                        else
                        {
                            r--;
                            teller = 1;
                        }
                        if (teller >= 3)
                        {
                            return true;
                        }

                    }
                }
            }
            return false;
        }
    }
}
