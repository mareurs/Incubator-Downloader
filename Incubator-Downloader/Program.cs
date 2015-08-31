using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Incubator_Downloader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        //private static readonly ILog logger = LogManager.GetLogger(typeof(Program));

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                try
                {
                    Application.Run(new MainForm());
                }
                catch (System.Exception ex)
                {
                    if(ex is PlotFormException)
                        MessageBox.Show(ex.Message);
                    else
                        MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
