using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incubator_Downloader
{
    public class DataItem
    {
        public int index;
        public double T1;
        public double T2;
        public double T3;
        public int U;

        public DataItem(int index, string data)
        {
            string[] values = data.Split(';');
            int[] intValues = new int[4];

            for( int i = 0; i < 4; i++)
                intValues[i] = Convert.ToInt32(values[i].Trim());

            this.index = index;
            T1 = intValues[0] / 10.0;
            T2 = intValues[1] / 10.0;
            T3 = intValues[2] / 10.0;
            U = intValues[3];
        }

    }
}
