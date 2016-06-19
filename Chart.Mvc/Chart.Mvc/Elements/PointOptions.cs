namespace Chart.Mvc.Elements
{
    public class PointOptions
    {
        /// <summary>
        /// Default point radius.
        /// </summary>
        public double? Radius { get; set; }

        /// <summary>
        /// Default point style.
        /// </summary>
        public string PointStyle { get; set; }

        /// <summary>
        /// Default point fill color.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// Default point stroke width.
        /// </summary>
        public double? BorderWidth { get; set; }

        /// <summary>
        /// Default point stroke color.
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// Extra radius added to point radius for hit detection.
        /// </summary>
        public double? HitRadius { get; set; }

        /// <summary>
        /// Default point radius when hovered.
        /// </summary>
        public double? HoverRadius { get; set; }

        /// <summary>
        /// Default stroke width when hovered.
        /// </summary>
        public double HoverBorderWidth { get; set; }
    }
}
