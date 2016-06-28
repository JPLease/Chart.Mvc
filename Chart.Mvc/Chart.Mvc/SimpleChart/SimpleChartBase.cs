namespace Chart.Mvc.SimpleChart
{
    /// <summary>
    /// The simple chart base.
    /// </summary>
    public abstract class SimpleChartBase<TSimpleChartOptions, TSimpleDataset>
        where TSimpleChartOptions : SimpleChartOptions
        where TSimpleDataset : SimpleDataset
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleChartBase"/> class.
        /// </summary>
        protected SimpleChartBase()
        {
            this.SimpleData = new SimpleData<TSimpleDataset>();
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public SimpleData<TSimpleDataset> SimpleData
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public abstract SimpleChartType ChartType
        {
            get;
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public abstract TSimpleChartOptions ChartConfiguration
        {
            get;
        }
    }
}
