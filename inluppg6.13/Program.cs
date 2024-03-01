using System;

namespace inluppg6_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en sträng med korten du har");
            string inputString = Console.ReadLine();
            string[] kortArray = inputString.Split(' ');
            Console.WriteLine(Summera(kortArray));

        }

        static int Summera(string[] kortArray)
        {
            Dictionary<string, int> kort = new Dictionary<string, int>();
            foreach(string str in  kortArray)
            {
                kort[str] = 0;
            }
            foreach(string str in kortArray)
            {
                if (kort[str] == 0)
                {
                    kort[str] = 1;
                }
                else
                {
                    kort[str]++;
                }
            }

            int sum = 0;

            foreach (string kortVal in kort.Keys)
            {
                sum += (int)Math.Pow(int.Parse(kortVal), kort[kortVal]);
            }


            return sum;
        }
    }
}