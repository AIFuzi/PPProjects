using System;
using System.Windows.Forms;

namespace Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DG_Matrix.ReadOnly = true;
        }

        private void B_N1_Click(object sender, EventArgs e)
        {
            TB_Result.Clear();

            int rows = 3;
            int columns = 4;
            int minVal = 999;

            DG_Matrix.ColumnCount = columns;
            DG_Matrix.RowCount = rows;

            int[,] matrix = new int[rows, columns];

            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(-100, 100);
                    DG_Matrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();

                    if (matrix[i, j] < minVal) minVal = matrix[i, j];
                }
                TB_Result.AppendText($"Строка: {i} - Элемент: {minVal.ToString()}... ");
                minVal = 999;
            }
        }

        private void B_N2_Click(object sender, EventArgs e)
        {
            TB_Result.Clear();

            int rows = 4;
            int columns = 3;
            int maxVal = -999;

            DG_Matrix.ColumnCount = columns;
            DG_Matrix.RowCount = rows;

            int[,] matrix = new int[rows, columns];

            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(-100, 100);
                    DG_Matrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();

                    if (matrix[i, j] > maxVal) maxVal = matrix[i, j];
                }
                TB_Result.AppendText($"Строка: {i} - Элемент: {maxVal.ToString()}... ");
                maxVal = -999;
            }

        }

        private void B_N3_Click(object sender, EventArgs e)
        {
            TB_Result.Clear();

            int rows = 4;
            int columns = 3;
            int posCount = 0;

            DG_Matrix.ColumnCount = columns;
            DG_Matrix.RowCount = rows;

            int[,] matrix = new int[rows, columns];

            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(-100, 100);
                    DG_Matrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();

                    if (matrix[i, j] > 0) posCount++;
                }
                TB_Result.Text = $"Кол-во положительных: {posCount.ToString()}";
            }
        }

        private void B_N4_Click(object sender, EventArgs e)
        {

            TB_Result.Clear();

            int rows = 3;
            int columns = 4;
            int otrCount = 0;

            DG_Matrix.ColumnCount = columns;
            DG_Matrix.RowCount = rows;

            int[,] matrix = new int[rows, columns];

            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(-100, 100);
                    DG_Matrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();

                    if (matrix[i, j] < 0) otrCount++;
                }
                TB_Result.Text = $"Кол-во отрицательных: {otrCount.ToString()}";
            }
        }

        private void B_N5_Click(object sender, EventArgs e)
        {

            TB_Result.Clear();

            int rows = 15;
            int columns = 15;
            
            int srArh = 0;
            int Val = 0;

            DG_Matrix.ColumnCount = columns;
            DG_Matrix.RowCount = rows;

            int[,] matrix = new int[rows, columns];

            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = rnd.Next(-100, 100);
                    DG_Matrix.Rows[i].Cells[j].Value = matrix[i, j].ToString();

                    if (i > 0)
                    {
                        srArh += matrix[i, j];
                        Val++;
                    }
                }
                if(i > 0) TB_Result.AppendText($"Строка: {i} - Ср. арифм: : {srArh/Val}... ");
            }
        }
    }
}
