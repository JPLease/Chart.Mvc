using Chart.Mvc.Options.Scale;

namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The bar chart options.
    /// </summary>
    public class BarChartOptions : ComplexChartOptions
    {
        /// <summary>
        /// Use this to style the ticks, labels, and grid lines.
        /// </summary>
        public ScalesOptions Scales
        {
            get;
            set;
        }
    }
}
