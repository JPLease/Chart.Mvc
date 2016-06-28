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

        #region Border

        /// <summary>
        /// Which edge to skip drawing the border for. Options are 'bottom', 'left', 'top', and 'right'.
        /// </summary>
        public List<string> BorderSkipped
        {
            get;
            set;
        }

        #endregion Border

        #region Hover

        /// <summary>
        /// Bar background color when hovered.
        /// </summary>
        public string HoverBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Bar border color when hovered.
        /// </summary>
        public string HoverBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Border width of bar when hovered.
        /// </summary>
        public double? HoverBorderWidth
        {
            get;
            set;
        }

        #endregion Hover
    }
}
