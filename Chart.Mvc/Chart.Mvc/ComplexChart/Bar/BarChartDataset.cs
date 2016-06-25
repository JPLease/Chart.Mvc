using System.Collections.Generic;

namespace Chart.Mvc.ComplexChart
{
    public class BarChartDataset : ComplexDataset
    {
        /// <summary>
        /// The ID of the x axis to plot this dataset on.
        /// </summary>
        public string XAxisID
        {
            get;
            set;
        }

        /// <summary>
        /// The ID of the y axis to plot this dataset on.
        /// </summary>
        public string YAxisID
        {
            get;
            set;
        }

        /// <summary>
        /// The fill color of the bars.
        /// </summary>
        public List<string> BackgroundColor
        {
            get;
            set;
        }

        #region Border

        /// <summary>
        /// Bar border color.
        /// </summary>
        public List<string> BorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Border width of bar in pixels.
        /// </summary>
        public List<double> BorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// Which edge to skip drawing the border for. Options are 'bottom', 'left', 'top', and 'right'.
        /// </summary>
        public List<string> BorderSkipped
        {
            get;
            set;
        }

        #endregion

        #region Hover

        /// <summary>
        /// Bar background color when hovered.
        /// </summary>
        public List<string> HoverBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Bar border color when hovered.
        /// </summary>
        public List<string> HoverBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Border width of bar when hovered.
        /// </summary>
        public List<double> HoverBorderWidth
        {
            get;
            set;
        }

        #endregion
    }
}
