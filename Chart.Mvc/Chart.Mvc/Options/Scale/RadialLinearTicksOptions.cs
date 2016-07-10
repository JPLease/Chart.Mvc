namespace Chart.Mvc.Options.Scale
{
    public class RadialLinearTicksOptions : TicksOptions
    {
        /// <summary>
        /// Color of label backdrops.
        /// </summary>
        public string BackdropColor
        {
            get;
            set;
        }

        /// <summary>
        /// Horizontal padding of label backdrop.
        /// </summary>
        public double? BackdropPaddingX
        {
            get;
            set;
        }

        /// <summary>
        /// Vertical padding of label backdrop.
        /// </summary>
        public double? BackdropPaddingY
        {
            get;
            set;
        }

        /// <summary>
        /// Maximum number of ticks and gridlines to show. If not defined, it will limit to 11 ticks but will show all gridlines.
        /// </summary>
        public double? MaxTicksLimit
        {
            get;
            set;
        }

        /// <summary>
        /// 	If true, draw a background behind the tick labels.
        /// </summary>
        public bool? ShowLabelBackdrop
        {
            get;
            set;
        }
    }
}
