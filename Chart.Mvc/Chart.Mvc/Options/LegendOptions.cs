namespace Chart.Mvc.Options
{
    public class LegendOptions
    {
        /// <summary>
        /// Is the legend displayed.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Position of the legend. Options are 'top' or 'bottom'.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Marks that this box should take the full width of the canvas (pushing down other boxes).
        /// </summary>
        public bool? FullWidth { get; set; }

        /// <summary>
        /// A callback that is called when a click is registered on top of a label item.
        /// </summary>
        public string OnClick { get; set; }

        /// <summary>
        /// See the Legend Label Configuration section below.
        /// </summary>
        public LegendLabelOptions Labels { get; set; }
    }
}
