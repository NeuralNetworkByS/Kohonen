using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kohonen.service
{
    class PointsConverter
    {
        public float[,] FromRectangular(List<float[]> table)
        {
            float[,] result = new float[table.Count, 3];

            for (int i = 0; i < table.Count; i++)
            {
                result[i, 0] = table[i][0];
                result[i, 1] = table[i][1];
                result[i, 2] = 0;
            }

            return result;
        }

    }
}
