using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.PetrovNE.Sprint7.Project0.V10.Lib
{
    public class DataService
    {
        public int GetMaxValue(int[] array)
        {
            return array.Max();
        }

        public int GetMinValue(int[] array)
        {
            return array.Min();
        }
        public double GetAverageValue(int[] array)
        {
            double Result = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                Result += array[i];
            }
            return Result / array.Length;
        }

        public int GetSumValue(int[] array)
        {
            return array.Sum();
        }

        public int GetCountValue(int[] array)
        {
            return array.Length;
        }
    }
}
