using Kohonen.model;
using Kohonen.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        int numNeurons = 8;

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
            trainNeurons(epochs);
            MessageBox.Show("Trenowanie zakończone.");
        }

        public void initializeNeurons()
        {
            neurons = new float[numNeurons, 3];
            for (int i = 0; i < numNeurons; i++)
            {
                neurons[i, 0] = 0;
                neurons[i, 1] = 0;
                neurons[i, 2] = 0;
            }
        }

        public void trainNeurons(int epochs)
        {
            float additionalRate = float.Parse(ExtraLearingRate.Text);

            for (int i = 0; i < epochs; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                   

                    float[] distances = new float[numNeurons];
                    for (int k = 0; k < numNeurons; k++)
                    {
                        distances[k] = 
                            (float) Math.Sqrt(Math.Pow((trainingData.samples[j][0] - neurons[k, 0]),2) + Math.Pow((trainingData.samples[j][1] - neurons[k, 1]), 2));
                   
                    }

                    float minValue = distances.Min();
                    int minIndex = distances.ToList().IndexOf(minValue);

                    //Debug.WriteLine("THE WINNER IS: " + minIndex);

                    int neighbourUp = minIndex + 1;
                    int neighbourDown = minIndex - 1;
                    
                    float nonNeighbourRate = 0.6f;

                    /*
                    for (int k = 0; k < numNeurons; k++)
                    {
                        if (k == minIndex || k == neighbourDown || k == neighbourDown)
                        {
                            continue;
                        }

                        neurons[k, 0] += (trainingData.samples[j][0] - neurons[k, 0]) * learningRate * additionalRate * nonNeighbourRate;
                        neurons[k, 1] += (trainingData.samples[j][1] - neurons[k, 1]) * learningRate * additionalRate * nonNeighbourRate;
                    }
                    */

                    if (neighbourUp < numNeurons)
                    {
                        neurons[neighbourUp, 0] += (trainingData.samples[j][0] - neurons[neighbourUp, 0]) * learningRate * additionalRate;
                        neurons[neighbourUp, 1] += (trainingData.samples[j][1] - neurons[neighbourUp, 1]) * learningRate * additionalRate;
                    }

                    if (neighbourDown >= 0)
                    {
                        neurons[neighbourDown, 0] += (trainingData.samples[j][0] - neurons[neighbourDown, 0]) * learningRate * additionalRate;
                        neurons[neighbourDown, 1] += (trainingData.samples[j][1] - neurons[neighbourDown, 1]) * learningRate * additionalRate;
                    }

                    

                    neurons[minIndex, 0] += (trainingData.samples[j][0] - neurons[minIndex, 0]) * learningRate;
                    neurons[minIndex, 1] += (trainingData.samples[j][1] - neurons[minIndex, 1]) * learningRate;
                }
            }

            for (int i = 0; i < numNeurons; i++)
            {
                Debug.WriteLine("Neuron " + i + ": (" + neurons[i, 1] + ";" + neurons[i, 0] + ")");
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
