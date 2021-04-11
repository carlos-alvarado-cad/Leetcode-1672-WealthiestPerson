using System;

namespace WealthiestPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] accounts1 =
            {
            new int[] { 100, 200, 300 },
            new int[] { 500 },
            new int[] { 400, 600, 500, 0 },
            };

            Console.WriteLine(MaximumWealth(accounts1));
        }
        public static int MaximumWealth(int[][] accounts)
        {
            int tempMax = 0;
            for (int i = 0; i < accounts.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < accounts[i].Length; j++)
                {  
                    sum += accounts[i][j];
                    if (sum > tempMax)
                    {
                        tempMax = sum;
                    }
                    else continue;
                }
            }
            return tempMax;
        }
    }
}
