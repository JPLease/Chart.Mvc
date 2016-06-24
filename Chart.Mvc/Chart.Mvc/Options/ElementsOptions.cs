namespace Chart.Mvc.Options
{
    public class ElementsOptions
    {
        /// <summary>
        /// Arcs are used in the polar area, doughnut and pie charts.
        /// </summary>
        public ArcOptions Arc
        {
            get;
            set;
        }

        /// <summary>
        /// Line elements are used to represent the line in a line chart.
        /// </summary>
        public LineOptions Line
        {
            get;
            set;
        }

        /// <summary>
        /// Point elements are used to represent the points in a line chart or a bubble chart.
        /// </summary>
        public PointOptions Point {
            get;
            set;
        }

        /// <summary>
        /// Rectangle elements are used to represent the bars in a bar chart.
        /// </summary>
        public RectangleOptions Rectangle
        {
            get;
            set;
        }
    }
}
