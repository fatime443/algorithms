using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms
{
    class Program
    {
        static void  RemoveAt(ref int[]array,int value, int index)
        {
            int[] newArray = new int[array.Length - 1];
            newArray[index] = value;

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
               
             
            }
            for (int i = index; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];

            }

            array = newArray;
        }
        static void RemoveFirst(ref int[] array, int value)
        {
            RemoveAt(ref array,value, array.Length + 1);
        }
        static void RemoveLast(ref int[] array, int value)
        {
            RemoveAt(ref array,value, array.Length - 1);
        }
        static void Main(string[] args)
        {
            int[] arr = {1,2,3,4,5,6,7,8,9,10,11,12};
            RemoveAt(ref arr, 10,5);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
            
        }
    }
}
