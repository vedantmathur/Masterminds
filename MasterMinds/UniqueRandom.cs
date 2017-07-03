using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMinds
{
    class UniqueRandom
    {
        List<int> numsGenerated = new List<int>();
        Random rand = new Random();

        public UniqueRandom()
        {

        }

        public int NextUnique(int lower, int upper)
        {
            if ((upper - lower) <= numsGenerated.Count)
            {
                throw new InvalidOperationException("Cannot generate the number");
            }
            int uRGen = rand.Next(lower, upper);
            for (int j = 0; j < numsGenerated.Count; j++)
            {
                if (uRGen == numsGenerated[j])
                {
                    uRGen = NextUnique(lower, upper);
                    break;
                }
            }

            numsGenerated.Add(uRGen);
            return uRGen;
        }



    }
}
