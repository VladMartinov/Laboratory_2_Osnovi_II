namespace WindowsFormsApp1
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartTSet = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartVSet = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStartCalculation = new System.Windows.Forms.Button();
            this.chartT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelCurrentT = new System.Windows.Forms.Label();
            this.textBoxT = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.labelCurrentV = new System.Windows.Forms.Label();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.labelX1 = new System.Windows.Forms.Label();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.labelX2 = new System.Windows.Forms.Label();
            this.textBoxX3 = new System.Windows.Forms.TextBox();
            this.labelX3 = new System.Windows.Forms.Label();
            this.textBoxY3 = new System.Windows.Forms.TextBox();
            this.labelY3 = new System.Windows.Forms.Label();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.labelY2 = new System.Windows.Forms.Label();
            this.textBoxY1 = new System.Windows.Forms.TextBox();
            this.labelY1 = new System.Windows.Forms.Label();
            this.textBoxS3 = new System.Windows.Forms.TextBox();
            this.labelS3 = new System.Windows.Forms.Label();
            this.textBoxS2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxS1 = new System.Windows.Forms.TextBox();
            this.labelS1 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.labelX = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.labelY = new System.Windows.Forms.Label();
            this.chartFigures = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartTSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFigures)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTSet
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTSet.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTSet.Legends.Add(legend1);
            this.chartTSet.Location = new System.Drawing.Point(12, 50);
            this.chartTSet.Name = "chartTSet";
            this.chartTSet.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "T";
            this.chartTSet.Series.Add(series1);
            this.chartTSet.Size = new System.Drawing.Size(455, 175);
            this.chartTSet.TabIndex = 0;
            this.chartTSet.Text = "chart1";
            // 
            // chartVSet
            // 
            chartArea2.Name = "ChartArea1";
            this.chartVSet.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartVSet.Legends.Add(legend2);
            this.chartVSet.Location = new System.Drawing.Point(557, 50);
            this.chartVSet.Name = "chartVSet";
            this.chartVSet.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "V";
            this.chartVSet.Series.Add(series2);
            this.chartVSet.Size = new System.Drawing.Size(455, 175);
            this.chartVSet.TabIndex = 1;
            this.chartVSet.Text = "chart2";
            // 
            // buttonStartCalculation
            // 
            this.buttonStartCalculation.Location = new System.Drawing.Point(473, 50);
            this.buttonStartCalculation.Name = "buttonStartCalculation";
            this.buttonStartCalculation.Size = new System.Drawing.Size(78, 40);
            this.buttonStartCalculation.TabIndex = 2;
            this.buttonStartCalculation.Text = "Начать";
            this.buttonStartCalculation.UseVisualStyleBackColor = true;
            this.buttonStartCalculation.Click += new System.EventHandler(this.ButtonStartCalculation_Click);
            // 
            // chartT
            // 
            chartArea3.Name = "ChartArea1";
            this.chartT.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartT.Legends.Add(legend3);
            this.chartT.Location = new System.Drawing.Point(557, 231);
            this.chartT.Name = "chartT";
            this.chartT.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "T(iter)";
            this.chartT.Series.Add(series3);
            this.chartT.Size = new System.Drawing.Size(455, 175);
            this.chartT.TabIndex = 3;
            this.chartT.Text = "chart2";
            // 
            // chartV
            // 
            chartArea4.Name = "ChartArea1";
            this.chartV.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartV.Legends.Add(legend4);
            this.chartV.Location = new System.Drawing.Point(557, 412);
            this.chartV.Name = "chartV";
            this.chartV.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "V(t)";
            this.chartV.Series.Add(series4);
            this.chartV.Size = new System.Drawing.Size(455, 175);
            this.chartV.TabIndex = 4;
            this.chartV.Text = "chart2";
            // 
            // labelCurrentT
            // 
            this.labelCurrentT.AutoSize = true;
            this.labelCurrentT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentT.Location = new System.Drawing.Point(470, 292);
            this.labelCurrentT.Name = "labelCurrentT";
            this.labelCurrentT.Size = new System.Drawing.Size(81, 15);
            this.labelCurrentT.TabIndex = 5;
            this.labelCurrentT.Text = "Температура";
            // 
            // textBoxT
            // 
            this.textBoxT.Enabled = false;
            this.textBoxT.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxT.Location = new System.Drawing.Point(473, 310);
            this.textBoxT.Name = "textBoxT";
            this.textBoxT.Size = new System.Drawing.Size(78, 21);
            this.textBoxT.TabIndex = 6;
            this.textBoxT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxV
            // 
            this.textBoxV.Enabled = false;
            this.textBoxV.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxV.Location = new System.Drawing.Point(473, 487);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(78, 21);
            this.textBoxV.TabIndex = 8;
            this.textBoxV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelCurrentV
            // 
            this.labelCurrentV.AutoSize = true;
            this.labelCurrentV.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCurrentV.Location = new System.Drawing.Point(481, 469);
            this.labelCurrentV.Name = "labelCurrentV";
            this.labelCurrentV.Size = new System.Drawing.Size(61, 15);
            this.labelCurrentV.TabIndex = 7;
            this.labelCurrentV.Text = "Скорость";
            // 
            // textBoxX1
            // 
            this.textBoxX1.Enabled = false;
            this.textBoxX1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX1.Location = new System.Drawing.Point(47, 431);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(78, 21);
            this.textBoxX1.TabIndex = 10;
            this.textBoxX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX1.Location = new System.Drawing.Point(9, 434);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(33, 15);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "Xцт1";
            // 
            // textBoxX2
            // 
            this.textBoxX2.Enabled = false;
            this.textBoxX2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX2.Location = new System.Drawing.Point(47, 456);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(78, 21);
            this.textBoxX2.TabIndex = 12;
            this.textBoxX2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX2.Location = new System.Drawing.Point(9, 459);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(33, 15);
            this.labelX2.TabIndex = 11;
            this.labelX2.Text = "Xцт2";
            // 
            // textBoxX3
            // 
            this.textBoxX3.Enabled = false;
            this.textBoxX3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX3.Location = new System.Drawing.Point(47, 481);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(78, 21);
            this.textBoxX3.TabIndex = 14;
            this.textBoxX3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX3.Location = new System.Drawing.Point(9, 484);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(33, 15);
            this.labelX3.TabIndex = 13;
            this.labelX3.Text = "Xцт3";
            // 
            // textBoxY3
            // 
            this.textBoxY3.Enabled = false;
            this.textBoxY3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY3.Location = new System.Drawing.Point(204, 481);
            this.textBoxY3.Name = "textBoxY3";
            this.textBoxY3.Size = new System.Drawing.Size(78, 21);
            this.textBoxY3.TabIndex = 20;
            this.textBoxY3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelY3
            // 
            this.labelY3.AutoSize = true;
            this.labelY3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY3.Location = new System.Drawing.Point(166, 484);
            this.labelY3.Name = "labelY3";
            this.labelY3.Size = new System.Drawing.Size(33, 15);
            this.labelY3.TabIndex = 19;
            this.labelY3.Text = "Yцт3";
            // 
            // textBoxY2
            // 
            this.textBoxY2.Enabled = false;
            this.textBoxY2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY2.Location = new System.Drawing.Point(204, 456);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(78, 21);
            this.textBoxY2.TabIndex = 18;
            this.textBoxY2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY2.Location = new System.Drawing.Point(166, 459);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(33, 15);
            this.labelY2.TabIndex = 17;
            this.labelY2.Text = "Yцт2";
            // 
            // textBoxY1
            // 
            this.textBoxY1.Enabled = false;
            this.textBoxY1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY1.Location = new System.Drawing.Point(204, 431);
            this.textBoxY1.Name = "textBoxY1";
            this.textBoxY1.Size = new System.Drawing.Size(78, 21);
            this.textBoxY1.TabIndex = 16;
            this.textBoxY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY1.Location = new System.Drawing.Point(166, 434);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(33, 15);
            this.labelY1.TabIndex = 15;
            this.labelY1.Text = "Yцт1";
            // 
            // textBoxS3
            // 
            this.textBoxS3.Enabled = false;
            this.textBoxS3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxS3.Location = new System.Drawing.Point(370, 481);
            this.textBoxS3.Name = "textBoxS3";
            this.textBoxS3.Size = new System.Drawing.Size(78, 21);
            this.textBoxS3.TabIndex = 26;
            this.textBoxS3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelS3
            // 
            this.labelS3.AutoSize = true;
            this.labelS3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelS3.Location = new System.Drawing.Point(332, 484);
            this.labelS3.Name = "labelS3";
            this.labelS3.Size = new System.Drawing.Size(22, 15);
            this.labelS3.TabIndex = 25;
            this.labelS3.Text = "S3";
            // 
            // textBoxS2
            // 
            this.textBoxS2.Enabled = false;
            this.textBoxS2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxS2.Location = new System.Drawing.Point(370, 456);
            this.textBoxS2.Name = "textBoxS2";
            this.textBoxS2.Size = new System.Drawing.Size(78, 21);
            this.textBoxS2.TabIndex = 24;
            this.textBoxS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(332, 459);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "S2";
            // 
            // textBoxS1
            // 
            this.textBoxS1.Enabled = false;
            this.textBoxS1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxS1.Location = new System.Drawing.Point(370, 431);
            this.textBoxS1.Name = "textBoxS1";
            this.textBoxS1.Size = new System.Drawing.Size(78, 21);
            this.textBoxS1.TabIndex = 22;
            this.textBoxS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelS1
            // 
            this.labelS1.AutoSize = true;
            this.labelS1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelS1.Location = new System.Drawing.Point(332, 434);
            this.labelS1.Name = "labelS1";
            this.labelS1.Size = new System.Drawing.Size(22, 15);
            this.labelS1.TabIndex = 21;
            this.labelS1.Text = "S1";
            // 
            // textBoxX
            // 
            this.textBoxX.Enabled = false;
            this.textBoxX.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxX.Location = new System.Drawing.Point(121, 566);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(78, 21);
            this.textBoxX.TabIndex = 28;
            this.textBoxX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(144, 548);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(26, 15);
            this.labelX.TabIndex = 27;
            this.labelX.Text = "Xцт";
            // 
            // textBoxY
            // 
            this.textBoxY.Enabled = false;
            this.textBoxY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxY.Location = new System.Drawing.Point(287, 566);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(78, 21);
            this.textBoxY.TabIndex = 30;
            this.textBoxY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(310, 548);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(26, 15);
            this.labelY.TabIndex = 29;
            this.labelY.Text = "Yцт";
            // 
            // chartFigures
            // 
            chartArea5.Name = "ChartArea1";
            this.chartFigures.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartFigures.Legends.Add(legend5);
            this.chartFigures.Location = new System.Drawing.Point(12, 231);
            this.chartFigures.Name = "chartFigures";
            this.chartFigures.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series5.BorderWidth = 3;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "Figure №1";
            series6.BorderWidth = 3;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Figure №2";
            series7.BorderWidth = 3;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Figure №3";
            this.chartFigures.Series.Add(series5);
            this.chartFigures.Series.Add(series6);
            this.chartFigures.Series.Add(series7);
            this.chartFigures.Size = new System.Drawing.Size(455, 175);
            this.chartFigures.TabIndex = 31;
            this.chartFigures.Text = "chart2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 622);
            this.Controls.Add(this.chartFigures);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.textBoxS3);
            this.Controls.Add(this.labelS3);
            this.Controls.Add(this.textBoxS2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxS1);
            this.Controls.Add(this.labelS1);
            this.Controls.Add(this.textBoxY3);
            this.Controls.Add(this.labelY3);
            this.Controls.Add(this.textBoxY2);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.textBoxY1);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.textBoxX3);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.labelCurrentV);
            this.Controls.Add(this.textBoxT);
            this.Controls.Add(this.labelCurrentT);
            this.Controls.Add(this.chartV);
            this.Controls.Add(this.chartT);
            this.Controls.Add(this.buttonStartCalculation);
            this.Controls.Add(this.chartVSet);
            this.Controls.Add(this.chartTSet);
            this.MaximumSize = new System.Drawing.Size(1040, 750);
            this.Name = "FormMain";
            this.Text = "Лабораторная работа №2, Мартынов В.В., ИВТ-1, 4 курс";
            ((System.ComponentModel.ISupportInitialize)(this.chartTSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartVSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFigures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartTSet;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVSet;
        private System.Windows.Forms.Button buttonStartCalculation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartT;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartV;
        private System.Windows.Forms.Label labelCurrentT;
        private System.Windows.Forms.TextBox textBoxT;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.Label labelCurrentV;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.TextBox textBoxX3;
        private System.Windows.Forms.Label labelX3;
        private System.Windows.Forms.TextBox textBoxY3;
        private System.Windows.Forms.Label labelY3;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.TextBox textBoxY1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.TextBox textBoxS3;
        private System.Windows.Forms.Label labelS3;
        private System.Windows.Forms.TextBox textBoxS2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxS1;
        private System.Windows.Forms.Label labelS1;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFigures;
    }
}

