namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The complex chart base.
    /// </summary>
    public abstract class ComplexChartBase<TComplexChartOptions, TComplexDataset> 
        where TComplexChartOptions : ComplexChartOptions
        where TComplexDataset : ComplexDataset
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexChartBase"/> class.
        /// </summary>
        protected ComplexChartBase()
        {
            this.ComplexData = new ComplexData<TComplexDataset>();
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public ComplexData<TComplexDataset> ComplexData
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the chart type.
        /// </summary>
        public abstract ComplexChartType ChartType
        {
            get;
        }

        /// <summary>
        /// Gets the chart configuration.
        /// </summary>
        public abstract TComplexChartOptions ChartConfiguration
        {
            get;
        }
    }
}
