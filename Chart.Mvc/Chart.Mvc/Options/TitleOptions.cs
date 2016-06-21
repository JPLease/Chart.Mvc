namespace Chart.Mvc.Options
{
    public class TitleOptions
    {
        /// <summary>
        /// Display the title block.
        /// </summary>
        public bool? Display { get; set; }

        /// <summary>
        /// Position of the title. Only 'top' or 'bottom' are currently allowed.
        /// </summary>
        public string Position { get; set; }

        /// <summary>
        /// Marks that this box should take the full width of the canvas (pushing down other boxes).
        /// </summary>
        public bool? FullWidth { get; set; }

        /// <summary>
        /// 	Font size inherited from global configuration.
        /// </summary>
        public double? FontSize { get; set; }

        /// <summary>
        /// 	Font family inherited from global configuration.
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// Font color inherited from global configuration.
        /// </summary>
        public string FontColor { get; set; }

        /// <summary>
        /// Font styling of the title.
        /// </summary>
        public string FontStyle { get; set; }

        /// <summary>
        /// Number of pixels to add above and below the title text.
        /// </summary>
        public double? Padding { get; set; }

        /// <summary>
        /// Title text.
        /// </summary>
        public string Text { get; set; }
    }
}
