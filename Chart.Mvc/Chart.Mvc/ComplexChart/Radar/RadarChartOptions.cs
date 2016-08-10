using Chart.Mvc.Options.Scale;

namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The radar chart options.
    /// </summary>
    public class RadarChartOptions : ComplexChartOptions
    {
        /// <summary>
        /// Use this to style the ticks, labels, and grid lines.
        /// </summary>
        public ScaleOptions Scale
        {
            get;
            set;
        }
    }
}
