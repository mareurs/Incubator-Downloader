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
            this.data = data;
            InitializeComponent();
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
            for(int i = 0; i < 300; i++)
            {
                int t1 = rand.Next(300, 500);
                int t2 = rand.Next(300, 500);
                int t3 = rand.Next(300, 500);
                int u = rand.Next(20, 90);
                string val = t1 + ";" + t2 + ";" + t3 + ";" + u;
                data.Add( new DataItem(i, val));
            }
        }
    }
}
