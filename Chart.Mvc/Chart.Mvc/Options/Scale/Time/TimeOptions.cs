namespace Chart.Mvc.Options.Scale.Time
{
    public class TimeOptions
    {
        /// <summary>
        /// If true and the unit is set to 'week', iso weekdays will be used.
        /// </summary>
        public bool? IsoWeekday
        {
            get;
            set;
        }

        /// <summary>
        /// If defined, this will override the data maximum.
        /// </summary>
        public string Max
        {
            get;
            set;
        }

        /// <summary>
        /// If defined, this will override the data minimum.
        /// </summary>
        public string Min
        {
            get;
            set;
        }

        /// <summary>
        /// If defined as a string, it is interpreted as a custom format to be used by moment to parse the date. If this is a function, it must return a moment.js object given the appropriate data value.
        /// </summary>
        public string Parser
        {
            get;
            set;
        }

        /// <summary>
        /// If defined, dates will be rounded to the start of this unit. See Time Units below for the allowed units.
        /// </summary>
        public string Round
        {
            get;
            set;
        }

        /// <summary>
        /// The moment js format string to use for the tooltip.
        /// </summary>
        public string TooltipFormat
        {
            get;
            set;
        }

        /// <summary>
        /// If defined, will force the unit to be a certain type. See Time Units section below for details.
        /// </summary>
        public string Unit
        {
            get;
            set;
        }

        /// <summary>
        /// The number of units between grid lines.
        /// </summary>
        public double? UnitStepSize
        {
            get;
            set;
        }

        /// <summary>
        /// TODO:
        /// </summary>
        public DisplayFormatsOptions DisplayFormats
        {
            get;
            set;
        }
    }
}
