namespace MergeSort
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TBInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DGSource = new System.Windows.Forms.DataGridView();
            this.DG1 = new System.Windows.Forms.DataGridView();
            this.DG2 = new System.Windows.Forms.DataGridView();
            this.button = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelSourceArr = new System.Windows.Forms.Label();
            this.labelMerge = new System.Windows.Forms.Label();
            this.labelNatMerge = new System.Windows.Forms.Label();
            this.TBCompsMerge = new System.Windows.Forms.TextBox();
            this.TBMovesMerge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TBCompsNatMerge = new System.Windows.Forms.TextBox();
            this.TBMovesNatMerge = new System.Windows.Forms.TextBox();
            this.BuildGraphs = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(287, 3);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(100, 20);
            this.TBInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Размера массива: ";
            // 
            // DGSource
            // 
            this.DGSource.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGSource.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGSource.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGSource.ColumnHeadersVisible = false;
            this.DGSource.EnableHeadersVisualStyles = false;
            this.DGSource.Location = new System.Drawing.Point(9, 292);
            this.DGSource.Name = "DGSource";
            this.DGSource.RowHeadersVisible = false;
            this.DGSource.Size = new System.Drawing.Size(467, 43);
            this.DGSource.TabIndex = 3;
            // 
            // DG1
            // 
            this.DG1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG1.ColumnHeadersVisible = false;
            this.DG1.Location = new System.Drawing.Point(9, 414);
            this.DG1.Name = "DG1";
            this.DG1.RowHeadersVisible = false;
            this.DG1.Size = new System.Drawing.Size(467, 43);
            this.DG1.TabIndex = 4;
            // 
            // DG2
            // 
            this.DG2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DG2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG2.ColumnHeadersVisible = false;
            this.DG2.Location = new System.Drawing.Point(9, 561);
            this.DG2.Name = "DG2";
            this.DG2.RowHeadersVisible = false;
            this.DG2.Size = new System.Drawing.Size(467, 43);
            this.DG2.TabIndex = 5;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(393, 3);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(39, 21);
            this.button.TabIndex = 6;
            this.button.Text = "OK";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(529, 42);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(857, 300);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(529, 352);
            this.chart2.Name = "chart2";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(857, 300);
            this.chart2.TabIndex = 8;
            this.chart2.Text = "chart2";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(10, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(160, 20);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Выполнить";
            this.buttonStart.UseCompatibleTextRendering = true;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // labelSourceArr
            // 
            this.labelSourceArr.AutoSize = true;
            this.labelSourceArr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSourceArr.Location = new System.Drawing.Point(7, 273);
            this.labelSourceArr.Name = "labelSourceArr";
            this.labelSourceArr.Size = new System.Drawing.Size(122, 16);
            this.labelSourceArr.TabIndex = 10;
            this.labelSourceArr.Text = "Исходный массив";
            // 
            // labelMerge
            // 
            this.labelMerge.AutoSize = true;
            this.labelMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMerge.Location = new System.Drawing.Point(7, 395);
            this.labelMerge.Name = "labelMerge";
            this.labelMerge.Size = new System.Drawing.Size(212, 16);
            this.labelMerge.TabIndex = 11;
            this.labelMerge.Text = "Сортировка простым слиянием";
            // 
            // labelNatMerge
            // 
            this.labelNatMerge.AutoSize = true;
            this.labelNatMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNatMerge.Location = new System.Drawing.Point(6, 542);
            this.labelNatMerge.Name = "labelNatMerge";
            this.labelNatMerge.Size = new System.Drawing.Size(250, 16);
            this.labelNatMerge.TabIndex = 12;
            this.labelNatMerge.Text = "Сортировка естественным слиянием";
            // 
            // TBCompsMerge
            // 
            this.TBCompsMerge.Location = new System.Drawing.Point(80, 473);
            this.TBCompsMerge.Name = "TBCompsMerge";
            this.TBCompsMerge.Size = new System.Drawing.Size(100, 20);
            this.TBCompsMerge.TabIndex = 13;
            // 
            // TBMovesMerge
            // 
            this.TBMovesMerge.Location = new System.Drawing.Point(376, 473);
            this.TBMovesMerge.Name = "TBMovesMerge";
            this.TBMovesMerge.Size = new System.Drawing.Size(100, 20);
            this.TBMovesMerge.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 15;
            this.label2.Text = "Количество\r\nсравнений:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 16;
            this.label3.Text = "Количество \r\nперестановок:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 625);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 26);
            this.label4.TabIndex = 17;
            this.label4.Text = "Количество\r\nсравнений:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 625);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 26);
            this.label5.TabIndex = 18;
            this.label5.Text = "Количество\r\nперестановок:";
            // 
            // TBCompsNatMerge
            // 
            this.TBCompsNatMerge.Location = new System.Drawing.Point(75, 631);
            this.TBCompsNatMerge.Name = "TBCompsNatMerge";
            this.TBCompsNatMerge.Size = new System.Drawing.Size(100, 20);
            this.TBCompsNatMerge.TabIndex = 19;
            // 
            // TBMovesNatMerge
            // 
            this.TBMovesNatMerge.Location = new System.Drawing.Point(376, 631);
            this.TBMovesNatMerge.Name = "TBMovesNatMerge";
            this.TBMovesNatMerge.Size = new System.Drawing.Size(100, 20);
            this.TBMovesNatMerge.TabIndex = 20;
            // 
            // BuildGraphs
            // 
            this.BuildGraphs.Location = new System.Drawing.Point(529, 3);
            this.BuildGraphs.Name = "BuildGraphs";
            this.BuildGraphs.Size = new System.Drawing.Size(149, 23);
            this.BuildGraphs.TabIndex = 21;
            this.BuildGraphs.Text = "Построить графики";
            this.BuildGraphs.UseVisualStyleBackColor = true;
            this.BuildGraphs.Click += new System.EventHandler(this.BuildGraphs_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(4, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(472, 179);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1444, 689);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BuildGraphs);
            this.Controls.Add(this.TBMovesNatMerge);
            this.Controls.Add(this.TBCompsNatMerge);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBMovesMerge);
            this.Controls.Add(this.TBCompsMerge);
            this.Controls.Add(this.labelNatMerge);
            this.Controls.Add(this.labelMerge);
            this.Controls.Add(this.labelSourceArr);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.DG2);
            this.Controls.Add(this.DG1);
            this.Controls.Add(this.DGSource);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGSource;
        private System.Windows.Forms.DataGridView DG1;
        private System.Windows.Forms.DataGridView DG2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelSourceArr;
        private System.Windows.Forms.Label labelMerge;
        private System.Windows.Forms.Label labelNatMerge;
        private System.Windows.Forms.TextBox TBCompsMerge;
        private System.Windows.Forms.TextBox TBMovesMerge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TBCompsNatMerge;
        private System.Windows.Forms.TextBox TBMovesNatMerge;
        private System.Windows.Forms.Button BuildGraphs;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

