namespace Chart.Mvc.Options.Scale
{
    /// <summary>
    /// The time scale is used to display times and dates. It can only be placed on the X axis.
    /// </summary>
    public class TimeScaleOptions : ScaleOptions<TicksOptions, GridLinesOptions>
    {
        public override string Type
        {
            get
            {
                return "time";
            }
        }

        /// <summary>
        /// TODO:
        /// </summary>
        public TimeOptions Time
        {
            get;
            set;
        }
    }
}
