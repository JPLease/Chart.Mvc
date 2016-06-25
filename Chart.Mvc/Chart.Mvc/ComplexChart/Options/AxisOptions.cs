namespace Chart.Mvc.ComplexChart.Options
{
    public class AxisOptions
    {
        /// <summary>
        /// Type of scale being employed. Custom scales can be created and registered with a string key. Options: "category", "linear", "logarithmic", "time", "radialLinear".
        /// </summary>
        public string Type
        {
            get;
            set;
        }

        /// <summary>
        /// If true, show the scale including gridlines, ticks, and labels. Overrides gridLines.display, scaleLabel.display, and ticks.display.
        /// </summary>
        public bool? Display
        {
            get;
            set;
        }

        /// <summary>
        /// Id of the axis so that data can bind to it.
        /// </summary>
        public string Id
        {
            get;
            set;
        }

        /// <summary>
        /// If true, bars are stacked on the x-axis.
        /// </summary>
        public bool? Stacked
        {
            get;
            set;
        }

        /// <summary>
        /// Percent (0-1) of the available width (the space between the gridlines for small datasets) for each data-point to use for the bars.
        /// </summary>
        public double? CategoryPercentage
        {
            get;
            set;
        }

        /// <summary>
        /// Percent (0-1) of the available width each bar should be within the category percentage. 1.0 will take the whole category width and put the bars right next to each other.
        /// </summary>
        public double? BarPercentage
        {
            get;
            set;
        }

        /// <summary>
        /// Position of the scale. Possible values are 'top', 'left', 'bottom' and 'right'.
        /// </summary>
        public string Position
        {
            get;
            set;
        }

        #region Events

        /// <summary>
        /// Callback called before the update process starts. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeUpdate { get; set; }

        /// <summary>
        /// Callback that runs before dimensions are set. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeSetDimensions { get; set; }

        /// <summary>
        /// Callback that runs after dimensions are set. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterSetDimensions { get; set; }

        /// <summary>
        /// Callback that runs before data limits are determined. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeDataLimits { get; set; }

        /// <summary>
        /// Callback that runs after data limits are determined. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterDataLimits { get; set; }

        /// <summary>
        /// Callback that runs before ticks are created. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeBuildTicks { get; set; }

        /// <summary>
        /// Callback that runs after ticks are created. Useful for filtering ticks. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterBuildTicks { get; set; }

        /// <summary>
        /// Callback that runs before ticks are converted into strings. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeTickToLabelConversion { get; set; }

        /// <summary>
        /// Callback that runs after ticks are converted into strings. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterTickToLabelConversion { get; set; }

        /// <summary>
        /// Callback that runs before tick rotation is determined. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeCalculateTickRotation { get; set; }

        /// <summary>
        /// Callback that runs after tick rotation is determined. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterCalculateTickRotation { get; set; }

        /// <summary>
        /// Callback that runs before the scale fits to the canvas. Passed a single argument, the scale instance.
        /// </summary>
        public string BeforeFit { get; set; }

        /// <summary>
        /// Callback that runs after the scale fits to the canvas. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterFit { get; set; }

        /// <summary>
        /// Callback that runs at the end of the update process. Passed a single argument, the scale instance.
        /// </summary>
        public string AfterUpdate { get; set; }

        #endregion

        /// <summary>
        /// TODO:
        /// </summary>
        public GridLinesOptions GridLines
        {
            get;
            set;
        }

        /// <summary>
        /// TODO:
        /// </summary>
        public ScaleLabelOptions ScaleLabel
        {
            get;
            set;
        }

        /// <summary>
        /// TODO:
        /// </summary>
        public TicksOptions Ticks
        {
            get;
            set;
        }
    }
}
