using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceArrays
{
    class Program
    {
        // array utility files 
        static void Print (int [] ar)
        {
            //method that inputs an array
            // output : prints array

        }
        static  int[] BuildArray (int howMany, int first =0, int last = 100)
        {
            int[] array = new int[howMany];
            Random rnd = new Random();
            for (int i = 0; i < howMany; i++)
                array[i] = rnd.Next(first, last);
            return array;
        }
        static int GetMax (int [] ar)
        {
            int max = ar[0];
            foreach (int x in ar)
                if (x > max)
                    max = x;
            return max;
        }
        static int CountMaxes (int [] ar)
        {
            // method : gets an array
            // returns  : a number that represents how many time the Max of the array appears
            throw new NotImplementedException();
        }
        static void CountInBetween (int [] ar)
        {
            //method: gets an array
            // inputs 2 numbers- assume the first is smaller that the second
            //method prints how many times the highes (AKA: MAX) appear in array
            throw new NotImplementedException();
        }
        static int LongestSameSeries (int [] ar)
        {
            // method : gets an array
            // method returns the longest sequence of same number
            // example {1,1,2,2,2,2,4,1,1,7,7,7,7,7,2} ==>5
            throw new NotImplementedException();
        }
        static int Bingo (int [] ar1, int [] ar2)
        {
            // method: gets array
            // returns how many numbers are the same in the same place
            throw new NotImplementedException();
        }
        static bool HasPlace (int [] ar)
        {
            // method: gets array
            // returns how many values in the array were equal to the arrays index
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            //Check what you wrote to see if it works
            int[] m = BuildArray(14, 1, 30);
            Print(m);
            Console.WriteLine (GetMax(m));
            Console.WriteLine($"And it appears {CountMaxes(m)}");

        }
    }
}
