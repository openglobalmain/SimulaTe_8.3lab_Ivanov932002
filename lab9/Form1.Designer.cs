namespace lab9
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.NVal = new System.Windows.Forms.NumericUpDown();
            this.txtVar = new System.Windows.Forms.TextBox();
            this.txtAver = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.prob5 = new System.Windows.Forms.TextBox();
            this.prob4 = new System.Windows.Forms.NumericUpDown();
            this.prob3 = new System.Windows.Forms.NumericUpDown();
            this.prob2 = new System.Windows.Forms.NumericUpDown();
            this.prob1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btStart = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.AvErr = new System.Windows.Forms.TextBox();
            this.VarErr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ChiVal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // NVal
            // 
            this.NVal.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NVal.Location = new System.Drawing.Point(249, 29);
            this.NVal.Margin = new System.Windows.Forms.Padding(4);
            this.NVal.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NVal.Name = "NVal";
            this.NVal.Size = new System.Drawing.Size(111, 22);
            this.NVal.TabIndex = 35;
            this.NVal.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // txtVar
            // 
            this.txtVar.Enabled = false;
            this.txtVar.Location = new System.Drawing.Point(370, 176);
            this.txtVar.Margin = new System.Windows.Forms.Padding(4);
            this.txtVar.Name = "txtVar";
            this.txtVar.ReadOnly = true;
            this.txtVar.Size = new System.Drawing.Size(85, 22);
            this.txtVar.TabIndex = 34;
            // 
            // txtAver
            // 
            this.txtAver.Enabled = false;
            this.txtAver.Location = new System.Drawing.Point(370, 124);
            this.txtAver.Margin = new System.Windows.Forms.Padding(4);
            this.txtAver.Name = "txtAver";
            this.txtAver.ReadOnly = true;
            this.txtAver.Size = new System.Drawing.Size(85, 22);
            this.txtAver.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 180);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "Variance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 127);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Average";
            // 
            // prob5
            // 
            this.prob5.Enabled = false;
            this.prob5.Location = new System.Drawing.Point(127, 252);
            this.prob5.Margin = new System.Windows.Forms.Padding(4);
            this.prob5.Name = "prob5";
            this.prob5.ReadOnly = true;
            this.prob5.Size = new System.Drawing.Size(107, 22);
            this.prob5.TabIndex = 30;
            // 
            // prob4
            // 
            this.prob4.DecimalPlaces = 2;
            this.prob4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.prob4.Location = new System.Drawing.Point(127, 215);
            this.prob4.Margin = new System.Windows.Forms.Padding(4);
            this.prob4.Name = "prob4";
            this.prob4.Size = new System.Drawing.Size(111, 22);
            this.prob4.TabIndex = 29;
            this.prob4.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // prob3
            // 
            this.prob3.DecimalPlaces = 2;
            this.prob3.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.prob3.Location = new System.Drawing.Point(127, 177);
            this.prob3.Margin = new System.Windows.Forms.Padding(4);
            this.prob3.Name = "prob3";
            this.prob3.Size = new System.Drawing.Size(111, 22);
            this.prob3.TabIndex = 28;
            this.prob3.Value = new decimal(new int[] {
            15,
            0,
            0,
            131072});
            // 
            // prob2
            // 
            this.prob2.DecimalPlaces = 2;
            this.prob2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.prob2.Location = new System.Drawing.Point(127, 141);
            this.prob2.Margin = new System.Windows.Forms.Padding(4);
            this.prob2.Name = "prob2";
            this.prob2.Size = new System.Drawing.Size(111, 22);
            this.prob2.TabIndex = 27;
            this.prob2.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            // 
            // prob1
            // 
            this.prob1.DecimalPlaces = 2;
            this.prob1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.prob1.Location = new System.Drawing.Point(127, 103);
            this.prob1.Margin = new System.Windows.Forms.Padding(4);
            this.prob1.Name = "prob1";
            this.prob1.Size = new System.Drawing.Size(111, 22);
            this.prob1.TabIndex = 26;
            this.prob1.Value = new decimal(new int[] {
            3,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 255);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Prob5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 217);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Prob4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Prob3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Prob2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Prob1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Number of experiments";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(583, 31);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(682, 445);
            this.chart1.TabIndex = 36;
            this.chart1.Text = "chart1";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(109, 326);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(129, 47);
            this.btStart.TabIndex = 37;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(497, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Error %";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 16);
            this.label10.TabIndex = 39;
            this.label10.Text = "Value";
            // 
            // AvErr
            // 
            this.AvErr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AvErr.Enabled = false;
            this.AvErr.Location = new System.Drawing.Point(479, 124);
            this.AvErr.Name = "AvErr";
            this.AvErr.Size = new System.Drawing.Size(80, 22);
            this.AvErr.TabIndex = 40;
            // 
            // VarErr
            // 
            this.VarErr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.VarErr.Enabled = false;
            this.VarErr.Location = new System.Drawing.Point(477, 176);
            this.VarErr.Name = "VarErr";
            this.VarErr.Size = new System.Drawing.Size(82, 22);
            this.VarErr.TabIndex = 41;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(280, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 42;
            this.label11.Text = "Chi-squared";
            // 
            // ChiVal
            // 
            this.ChiVal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ChiVal.Enabled = false;
            this.ChiVal.Location = new System.Drawing.Point(370, 341);
            this.ChiVal.Name = "ChiVal";
            this.ChiVal.Size = new System.Drawing.Size(85, 22);
            this.ChiVal.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 550);
            this.Controls.Add(this.ChiVal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VarErr);
            this.Controls.Add(this.AvErr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.NVal);
            this.Controls.Add(this.txtVar);
            this.Controls.Add(this.txtAver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.prob5);
            this.Controls.Add(this.prob4);
            this.Controls.Add(this.prob3);
            this.Controls.Add(this.prob2);
            this.Controls.Add(this.prob1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prob1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NVal;
        private System.Windows.Forms.TextBox txtVar;
        private System.Windows.Forms.TextBox txtAver;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox prob5;
        private System.Windows.Forms.NumericUpDown prob4;
        private System.Windows.Forms.NumericUpDown prob3;
        private System.Windows.Forms.NumericUpDown prob2;
        private System.Windows.Forms.NumericUpDown prob1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox AvErr;
        private System.Windows.Forms.TextBox VarErr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ChiVal;
    }
}

