using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WebApplication1
{
    public class StringMerge
    {

        public static string  mergeStrings(string a, string b)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < a.Length|| i<b.Length; i++)
            {
                if(i < a.Length)
                {
                    sb.Append(a[i]);
                }
                if (i < b.Length)
                {
                    sb.Append(b[i]);
                }

            }
            return sb.ToString();
        }

       

       public static char getMaxOccuringChar(String str)
        {
             int ASCII_SIZE = 256;
            int[] count = new int[ASCII_SIZE];

           
            int len = str.Length;
            for (int i = 0; i < len; i++)
                count[str[i]]++;

            int max = -1; 
            char result = ' '; 

           
            for (int i = 0; i < len; i++)
            {
                if (max < count[str[i]])
                {
                    max = count[str[i]];
                    result = str[i];
                }
            }

            return result;
        }


    }
}