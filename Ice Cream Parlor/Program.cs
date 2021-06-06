using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Cream_Parlor
{
    class Program
    {
        /*
    * Complete the 'icecreamParlor' function below.
    *
    * The function is expected to return an INTEGER_ARRAY.
    * The function accepts following parameters:
    *  1. INTEGER m
    *  2. INTEGER_ARRAY arr
    *
    *STDIN       Function
-----       --------
2           t = 2
4           k = 4
5           cost[] size n = 5
1 4 5 3 2   cost = [1, 4, 5, 3, 2]
4           k = 4
4           cost[] size n = 4
2 2 4 3     cost=[2, 2,4, 3]

        =====================
        1 4
        1 2
    */

        public static List<int> icecreamParlor(int m, List<int> arr)
        {
            List<int> availablePurchaes = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i+1; j < arr.Count; j++)
                {
                    if(arr[i]+arr[j] == m)
                    {
                        availablePurchaes.Add(i+1); 
                        availablePurchaes.Add(j+1);
                    }
                }
            }

            return availablePurchaes;
        }
        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int m = Convert.ToInt32(Console.ReadLine().Trim());

                int n = Convert.ToInt32(Console.ReadLine().Trim());

                List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

                List<int> result = Program.icecreamParlor(m, arr);

                Console.WriteLine(String.Join(" ", result));
            }

     
        }
    }
}
