namespace Chart.Mvc.Options.Scale
{
    public class RadialLinearScaleOptions : ScaleOptions<TicksOptions>
    {
        public override string Type
        {
            get
            {
                return "radialLinear";
            }
        }
    }
}
