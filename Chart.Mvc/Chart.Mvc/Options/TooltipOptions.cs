namespace Chart.Mvc.Options
{
    public class TooltipOptions
    {
        /// <summary>
        /// Are tooltips.
        /// </summary>
        public bool? Enabled { get; set; }

        /// <summary>
        /// See section below.
        /// </summary>
        public string Custom { get; set; }

        /// <summary>
        /// Sets which elements appear in the tooltip. Acceptable options are 'single' or 'label'. single highlights the closest element. label highlights elements in all datasets at the same X value.
        /// </summary>
        public string Mode { get; set; }

        /// <summary>
        /// Background color of the tooltip.
        /// </summary>
        public string BackgroundColor { get; set; }

        #region Title

        /// <summary>
        /// Font family for tooltip title inherited from global font family.
        /// </summary>
        public string TitleFontFamily { get; set; }

        /// <summary>
        /// Font size for tooltip title inherited from global font size.
        /// </summary>
        public double? TitleFontSize { get; set; }

        /// <summary>
        /// Font style for tooltip title.
        /// </summary>
        public string TitleFontStyle { get; set; }

        /// <summary>
        /// Font color for tooltip title.
        /// </summary>
        public string TitleFontColor { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each title line.
        /// </summary>
        public double? TitleSpacing { get; set; }

        /// <summary>
        /// Margin to add on bottom of title section.
        /// </summary>
        public double? TitleMarginBottom { get; set; }

        #endregion

        #region Body

        /// <summary>
        /// Font family for tooltip items inherited from global font family.
        /// </summary>
        public string BodyFontFamily { get; set; }

        /// <summary>
        /// Font size for tooltip items inherited from global font size.
        /// </summary>
        public double? BodyFontSize { get; set; }

        /// <summary>
        /// Font style for tooltip items.
        /// </summary>
        public string BodyFontStyle { get; set; }

        /// <summary>
        /// Font color for tooltip items.
        /// </summary>
        public string BodyFontColor { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each tooltip item.
        /// </summary>
        public double? BodySpacing { get; set; }

        #endregion

        #region Footer

        /// <summary>
        /// Font family for tooltip footer inherited from global font family.
        /// </summary>
        public string FooterFontFamily { get; set; }

        /// <summary>
        /// Font size for tooltip footer inherited from global font size.
        /// </summary>
        public double? FooterFontSize { get; set; }

        /// <summary>
        /// Font style for tooltip footer.
        /// </summary>
        public string FooterFontStyle { get; set; }

        /// <summary>
        /// Font color for tooltip footer.
        /// </summary>
        public string FooterFontColor { get; set; }

        /// <summary>
        /// Spacing to add to top and bottom of each footer line.
        /// </summary>
        public double? FooterSpacing { get; set; }

        /// <summary>
        /// Margin to add before drawing the footer.
        /// </summary>
        public double? FooterMarginTop { get; set; }

        #endregion

        /// <summary>
        /// Padding to add on left and right of tooltip.
        /// </summary>
        public double? XPadding { get; set; }

        /// <summary>
        /// Padding to add on top and bottom of tooltip.
        /// </summary>
        public double? YPadding { get; set; }

        /// <summary>
        /// Size, in px, of the tooltip arrow.
        /// </summary>
        public double? CaretSize { get; set; }

        /// <summary>
        /// Radius of tooltip corner curves.
        /// </summary>
        public double? CornerRadius { get; set; }

        /// <summary>
        /// Color to draw behind the colored boxes when multiple items are in the tooltip.
        /// </summary>
        public string MultiKeyBackground { get; set; }

        /// <summary>
        /// See the callbacks section below.
        /// </summary>
        public TooltipCallbackOptions Callbacks { get; set; }
    }
}
