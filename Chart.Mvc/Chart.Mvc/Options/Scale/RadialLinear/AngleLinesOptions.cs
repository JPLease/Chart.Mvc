namespace Chart.Mvc.Options.Scale.RadialLinear
{
    /// <summary>
    /// The following options are used to configure angled lines that radiate from the center of the chart to the point labels.
    /// </summary>
    public class AngleLinesOptions
    {
        /// <summary>
        /// If true, angle lines are shown..
        /// </summary>
        public bool? Display
        {
            get;
            set;
        }

        /// <summary>
        /// Color of angled lines.
        /// </summary>
        public string Color
        {
            get;
            set;
        }

        /// <summary>
        /// Width of angled lines.
        /// </summary>
        public double? LineWidth
        {
            get;
            set;
        }
    }
}
