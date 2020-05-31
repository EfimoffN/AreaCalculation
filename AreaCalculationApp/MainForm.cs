using AreaCalculationApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AreaCalculationApp
{
    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            listPoint = new List<int[]>();
            listPointDesc = new List<string>();

            SetEnabledBtnDeletePoint();

            btnAddPoint.Click += AddPoint_Click;
            btnClearListPoints.Click += ClearListPoints_Click;
            btnDeleteSelectPoint.Click += DeleteSelectPoint_Click;
            btnCalculateArea.Click += CalculateArea_Click;
        }

        private List<string> listPointDesc;
        private List<string> ListPointDesc
        {
            get { return listPointDesc; }
            set
            {
                listPointDesc = value;
            }
        }

        private List<int[]> listPoint;
        public List<int[]> ListPoints 
        { 
            get { return listPoint; } 
            set
            {
                listPoint = value;
                if(listPoint.Count == 0)
                {
                    SetEnabledBtnDeletePoint();
                }
            }
        }    

        public string GetPointY
        {
            get { return PointY.Text.Trim(); }
            set { PointY.Text = value.Trim(); }
        }

        public string GetPointX
        {
            get { return PointX.Text.Trim(); }
            set { PointX.Text = value.Trim(); }
        }

        public event EventHandler CalculateAreaClick;

        private void SetEnabledBtnDeletePoint()
        {
            if (listPoint.Count > 0)
            {
                btnClearListPoints.Enabled = true;
                btnDeleteSelectPoint.Enabled = true;
            }
            else
            {
                btnClearListPoints.Enabled = false;
                btnDeleteSelectPoint.Enabled = false;
            }
        }

        private void PointX_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void PointY_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void AddPoint_Click(object sender, EventArgs e)
        {           
            if(GetPointY.Length > 0 && GetPointX.Length > 0)
            {
                int x = Int32.Parse(GetPointX);
                GetPointX = "";
                int y = Int32.Parse(GetPointY);
                GetPointY = "";
                int[] point = { x, y };

                ListPoints.Add(point);
                ListPointDesc.Add($"Вершина с координатой: {x}; {y}");

                setListBoxPoints();
            }
        }

        private void ClearListPoints_Click(object sender, EventArgs e)
        {
            if(ListPoints.Count > 0 && ListPointDesc.Count > 0)
            {
                ListPoints.Clear();
                ListPointDesc.Clear();
                setListBoxPoints();
            }
        }

        private void DeleteSelectPoint_Click(object sender, EventArgs e)
        {
            if(listBoxPoints.Items.Count > 0 && listBoxPoints.SelectedIndex > -1)
            {
                ListPoints.RemoveAt(listBoxPoints.SelectedIndex);
                ListPointDesc.RemoveAt(listBoxPoints.SelectedIndex);
                setListBoxPoints();
            }
            else if(listBoxPoints.Items.Count > 0 && listBoxPoints.SelectedIndex == -1)
            {
                ListPoints.RemoveAt(0);
                ListPointDesc.RemoveAt(0); 
                setListBoxPoints();
            }
        }

        private void setListBoxPoints()
        {
            if (listBoxPoints.Items.Count > 0)
            {
                listBoxPoints.Items.Clear();
            }
            listBoxPoints.Items.AddRange(ListPointDesc.ToArray());
            SetEnabledBtnDeletePoint();
        }

        private void CalculateArea_Click(object sender, EventArgs e)
        {
            if (CalculateAreaClick != null)
            {
                CalculateAreaClick(this, EventArgs.Empty);
            }
        }

        public void SetEstimatedArea(double area)
        {
            txtEstimatedArea.Text = area.ToString();
        }
    }
}
