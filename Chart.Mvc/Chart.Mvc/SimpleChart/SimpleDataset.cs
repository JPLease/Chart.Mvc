using System.Collections.Generic;

namespace Chart.Mvc.SimpleChart
{
    /// <summary>
    /// The simple dataset.
    /// </summary>
    public class SimpleDataset
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleDataset"/> class.
        /// </summary>
        public SimpleDataset()
        {
            this.Data = new List<double>();
        }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        public string Label
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the  data.
        /// </summary>
        public List<double> Data
        {
            get;
            set;
        }

        /// <summary>
        /// The fill color under the line.
        /// </summary>
        public List<string> BackgroundColor
        {
            get;
            set;
        }

        #region Border

        /// <summary>
        /// Point border color.
        /// </summary>
        public List<string> BorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Border width of point in pixels.
        /// </summary>
        public List<double> BorderWidth
        {
            get;
            set;
        }

        #endregion Border

        #region Hover

        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        public List<string> HoverBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Point border color when hovered.
        /// </summary>
        public List<string> HoverBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Point width of bar when hovered.
        /// </summary>
        public List<double> HoverBorderWidth
        {
            get;
            set;
        }

        #endregion Hover
    }
}
