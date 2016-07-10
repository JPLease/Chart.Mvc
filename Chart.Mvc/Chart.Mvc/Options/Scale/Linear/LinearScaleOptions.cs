namespace Chart.Mvc.Options.Scale.Linear
{
    /// <summary>
    /// The linear scale is used to chart numerical data. It can be placed on either the x or y axis.
    /// </summary>
    public class LinearScaleOptions : ScaleOptions<LinearTicksOptions, GridLinesOptions>
    {
        public override string Type
        {
            get
            {
                return "linear";
            }
        }
    }
}
