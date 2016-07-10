namespace Chart.Mvc.Options.Scale
{
    public class CategoryTicksOptions : TicksOptions
    {
        /// <summary>
        /// The minimum item to display. Must be a value in the labels array.
        /// </summary>
        public string Min
        {
            get;
            set;
        }

        /// <summary>
        /// The maximum item to display. Must be a value in the labels array.
        /// </summary>
        public string Max
        {
            get;
            set;
        }
    }
}
