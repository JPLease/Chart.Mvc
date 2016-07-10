namespace Chart.Mvc.Options.Scale.Category
{
    /// <summary>
    /// TODO:
    /// </summary>
    public class CategoryScaleOptions : ScaleOptions<CategoryTicksOptions, GridLinesOptions>
    {
        public override string Type
        {
            get
            {
                return "category";
            }
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
    }
}
