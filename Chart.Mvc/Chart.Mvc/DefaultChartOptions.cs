namespace Chart.Mvc
{
    public class DefaultChartOptions : GlobalChartOptions
    {
        /// <summary>
        /// Default font color for all text.
        /// </summary>
        public string DefaultFontColor
        {
            get;
            set;
        }

        /// <summary>
        /// Default font family for all text.
        /// </summary>
        public string DefaultFontFamily
        {
            get;
            set;
        }

        /// <summary>
        /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
        /// </summary>
        public double? DefaultFontSize
        {
            get;
            set;
        }

        /// <summary>
        /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title.
        /// </summary>
        public string DefaultFontStyle
        {
            get;
            set;
        }
    }
}
