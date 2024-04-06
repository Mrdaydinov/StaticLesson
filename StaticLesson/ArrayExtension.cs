using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticLesson
{
    static class ArrayExtension
    {
        public static int[] Add(this int[] inputArray, int inputNum)
        {
            int[] outputArray = new int[inputArray.Length + 1];
            for (int i = 0; i < inputArray.Length; i++)
            {
                outputArray[i] = inputArray[i];
            }
            outputArray[inputArray.Length] = inputNum;
            return outputArray;
        }
    }
}
