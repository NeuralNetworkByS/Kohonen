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
        private float[,] neuronsPrev;
        float learningRate = 0.00f;
        PointsConverter pc = new PointsConverter();
        int numNeurons = 8;

        public Form1()
        {
            trainingData = new TrainingData();
            InitializeComponent();
            initializeNeurons();
            initNeuronsPrev();
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

        public void initNeuronsPrev()
        {
            neuronsPrev = new float[numNeurons, 3];
            for (int i = 0; i < numNeurons; i++)
            {
                neurons[i, 0] = -1;
                neurons[i, 1] = -1;
                neurons[i, 2] = -1;
            }
        }

        public void trainNeurons(int epochs)
        {
            float neighbourRate = float.Parse(ExtraLearingRate.Text);
            float neighbourDisFactor = 0.1f;

            int i = 0;
            while (neighbourRate > 0)
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
                    

                    if (neighbourUp < numNeurons)
                    {
                        neurons[neighbourUp, 0] += (trainingData.samples[j][0] - neurons[neighbourUp, 0]) * learningRate * neighbourRate;
                        neurons[neighbourUp, 1] += (trainingData.samples[j][1] - neurons[neighbourUp, 1]) * learningRate * neighbourRate;
                    }

                    if (neighbourDown >= 0)
                    {
                        neurons[neighbourDown, 0] += (trainingData.samples[j][0] - neurons[neighbourDown, 0]) * learningRate * neighbourRate;
                        neurons[neighbourDown, 1] += (trainingData.samples[j][1] - neurons[neighbourDown, 1]) * learningRate * neighbourRate;
                    }

                    

                    neurons[minIndex, 0] += (trainingData.samples[j][0] - neurons[minIndex, 0]) * learningRate;
                    neurons[minIndex, 1] += (trainingData.samples[j][1] - neurons[minIndex, 1]) * learningRate;
                }

                // debug
                Debug.Write("Epoch: " + i + ". ");
                bool isNeuronsStop = true;
                for (int z = 0; z < numNeurons; z++)
                {
                   
                    if (neurons[z, 0] != neuronsPrev[z, 0] && neurons[z,1] != neuronsPrev[z, 1])
                    {
                        Debug.Write(z + ". Nie. ");
                        isNeuronsStop = false;
                        break;
                    }
                    else
                    {
                        Debug.Write(z + ". Tak. ");
                    }
                }

                if (isNeuronsStop)
                {
                    neighbourRate -= neighbourDisFactor;
                    if (neighbourRate < 0.1)
                    {
                        neighbourDisFactor = 0.01f;
                    }
                    Debug.WriteLine("nRate: " + neighbourRate);
                }

                for (int z = 0; z < numNeurons; z++)
                {
                    neuronsPrev[z, 0] = neurons[z, 0];
                    neuronsPrev[z, 1] = neurons[z, 1];
                }

                Debug.WriteLine("");
                i++;
            }

           

            /*
            for (int i = 0; i < numNeurons; i++)
            {
                Debug.WriteLine("Neuron " + i + ": (" + neurons[i, 1] + ";" + neurons[i, 0] + ")");
            }*/
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            new Chart(pc.FromRectangular(trainingData.samples), neurons).Show();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            initializeNeurons();
            initNeuronsPrev();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
