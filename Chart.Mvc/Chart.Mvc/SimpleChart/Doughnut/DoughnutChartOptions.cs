namespace Chart.Mvc.SimpleChart
{
    /// <summary>
    /// The doughnut chart options.
    /// </summary>
    public class DoughnutChartOptions : SimpleChartOptions
    {
        /// <summary>
        /// The percentage of the chart that is cut out of the middle.
        /// </summary>
        public double? CutoutPercentage
        {
            get;
            set;
        }

        /// <summary>
        /// Starting angle to draw arcs from.
        /// </summary>
        public double? Rotation
        {
            get;
            set;
        }

        /// <summary>
        /// Sweep to allow arcs to cover.
        /// </summary>
        public double? Circumference
        {
            get;
            set;
        }
    }
}
