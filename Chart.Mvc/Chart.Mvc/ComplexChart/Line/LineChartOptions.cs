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
        public bool? ShowLines { get; set; }
    }
}
