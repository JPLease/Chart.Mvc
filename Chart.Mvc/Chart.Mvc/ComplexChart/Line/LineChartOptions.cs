using Chart.Mvc.Options;
using Chart.Mvc.Options.Scale;

namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The line chart options.
    /// </summary>
    public class LineChartOptions  : ComplexChartOptions
    {
        /// <summary>
        /// If false, the lines between points are not drawn.
        /// </summary>
        public bool? ShowLines
        {
            get;
            set;
        }

        /// <summary>
        /// TODO:
        /// </summary>
        public ScalesOptions Scales
        {
            get;
            set;
        }
    }
}
