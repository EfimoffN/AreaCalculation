using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculation
{
    public interface IAreaCalculation
    {
        double CalculationArea(List<int[]> listPoints);
    }
}
