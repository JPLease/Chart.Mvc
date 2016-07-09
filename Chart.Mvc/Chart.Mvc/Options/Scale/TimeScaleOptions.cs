namespace Chart.Mvc.Options.Scale
{
    public class TimeScaleOptions : ScaleOptions<TicksOptions>
    {
        public override string Type
        {
            get
            {
                return "time";
            }
        }
    }
}
