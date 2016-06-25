namespace Chart.Mvc.ComplexChart.Options
{
    public class Ticks2Options
    {
        /// <summary>
        /// If true, scale will inclulde 0 if it is not already included.
        /// </summary>
        public bool? BeginAtZero { get; set; }

        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value from data.
        /// </summary>
        public double? Min { get; set; }

        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value from data.
        /// </summary>
        public double? Max { get; set; }

        /// <summary>
        /// Maximum number of ticks and gridlines to show. If not defined, it will limit to 11 ticks but will show all gridlines.
        /// </summary>
        public double? MaxTicksLimit { get; set; }

        /// <summary>
        /// User defined fixed step size for the scale. If set, the scale ticks will be enumerated by multiple of stepSize, having one tick per increment. If not set, the ticks are labeled automatically using the nice numbers algorithm.
        /// </summary>
        public double? StepSize { get; set; }

        /// <summary>
        /// User defined maximum number for the scale, overrides maximum value except for if it is lower than the maximum value.
        /// </summary>
        public double? SuggestedMax { get; set; }

        /// <summary>
        /// User defined minimum number for the scale, overrides minimum value except for if it is higher than the minimum value.
        /// </summary>
        public double? SuggestedMin { get; set; }
    }
}
