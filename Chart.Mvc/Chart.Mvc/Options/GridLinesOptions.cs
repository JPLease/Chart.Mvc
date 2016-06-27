namespace Chart.Mvc.Options
{
    public class GridLinesOptions
    {
        /// <summary>
        /// 
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Color of the grid lines.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Stroke width of grid lines.
        /// </summary>
        public double? LineWidth { get; set; }

        /// <summary>
        /// If true draw border on the edge of the chart.
        /// </summary>
        public bool? DrawBorder { get; set; }

        /// <summary>
        /// If true, draw lines on the chart area inside the axis lines. This is useful when there are multiple axes and you need to control which grid lines are drawn.
        /// </summary>
        public bool? DrawOnChartArea { get; set; }

        /// <summary>
        /// If true, draw lines beside the ticks in the axis area beside the chart.
        /// </summary>
        public bool? DrawTicks { get; set; }

        /// <summary>
        /// Length in pixels that the grid lines will draw into the axis area.
        /// </summary>
        public double? TickMarkLength { get; set; }

        /// <summary>
        /// Stroke width of the grid line for the first index (index 0).
        /// </summary>
        public double? ZeroLineWidth { get; set; }

        /// <summary>
        /// Stroke color of the grid line for the first index (index 0).
        /// </summary>
        public string ZeroLineColor { get; set; }

        /// <summary>
        /// If true, offset labels from grid lines.
        /// </summary>
        public bool? OffsetGridLines { get; set; }
    }
}
