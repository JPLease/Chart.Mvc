namespace Chart.Mvc.ComplexChart.Options
{
    public class AxisOptions
    {
        public string Type { get; set; }

        public bool? Display { get; set; }

        public string Id { get; set; }

        public bool? Stacked { get; set; }

        public double? CategoryPercentage { get; set; }

        public double? BarPercentage { get; set; }

        public string Position { get; set; }

        #region Events

        public string BeforeUpdate { get; set; }

        public string BeforeSetDimensions { get; set; }

        public string AfterSetDimensions { get; set; }

        public string BeforeDataLimits { get; set; }

        public string AfterDataLimits { get; set; }

        public string BeforeBuildTicks { get; set; }

        public string AfterBuildTicks { get; set; }

        public string BeforeTickToLabelConversion { get; set; }

        public string AfterTickToLabelConversion { get; set; }

        public string BeforeCalculateTickRotation { get; set; }

        public string AfterCalculateTickRotation { get; set; }

        public string BeforeFit { get; set; }

        public string AfterFit { get; set; }

        public string AfterUpdate { get; set; }

        #endregion

        public GridLinesOptions GridLines { get; set; }

        public ScaleLabelOptions ScaleLabel { get; set; }

        public TicksOptions Ticks { get; set; }
    }
}
