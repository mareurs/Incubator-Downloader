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
            double[] temps = new Double[3];

            for( int i = 0; i < 3; i++)
                temps[i] = Convert.ToDouble(values[i].Trim());
            U = Convert.ToInt32(values[3]);

            this.index = index;
            T1 = temps[0];
            T2 = temps[1];
            T3 = temps[2];
        }

    }
}
