using System;
using  Decision_Making_Metods.UnderCertainly;
namespace DrAmr
{
    class Program
    {
        static void Main(string[] args)
        {
           MiniMax_Regret c = new  MiniMax_Regret(3, 3);
            c.data = new int[,] {
            {4075,5000,6100 },
            {0,5250,12080 },
            { 2500,7000,10375}
            };
           // c.getRegretTable();
            c.Print();
            Console.WriteLine("=============");
            string ans;
            int[] arr = c.Solve(out ans);
            Console.WriteLine("==================================");
            Console.WriteLine(ans);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
