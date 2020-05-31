using AreaCalculationApp.Interfaces;
using System;
using AreaCalculation;

namespace AreaCalculationApp
{
    public class MainPresenter
    {
        private readonly IMainForm mainForm;
        private readonly IServiceMessage serviceMessage;
        private readonly IAreaCalculation areaCalculation;

        public MainPresenter(IMainForm mainForm, IServiceMessage serviceMessage, IAreaCalculation areaCalculation)
        {
            this.mainForm = mainForm;
            this.serviceMessage = serviceMessage;
            this.areaCalculation = areaCalculation;

            this.mainForm.CalculateAreaClick += MainForm_CalculateAreaClick;
        }

        private void MainForm_CalculateAreaClick(object sender, EventArgs e)
        {
            if (mainForm.ListPoints.Count >= 3)
            {
                try
                {
                    var ans = areaCalculation.CalculationArea(mainForm.ListPoints);

                    mainForm.SetEstimatedArea(ans);
                }
                catch(Exception exp)
                {
                    serviceMessage.ShowWarning(exp.Message);
                }
            }
            else
            {
                serviceMessage.ShowWarning("Необходимо указать 3 точки.");
            }
        }
    }
}
