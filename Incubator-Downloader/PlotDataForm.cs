using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incubator_Downloader
{
    public partial class PlotDataForm : Form
    {
        private List<DataItem> data;
        private const string T1_ID = "T1";
        private const string T2_ID = "T2";
        private const string T3_ID = "T3";
        private const string U_ID = "U";

        public PlotDataForm( List<DataItem> data )
        {
            if (data == null || data.Count == 0)
                throw new PlotFormException("Data for plot is null or empty. Nothing to plot");
            this.data = data;
            InitializeComponent();
//            testData();
            populateData();
        }

        private void populateData()
        {
            foreach(DataItem item in data )
            {
                dataChart.Series[T1_ID].Points.AddXY(item.index, item.T1);
                dataChart.Series[T2_ID].Points.AddXY(item.index, item.T2);
                dataChart.Series[T3_ID].Points.AddXY(item.index, item.T3);
                dataChart.Series[U_ID].Points.AddXY(item.index, item.U);
            }

        }

        private void testData()
        {
            Random rand = new Random();
            int T1 = rand.Next(30, 50);
            int T2 = rand.Next(30, 50);
            int T3 = rand.Next(30, 50);
            int U = rand.Next(20, 90);

            double t1,t2,t3;
            int u;
            for (int i = 0; i < 3000; i++)
            {
                if (nextBool())
                    t1 = T1 + rand.NextDouble();
                else
                    t1 = T1 - rand.NextDouble();

                if (nextBool())
                    t2 = T2 + rand.NextDouble();
                else
                    t2 = T2 - rand.NextDouble();

                if (nextBool())
                    t3 = T3 + rand.NextDouble();
                else
                    t3 = T3 - rand.NextDouble();

                if (nextBool())
                    u = U + 1;
                else
                    u = U - 1;

                string val = t1 + ";" + t2 + ";" + t3 + ";" + u;
                data.Add( new DataItem(i, val));
            }
        }


        private bool nextBool()
        {
            Random rand = new Random();
            int i = rand.Next(2);
            if (i == 1)
                return true;
            return false;
        }
    }
}
