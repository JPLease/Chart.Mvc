namespace Chart.Mvc.Options.Scale
{
    /// <summary>
    /// The logarithmic scale is used to chart numerical data. It can be placed on either the x or y axis.
    /// </summary>
    public class LogarithmicScaleOptions : ScaleOptions<TicksOptions, GridLinesOptions>
    {
        public override string Type
        {
            get
            {
                return "logarithmic";
            }
        }
    }
}
