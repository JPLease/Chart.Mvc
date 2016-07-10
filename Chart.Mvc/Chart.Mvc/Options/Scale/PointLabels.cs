namespace Chart.Mvc.Options.Scale
{
    /// <summary>
    /// The following options are used to configure the point labels that are shown on the perimeter of the scale. Note that these options only apply if lineArc is false.
    /// </summary>
    public class PointLabels
    {
        /// <summary>
        /// Callback function to transform data label to axis label.
        /// </summary>
        public string Callback
        {
            get;
            set;
        }

        /// <summary>
        /// Font color.
        /// </summary>
        public string FontColor
        {
            get;
            set;
        }

        /// <summary>
        /// Font family to render.
        /// </summary>
        public string FontFamily
        {
            get;
            set;
        }

        /// <summary>
        /// Font size in pixels.
        /// </summary>
        public double? FontSize
        {
            get;
            set;
        }

        /// <summary>
        /// 	Font Style to use.
        /// </summary>
        public string FontStyle
        {
            get;
            set;
        }
    }
}
