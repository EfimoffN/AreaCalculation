using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculationApp.Interfaces
{
    public interface IServiceMessage
    {
        void ShowError(string error);
        void ShowWarning(string warning);
    }
}
