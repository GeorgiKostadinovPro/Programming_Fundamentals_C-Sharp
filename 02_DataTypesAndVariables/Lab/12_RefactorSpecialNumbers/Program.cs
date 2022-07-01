using System;

namespace _12_RefactorSpecialNumbers
{
    public class Program
    { 
       public static void Main(string[] args)
       {
           int n = int.Parse(Console.ReadLine());
       
           for (int i = 1; i <= n; i++)
           {
               int sum = 0;
               int nToCheck = i;
               while (nToCheck > 0)
               {
                   sum += nToCheck % 10;
                   nToCheck = nToCheck / 10;
               }
       
               bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
               Console.WriteLine($"{i} -> {isSpecial}");
               sum = 0;
           }
       }  
    }
}
