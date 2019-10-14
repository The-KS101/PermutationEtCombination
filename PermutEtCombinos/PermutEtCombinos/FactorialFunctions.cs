using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutEtCombinos
{
    class FactorialFunctions
    {
        public int factorials(int numero) {
            int kicker = 1;
           

            if (numero == 0)
            {
                kicker = 1;
            }

            for (int i = 2; i <= numero; i++)
            {
                kicker *= i;
            }

            return kicker;
        }

        public int permutation(int numero, int raks)
        {
            
            FactorialFunctions gaut = new FactorialFunctions();
            int flopper = gaut.factorials(numero);
            int floppee = gaut.factorials((numero-raks));

            int permutation = flopper / floppee;

            return permutation;
        }

        public int combinationNoRep(int numero, int raks)
            {
            FactorialFunctions gaut = new FactorialFunctions();
            int flopper = gaut.factorials(numero);
            int floppee = gaut.factorials(raks) * gaut.factorials( numero- raks);

            int combinationNoRep = flopper / floppee;

            return combinationNoRep;
            }

        public int combinationRep(int numero, int raks)
            {
            FactorialFunctions gaut = new FactorialFunctions();
            int flopper = gaut.factorials(numero + raks - 1);
            int floppee = gaut.factorials(raks) * gaut.factorials(numero - raks);

            int combinationRep = flopper / floppee;

            return combinationRep;
            }

    }
}
