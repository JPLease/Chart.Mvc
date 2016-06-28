namespace Chart.Mvc.Options.Elements
{
    public class ArcOptions
    {
        /// <summary>
        /// Default fill color for arcs. Inherited from the global default.
        /// </summary>
        public string BackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Default stroke color for arcs.
        /// </summary>
        public string BorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Default stroke width for arcs.
        /// </summary>
        public double? BorderWidth
        {
            get;
            set;
        }
    }
}
