using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Result
    { 
        public static int CountNonUnique(List<int> numbers)
        {
            int nonUniqueCount = 0;

            //var lstUnique = from i in numbers
            //                group i by i into Gr
            //                where Gr.Count() > 1
            //                select Gr.Key;

            //foreach (var t in lstUnique)
            //    nonUniqueCount++;

            //


            numbers.Sort();
            int[] countNum = new int[1000];
            int count;
            
          
            for (int i = 0; i < numbers.Count; i++)
            {
                count = 1;
               
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (i == j)
                        continue;

                    if (numbers[i].Equals(numbers[j]))
                     {
                        count++;
                        countNum[numbers[i]] = count; 
                    }

                }
                              
            }
          

            foreach(var num in countNum)
            {
                if (num > 1)
                    nonUniqueCount++;
            }
            return nonUniqueCount;
        }
    }
}