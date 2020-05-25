using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MergeSort
{
    public partial class Form1 : Form
    {
        private static List<int> arr = new List<int>() { };
        private static int n;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TBInput.Text, out n))
            {
                MessageBox.Show("Введено неверное значение", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TBInput.Clear();
                return;
            }
            DGSource.ColumnCount = n;
            DGSource.RowCount = 1;
            DGSource.Rows[0].Height = 43;
            arr = FormHelper.InputData(n);
            FormHelper.MatrToGRid(DGSource, arr, n);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(TBInput.Text, out n))
            {
                MessageBox.Show("Введено неверное значение", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TBInput.Clear();
                return;
            }
            DG1.ColumnCount = n;
            DG1.RowCount = 1;
            DG1.Rows[0].Height = 43;
            MergeSort.CountComps = 0;
            MergeSort.CountMoves = 0;
            FormHelper.MatrToGRid(DG1, FormHelper.OutputResultMergeSort(arr.ToArray()), n);
            TBCompsMerge.Text = MergeSort.CountComps.ToString();
            TBMovesMerge.Text = MergeSort.CountMoves.ToString();

            DG2.ColumnCount = n;
            DG2.RowCount = 1;
            DG2.Rows[0].Height = 43;
            MergeSort.CountComps = 0;
            MergeSort.CountMoves = 0;
            FormHelper.MatrToGRid(DG2, FormHelper.OutputResultNaturalMergeSort(arr.ToArray()), n);
            TBCompsNatMerge.Text = NaturalMergeSort.CountComps.ToString();
            TBMovesNatMerge.Text = NaturalMergeSort.CountMoves.ToString();
        }

        private void BuildGraphs_Click(object sender, EventArgs e)
        {
            chart1.Titles.Clear();
            chart1.Titles.Add("Простое слияние. Количество сравнений и количество перестановок от количества элементов");
            chart1.Series.Clear();
            Series series1 = chart1.Series.Add("Количество сравнений");
            Series series2 = chart1.Series.Add("Количество перестановок");
            series1.ChartType = SeriesChartType.Line;
            series2.ChartType = SeriesChartType.Line;
            for (int i = 1; i <= 100; i++)
            {
                MergeSort.CountComps = 0;
                MergeSort.CountMoves = 0;
                List<int> mass = FormHelper.InputData(i);
                FormHelper.OutputResultMergeSort(mass.ToArray());
                series1.Points.AddXY(i, MergeSort.CountComps);
                series2.Points.AddXY(i, MergeSort.CountMoves);
            }

            chart2.Titles.Clear();
            chart2.Titles.Add("Естественное слияние. Количество сравнений и количество перестановок от количества элементов");
            chart2.Series.Clear();
            Series series3 = chart2.Series.Add("Количество сравнений");
            Series series4 = chart2.Series.Add("Количество перестановок");
            series3.ChartType = SeriesChartType.Line;
            series4.ChartType = SeriesChartType.Line;
            for (int i = 1; i <= 100; i++)
            {
                NaturalMergeSort.CountComps = 0;
                NaturalMergeSort.CountMoves = 0;
                List<int> mass = FormHelper.InputData(i);
                FormHelper.OutputResultNaturalMergeSort(mass.ToArray());
                series3.Points.AddXY(i, NaturalMergeSort.CountComps);
                series4.Points.AddXY(i, NaturalMergeSort.CountMoves);
            }
        }
    }
}
