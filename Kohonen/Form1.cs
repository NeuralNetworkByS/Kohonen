using Kohonen.model;
using Kohonen.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kohonen
{
    public partial class Form1 : Form
    {
        TrainingData trainingData;
        private float[,] neurons;
        float learningRate = 0.00f;
        PointsConverter pc = new PointsConverter();

        public Form1()
        {
            trainingData = new TrainingData();
            InitializeComponent();
            initializeNeurons();
        }

        private void TrainButton_Click(object sender, EventArgs e)
        {
            learningRate = float.Parse(LearningRateTB.Text);
            int epochs = Int32.Parse(EpochsNumberTB.Text);
            initializeNeurons();
            trainNeurons(epochs);
            MessageBox.Show("Trenowanie zakończone.");
        }

        public void initializeNeurons()
        {
            neurons = new float[8, 3];
            for (int i = 0; i < 8; i++)
            {
                neurons[i, 0] = trainingData.samples[i][0];
                neurons[i, 1] = trainingData.samples[i][1];
                neurons[i, 2] = 0;
            }
        }

        public void trainNeurons(int epochs)
        {
            for (int i = 0; i < epochs; i++)
            {
                for (int j = 0; j < trainingData.samples.Count; j++)
                {
                    float[] distances = new float[8];
                    for (int k = 0; k < 8; k++)
                    {
                        distances[k] = (float) Math.Sqrt(Math.Pow((trainingData.samples[j][0] - neurons[k, 0]),2) + Math.Pow((trainingData.samples[j][1] - neurons[k, 1]), 2));
                    }

                    float minValue = distances.Min();
                    int minIndex = distances.ToList().IndexOf(minValue);

                    neurons[minIndex, 0] += (trainingData.samples[j][0] - neurons[minIndex, 0]) * learningRate;
                    neurons[minIndex, 1] += (trainingData.samples[j][1] - neurons[minIndex, 1]) * learningRate;
                }
            }
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            new Chart(pc.FromRectangular(trainingData.samples), neurons).Show();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            initializeNeurons();
        }
    }
}
