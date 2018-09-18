using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace MarkovChain
{
    public partial class MainForm : Form
    {
        private static string PATH = "input.txt";
        private static Random random = new Random();
        private int matrixSize;
        private double[,] matrix;
        
        private int stepsCount;
        private int experimentsCount;
        private bool isEndStatesOnly;

        private int startStateNumberHolder;
        private int[] stateArrayHolder;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_load_matrix_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(PATH))
            {
                try
                {
                    matrixSize = Convert.ToInt32(sr.ReadLine());
                    stateArrayHolder = new int[matrixSize];
                    matrix = new double[matrixSize, matrixSize];
                    for(int i = 0; i < matrixSize; i++)
                    {
                        string[] str = sr.ReadLine().Split(' ');
                        for(int j = 0; j < matrixSize; j++)
                        {
                            matrix[i, j] = Convert.ToDouble(str[j], CultureInfo.InvariantCulture);
                        }
                    }
                    button_count.Enabled = true;
                    MessageBox.Show("Матрица переходных вероятностей успешно считана", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка при чтении матрицы переходных вероятностей", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_count_Click(object sender, EventArgs e)
        {
            stepsCount = Convert.ToInt32(numericUpDown_steps.Value);
            experimentsCount = Convert.ToInt32(numericUpDown_experiments.Value);

            if (radioButton_s1.Checked) startStateNumberHolder = 1;
            else if (radioButton_s2.Checked) startStateNumberHolder = 2;
            else if (radioButton_s3.Checked) startStateNumberHolder = 3;
            else if (radioButton_s4.Checked) startStateNumberHolder = 4;
            else startStateNumberHolder = 5;

            if (checkBox_end_states_only.Checked) isEndStatesOnly = true;
            else isEndStatesOnly = false;

            for (int i = 0; i < stateArrayHolder.Length; i++) stateArrayHolder[i] = 0;

            int currentStateNumber = startStateNumberHolder;

            for (int i = 0; i < experimentsCount; i++)
            {
                //Во время начала каждого из экспериментов возвращаемся в стартовую позицию
                currentStateNumber = startStateNumberHolder;
                for (int j = 0; j < stepsCount; j++)
                {
                    currentStateNumber = countNextState(random.Next(1, 100), currentStateNumber);
                    if (!isEndStatesOnly || (isEndStatesOnly && (j == stepsCount - 1)))
                    {
                        stateArrayHolder[currentStateNumber - 1]++;
                    }
                }
            }

            int statesCount = isEndStatesOnly ? experimentsCount : experimentsCount * stepsCount;

            List<double> resultChances = new List<double>();
            for(int i = 0; i < stateArrayHolder.Length; i++)
            {
                resultChances.Add(stateArrayHolder[i] / (double)statesCount);
            }

            chart_results.Series["Вероятности"].Points.DataBindXY(new List<string>(new string[] { "S1", "S2", "S3", "S4", "S5" }), resultChances);
        }

        private int countNextState(int randomNumber, int stateNumber)
        {
            List<Tuple<int, int>> chancesList = new List<Tuple<int,int>>();
            int accumulator = 0;
            for(int j = 0; j < matrixSize; j++)
            {
                if(matrix[stateNumber - 1, j] != 0)
                {
                    accumulator += Convert.ToInt32(matrix[stateNumber - 1, j] * 100);
                    chancesList.Add(new Tuple<int, int>(j + 1, accumulator));
                }
            }

            for(int i = 0; i < chancesList.Count - 1; i++)
            {
                if(randomNumber <= chancesList[i].Item2)
                {
                    return chancesList[i].Item1;
                }
            }

            return chancesList[chancesList.Count - 1].Item1;
        }
    }
}
