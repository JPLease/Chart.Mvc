namespace Chart.Mvc.Options.Scale
{
    public class CategoryScaleOptions : ScaleOptions<Ticks2Options>
    {
        public override string Type
        {
            get
            {
                return "category";
            }
        }
    }
}
