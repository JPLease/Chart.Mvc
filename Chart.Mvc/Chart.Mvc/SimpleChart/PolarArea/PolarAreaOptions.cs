using Chart.Mvc.Options.Scale;

namespace Chart.Mvc.SimpleChart
{
    /// <summary>
    /// The polar area options.
    /// </summary>
    public class PolarAreaOptions : SimpleChartOptions
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
