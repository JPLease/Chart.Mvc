using Chart.Mvc.Options;
using System.Collections.Generic;

namespace Chart.Mvc
{
    /// <summary>
    /// The global chart options.
    /// </summary>
    public class GlobalChartOptions
    {
        #region Global Font Settings

        /// <summary>
        /// Default font color for all text.
        /// </summary>
        public string DefaultFontColor { get; set; }

        /// <summary>
        /// Default font family for all text.
        /// </summary>
        public string DefaultFontFamily { get; set; }

        /// <summary>
        /// Default font size (in px) for text. Does not apply to radialLinear scale point labels.
        /// </summary>
        public double? DefaultFontSize { get; set; }

        /// <summary>
        /// Default font style. Does not apply to tooltip title or footer. Does not apply to chart title.
        /// </summary>
        public string DefaultFontStyle { get; set; }

        #endregion

        #region Common Chart Configuration

        /// <summary>
        /// Resizes when the canvas container does.
        /// </summary>
        public bool? Responsive
        {
            get;
            set;
        }

        /// <summary>
        /// Duration in milliseconds it takes to animate to new size after a resize event.
        /// </summary>
        public double? ResponsiveAnimationDuration
        {
            get;
            set;
        }

        /// <summary>
        /// Maintain the original canvas aspect ratio (width / height) when resizing.
        /// </summary>
        public bool? MaintainAspectRatio
        {
            get;
            set;
        }

        /// <summary>
        /// Events that the chart should listen to for tooltips and hovering.
        /// </summary>
        public List<string> Events
        {
            get;
            set;
        }

        /// <summary>
        /// Called if the event is of type 'mouseup' or 'click'. Called in the context of the chart and passed an array of active elements.
        /// </summary>
        public string OnClick
        {
            get;
            set;
        }

        /// <summary>
        /// Function to generate a legend. Receives the chart object to generate a legend from. Default implementation returns an HTML string.
        /// </summary>
        public string LegendCallback
        {
            get;
            set;
        }

        #endregion
        
        public TitleOptions Title { get; set; }
        
        public LegendOptions Legend { get; set; }
        
        public TooltipOptions Tooltip { get; set; }

        public HoverOptions Hover { get; set; }

        public AnimationOptions Animation { get; set; }

        public ElementsOptions Elements { get; set; }
    }
}
