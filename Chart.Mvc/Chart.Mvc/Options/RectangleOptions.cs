namespace Chart.Mvc.Options
{
    public class RectangleOptions
    {
        /// <summary>
        /// Default bar fill color.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Default bar stroke width.
        /// </summary>
        public double? BorderWidth { get; set; }

        /// <summary>
        /// Default bar stroke color.
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Default skipped (excluded) border for rectangle. Can be one of bottom, left, top, right.
        /// </summary>
        public string BorderSkipped { get; set; }
    }
}
