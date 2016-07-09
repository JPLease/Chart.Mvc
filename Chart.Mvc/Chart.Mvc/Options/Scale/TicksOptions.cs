namespace Chart.Mvc.Options.Scale
{
    public class TicksOptions
    {
        /// <summary>
        /// If true, automatically calculates how many labels that can be shown and hides labels accordingly. Turn it off to show all labels no matter what.
        /// </summary>
        public bool? AutoSkip
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the string representation of the tick value as it should be displayed on the chart. See callback section below.
        /// </summary>
        public string Callback
        {
            get;
            set;
        }

        /// <summary>
        /// If true, show the ticks.
        /// </summary>
        public bool? Display
        {
            get;
            set;
        }

        /// <summary>
        /// Font color for the tick labels.
        /// </summary>
        public string FontColor
        {
            get;
            set;
        }

        /// <summary>
        /// Font family for the tick labels, follows CSS font-family options.
        /// </summary>
        public string FontFamily
        {
            get;
            set;
        }

        /// <summary>
        /// Font size for the tick labels.
        /// </summary>
        public double? FontSize
        {
            get;
            set;
        }

        /// <summary>
        /// Font style for the tick labels, follows CSS font-style options (i.e. normal, italic, oblique, initial, inherit).
        /// </summary>
        public string FontStyle
        {
            get;
            set;
        }

        /// <summary>
        /// Distance in pixels to offset the label from the centre point of the tick (in the y direction for the x axis, and the x direction for the y axis). Note: this can cause labels at the edges to be cropped by the edge of the canvas.
        /// </summary>
        public double? LabelOffset
        {
            get;
            set;
        }

        /// <summary>
        /// Maximum rotation for tick labels when rotating to condense labels. Note: Rotation doesn't occur until necessary. Note: Only applicable to horizontal scales.
        /// </summary>
        public double? MaxRotation
        {
            get;
            set;
        }

        /// <summary>
        /// Minimum rotation for tick labels. Note: Only applicable to horizontal scales.
        /// </summary>
        public double? MinRotation
        {
            get;
            set;
        }

        /// <summary>
        /// Flips tick labels around axis, displaying the labels inside the chart instead of outside. Note: Only applicable to vertical scales.
        /// </summary>
        public bool? Mirror
        {
            get;
            set;
        }

        /// <summary>
        /// Padding between the tick label and the axis. Note: Only applicable to horizontal scales.
        /// </summary>
        public double? Padding
        {
            get;
            set;
        }

        /// <summary>
        /// Reverses order of tick labels.
        /// </summary>
        public bool? Reverse
        {
            get;
            set;
        }
    }
}
