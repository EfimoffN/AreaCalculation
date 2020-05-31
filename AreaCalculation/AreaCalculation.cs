using System;
using System.Collections.Generic;

namespace AreaCalculation
{
    public class AreaCalculation : IAreaCalculation
    {
        public double CalculationArea(List<int[]> listPoints)
        {
            double ansver = 0;
            if (CheckList(listPoints))
            {
                ansver = Calculation(listPoints);
            }
            return ansver;
        }

        private bool CheckList(List<int[]> listPoints)
        {
            foreach (var p in listPoints)
            {
                if (p.Length != 2)
                {
                    return false;
                }
            }
            return true;
        }

        private double Calculation(List<int[]> listPoints)
        {
            int sum1 = 0;
            int sum2 = 0;

            int[] lastPoint = listPoints[listPoints.Count - 1];
            listPoints.Add(lastPoint);

            for (int i = 0; i < listPoints.Count - 1; i++)
            {
                sum1 += listPoints[i][0] * listPoints[i + 1][1];
                sum2 += listPoints[i][1] * listPoints[i + 1][0];
            }

            double area = Math.Abs((sum1 - sum2) / 2d);
            return area;
        }
    }        
}
