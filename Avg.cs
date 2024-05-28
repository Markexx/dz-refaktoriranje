using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz_refaktoriranje
{
public class Avg
    {
        public List<double> Averages(List<double[]> arraysList)
        {
            List<double> avgs = new List<double>();

            foreach (double[] array in arraysList)
            {
                double sum = 0;

                foreach (double number in array)
                {
                    sum += number;
                }

                double average = sum / array.Length;
                avgs.Add(average);
            }

            return avgs;
        }
    }
}
