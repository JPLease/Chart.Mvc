using Chart.Mvc.Options;
using Chart.Mvc.Options.Elements;
using System.Collections.Generic;

namespace Chart.Mvc
{
    /// <summary>
    /// The global chart options.
    /// </summary>
    public abstract class GlobalChartOptions
    {
        #region Common Chart Configuration

        /// <summary>
        /// TODO:
        /// </summary>
        public string DefaultColor
        {
            get;
            set;
        }

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

        #endregion Common Chart Configuration

        /// <summary>
        /// TODO:
        /// </summary>
        public TitleOptions Title
        {
            get;
            set;
        }

        /// <summary>
        /// TODO:
        /// </summary>
        public LegendOptions Legend
        {
            get;
            set;
        }

        /// <summary>
        /// TODO:
        /// </summary>
        public TooltipsOptions Tooltips
        {
            get;
            set;
        }

        /// <summary>
        /// TODO:
        /// </summary>
        public HoverOptions Hover
        {
            get;
            set;
        }

        /// <summary>
        /// TODO:
        /// </summary>
        public AnimationOptions Animation
        {
            get;
            set;
        }

        /// <summary>
        /// TODO:
        /// </summary>
        public ElementsOptions Elements
        {
            get;
            set;
        }
    }
}
