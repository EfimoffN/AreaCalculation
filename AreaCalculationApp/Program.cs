using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AreaCalculation;


namespace AreaCalculationApp
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm form = new MainForm();
            ServiceMessage serviceMessage = new ServiceMessage();
            AreaCalculation.AreaCalculation areaCalculation = new AreaCalculation.AreaCalculation();

            MainPresenter mainPresenter = new MainPresenter(form, serviceMessage, areaCalculation);

            Application.Run(form);
        }
    }
}
