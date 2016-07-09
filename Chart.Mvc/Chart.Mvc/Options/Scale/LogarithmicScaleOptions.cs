namespace Chart.Mvc.Options.Scale
{
    public class LogarithmicScaleOptions : ScaleOptions<TicksOptions>
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
