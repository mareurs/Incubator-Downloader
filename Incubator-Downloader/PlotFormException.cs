using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Incubator_Downloader
{
    public class PlotFormException : Exception
    {
        public PlotFormException():base()
        {
        }

        public PlotFormException(string message):base(message)
        {

        }
    }
}
