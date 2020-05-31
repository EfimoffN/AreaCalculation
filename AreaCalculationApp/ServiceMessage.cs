using AreaCalculationApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AreaCalculationApp
{
    public class ServiceMessage : IServiceMessage
    {
        public void ShowError(string error)
        {
            MessageBox.Show(error, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowWarning(string warning)
        {
            MessageBox.Show(warning, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
