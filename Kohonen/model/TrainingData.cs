using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohonen.model
{
    class TrainingData
    {
        public List<float[]> samples;

        public TrainingData()
        {
            samples = new List<float[]>();
            initData();
        }

        public void initData()
        {
            samples.Add(new float[2] { 3, 10});
            samples.Add(new float[2] { 6, 4 });
            samples.Add(new float[2] { 6, 11 });
            samples.Add(new float[2] { 8, 7 });
            samples.Add(new float[2] { 9, 2 });
            samples.Add(new float[2] { 13, 10 });
            samples.Add(new float[2] { 14, 3 });
            samples.Add(new float[2] { 17, 10 });

            samples.Add(new float[2] { 4, 11 });
            samples.Add(new float[2] { 4, 8 });
            samples.Add(new float[2] { 5, 11 });
            samples.Add(new float[2] { 5, 9 });

            samples.Add(new float[2] { 6, 3});
            samples.Add(new float[2] { 7, 2 });
            samples.Add(new float[2] { 7, 5});
            samples.Add(new float[2] { 8, 4 });

            samples.Add(new float[2] { 7, 10 });
            samples.Add(new float[2] { 7, 12 });
            samples.Add(new float[2] { 8, 11 });
            samples.Add(new float[2] { 8, 13 });

            samples.Add(new float[2] { 9, 8 });
            samples.Add(new float[2] { 9, 7 });
            samples.Add(new float[2] { 9, 6 });
            samples.Add(new float[2] { 8, 6 });

            samples.Add(new float[2] { 9, 1 });
            samples.Add(new float[2] { 10, 3 });
            samples.Add(new float[2] { 11, 1 });
            samples.Add(new float[2] { 11, 2 });

            samples.Add(new float[2] { 13, 8 });
            samples.Add(new float[2] { 14, 8 });
            samples.Add(new float[2] { 14, 9});
            samples.Add(new float[2] { 14, 10 });

            samples.Add(new float[2] { 14, 4 });
            samples.Add(new float[2] { 14, 1 });
            samples.Add(new float[2] { 16, 4 });
            samples.Add(new float[2] { 16, 3 });

            samples.Add(new float[2] { 17, 9 });
            samples.Add(new float[2] { 17, 11 });
            samples.Add(new float[2] { 18, 9 });
            samples.Add(new float[2] { 18, 10 });

        }

        public void multiplyPointsBy(float n)
        {
            for (int i = 0; i < samples.Count; i++)
            {
                for (int j = 0; j < samples[i].Length; j++)
                {
                    samples[i][j] *= n;
                }
            }
        }
    }
}
