using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculationApp.Interfaces
{
    public interface IMainForm
    {
        event EventHandler CalculateAreaClick;
        void SetEstimatedArea(double area);

        List<int[]> ListPoints { get; }

        string GetPointY { get; }
        string GetPointX { get; }
    }
}
