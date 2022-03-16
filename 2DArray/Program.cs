using System;
using System.Collections.Generic;
using System.Linq;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < 6; i++)
            {
                //arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
                arr.Add(new List<int> { 1, 1, 1, 0, 0, 0 });
                arr.Add(new List<int> { 0, 1, 0, 0, 0, 0 });
                arr.Add(new List<int> { 1, 1, 1, 0, 0, 0 });
                arr.Add(new List<int> { 0, 0, 2, 4, 4, 0 });
                arr.Add(new List<int> { 0, 0, 0, 2, 0, 0 });
                arr.Add(new List<int> { 0, 0, 1, 2, 4, 0 });
            }

            List<List<int>> hourGlasses = new List<List<int>>();


            int countV = 0; // count vertical
            int countH = 0;
            List<int> temp;
            while(countH < 4)
            {                
                while (countV < 4)
                {
                    temp = new List<int>();
                    for (int i = countV; i < countV + 3; i++)
                    {
                        for (int j = countH; j < countH + 3; j++)
                        {
                            if (i == countV + 1)
                            {
                                if (j == countH || j == countH + 2)
                                    continue;
                                else 
                                {
                                    Console.Write($"  {arr[i][j]}");
                                    temp.Add(arr[i][j]);
                                }
                                    
                            }
                            else
                            {
                                Console.Write($"{arr[i][j]} ");
                                temp.Add(arr[i][j]);
                            }
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    hourGlasses.Add(temp);
                    countV++;
                }
                
                countV = 0;
                countH++;
            }
            Console.WriteLine(hourGlasses.Max(h => h.Sum()));
        }
    }
}
