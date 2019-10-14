using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutEtCombinos
{
    class Program
    {
        static void Main(string[] args)
        {

                Console.Write("Input your 'n' value: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                FactorialFunctions value = new FactorialFunctions();
                int factorialOfNumber = value.factorials(numero);
                //Console.WriteLine(factorialOfNumber);
                Console.Write("Input your 'r' value: ");
                int raks = Convert.ToInt32(Console.ReadLine());



                Console.WriteLine("What would you like to do today??(Permutation / Combination)");
                string req = Console.ReadLine();
                string request = req.ToLower();

                if (request == "permutation")
                {
                    FactorialFunctions evaluation = new FactorialFunctions();
                    int permutationValue = evaluation.permutation(numero, raks);
                    Console.WriteLine(permutationValue);
                }

                else if (request == "combination")
                {
                    Console.WriteLine("Is repitition allowed???(Yes / No)");
                    String reqRes = Console.ReadLine();
                    String reqResL = reqRes.ToLower();
                    if (reqResL == "yes")
                    {
                        FactorialFunctions evaluationist = new FactorialFunctions();
                        int combinationRep = evaluationist.combinationRep(numero, raks);
                        Console.WriteLine(combinationRep);

                    }

                    else if (reqResL == "no")
                    {
                        FactorialFunctions evaluationist = new FactorialFunctions();
                        int combinationNoRep = evaluationist.combinationNoRep(numero, raks);
                        Console.WriteLine(combinationNoRep);
                    }
                }

                else
                {
                    Console.WriteLine("I'm Sorry, I do not possess the ability to solve such functions,. Check back later and remember, Kapaichumarimarichupako");
                }

                Console.ReadKey();
            }


        }
    }


    

