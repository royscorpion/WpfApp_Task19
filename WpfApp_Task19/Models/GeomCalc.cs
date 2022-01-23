using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Task19.Models
{
    static class GeomCalc
    {
        public static double CircumferenceByRadius(double a) => Math.Round(2 * Math.PI * a,3);
    }
}
