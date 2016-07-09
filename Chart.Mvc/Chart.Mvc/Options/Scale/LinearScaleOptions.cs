namespace Chart.Mvc.Options.Scale
{
    public class LinearScaleOptions : ScaleOptions<TicksOptions>
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
