namespace Chart.Mvc.Options
{
    public class HoverOptions
    {
        /// <summary>
        /// Sets which elements hover. Acceptable options are 'single', 'label', or 'dataset'. single highlights the closest element. label highlights elements in all datasets at the same X value. dataset highlights the closest dataset.
        /// </summary>
        public string Mode
        {
            get;
            set;
        }

        /// <summary>
        /// Duration in milliseconds it takes to animate hover style changes.
        /// </summary>
        public double? AnimationDuration
        {
            get;
            set;
        }

        /// <summary>
        /// Called when any of the events fire. Called in the context of the chart and passed an array of active elements (bars, points, etc).
        /// </summary>
        public string OnHover
        {
            get;
            set;
        }
    }
}
