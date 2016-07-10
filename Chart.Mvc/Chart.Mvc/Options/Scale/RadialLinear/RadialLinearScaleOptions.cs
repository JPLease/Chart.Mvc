namespace Chart.Mvc.Options.Scale.RadialLinear
{
    /// <summary>
    /// The radial linear scale is used specifically for the radar and polar are chart types. It overlays the chart area, rather than being positioned on one of the edges.
    /// </summary>
    public class RadialLinearScaleOptions : ScaleOptions<RadialLinearTicksOptions, GridLinesOptions>
    {
        public override string Type
        {
            get
            {
                return "radialLinear";
            }
        }

        /// <summary>
        /// If true, circular arcs are used else straight lines are used. The former is used by the polar area chart and the latter by the radar chart.
        /// </summary>
        public bool? LineArc
        {
            get;
            set;
        }

        /// <summary>
        /// The following options are used to configure angled lines that radiate from the center of the chart to the point labels.
        /// </summary>
        public AngleLinesOptions AngleLines
        {
            get;
            set;
        }

        /// <summary>
        /// The following options are used to configure the point labels that are shown on the perimeter of the scale. Note that these options only apply if lineArc is false.
        /// </summary>
        public PointLabelsOptions PointLabels
        {
            get;
            set;
        }
    }
}
