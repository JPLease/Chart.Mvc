namespace Chart.Mvc.Options
{
    public class LegendLabelOptions
    {
        /// <summary>
        /// Width of coloured box.
        /// </summary>
        public double? BoxWidth
        {
            get;
            set;
        }

        /// <summary>
        /// Font size inherited from global configuration.
        /// </summary>
        public double? FontSize
        {
            get;
            set;
        }

        /// <summary>
        /// Font style inherited from global configuration.
        /// </summary>
        public string FontStyle
        {
            get;
            set;
        }

        /// <summary>
        /// Font color inherited from global configuration.
        /// </summary>
        public string FontColor
        {
            get;
            set;
        }

        /// <summary>
        /// Font family inherited from global configuration.
        /// </summary>
        public string FontFamily
        {
            get;
            set;
        }

        /// <summary>
        /// Padding between rows of colored boxes.
        /// </summary>
        public double? Padding
        {
            get;
            set;
        }

        /// <summary>
        /// Generates legend items for each thing in the legend. Default implementation returns the text + styling for the color box. See Legend Item for details.
        /// </summary>
        public string GenerateLabels
        {
            get;
            set;
        }
    }
}
