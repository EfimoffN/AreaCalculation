namespace AreaCalculationApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PointX = new System.Windows.Forms.TextBox();
            this.PointY = new System.Windows.Forms.TextBox();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.listBoxPoints = new System.Windows.Forms.ListBox();
            this.btnDeleteSelectPoint = new System.Windows.Forms.Button();
            this.btnClearListPoints = new System.Windows.Forms.Button();
            this.btnCalculateArea = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEstimatedArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите координаты вершины:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "X - ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y - ";
            // 
            // PointX
            // 
            this.PointX.Location = new System.Drawing.Point(233, 22);
            this.PointX.Name = "PointX";
            this.PointX.Size = new System.Drawing.Size(75, 20);
            this.PointX.TabIndex = 5;
            this.PointX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PointX_KeyPress);
            // 
            // PointY
            // 
            this.PointY.Location = new System.Drawing.Point(361, 22);
            this.PointY.Name = "PointY";
            this.PointY.Size = new System.Drawing.Size(75, 20);
            this.PointY.TabIndex = 6;
            this.PointY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PointY_KeyPress);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(480, 20);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddPoint.TabIndex = 7;
            this.btnAddPoint.Text = "Добавить";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            // 
            // listBoxPoints
            // 
            this.listBoxPoints.FormattingEnabled = true;
            this.listBoxPoints.Location = new System.Drawing.Point(30, 64);
            this.listBoxPoints.Name = "listBoxPoints";
            this.listBoxPoints.Size = new System.Drawing.Size(278, 225);
            this.listBoxPoints.TabIndex = 8;
            // 
            // btnDeleteSelectPoint
            // 
            this.btnDeleteSelectPoint.Enabled = false;
            this.btnDeleteSelectPoint.Location = new System.Drawing.Point(335, 64);
            this.btnDeleteSelectPoint.Name = "btnDeleteSelectPoint";
            this.btnDeleteSelectPoint.Size = new System.Drawing.Size(118, 23);
            this.btnDeleteSelectPoint.TabIndex = 9;
            this.btnDeleteSelectPoint.Text = "Удалить вершину";
            this.btnDeleteSelectPoint.UseVisualStyleBackColor = true;
            // 
            // btnClearListPoints
            // 
            this.btnClearListPoints.Enabled = false;
            this.btnClearListPoints.Location = new System.Drawing.Point(335, 93);
            this.btnClearListPoints.Name = "btnClearListPoints";
            this.btnClearListPoints.Size = new System.Drawing.Size(118, 23);
            this.btnClearListPoints.TabIndex = 10;
            this.btnClearListPoints.Text = "Очистить список";
            this.btnClearListPoints.UseVisualStyleBackColor = true;
            // 
            // btnCalculateArea
            // 
            this.btnCalculateArea.Location = new System.Drawing.Point(557, 305);
            this.btnCalculateArea.Name = "btnCalculateArea";
            this.btnCalculateArea.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateArea.TabIndex = 11;
            this.btnCalculateArea.Text = "Рассчитать";
            this.btnCalculateArea.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Площадь многоугольника:";
            // 
            // txtEstimatedArea
            // 
            this.txtEstimatedArea.AutoSize = true;
            this.txtEstimatedArea.Location = new System.Drawing.Point(176, 310);
            this.txtEstimatedArea.Name = "txtEstimatedArea";
            this.txtEstimatedArea.Size = new System.Drawing.Size(0, 13);
            this.txtEstimatedArea.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 355);
            this.Controls.Add(this.txtEstimatedArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCalculateArea);
            this.Controls.Add(this.btnClearListPoints);
            this.Controls.Add(this.btnDeleteSelectPoint);
            this.Controls.Add(this.listBoxPoints);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.PointY);
            this.Controls.Add(this.PointX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MainForm";
            this.Text = "Area calculation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PointX;
        private System.Windows.Forms.TextBox PointY;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.ListBox listBoxPoints;
        private System.Windows.Forms.Button btnDeleteSelectPoint;
        private System.Windows.Forms.Button btnClearListPoints;
        private System.Windows.Forms.Button btnCalculateArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtEstimatedArea;
    }
}

