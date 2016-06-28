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
        /// TODO:
        /// </summary>
        public List<string> BackgroundColor
        {
            get;
            set;
        }

        #region Border

        public List<string> BorderColor
        {
            get;
            set;
        }

        public List<double> BorderWidth
        {
            get;
            set;
        }

        #endregion Border

        #region Hover

        public List<string> HoverBackgroundColor
        {
            get;
            set;
        }

        public List<string> HoverBorderColor
        {
            get;
            set;
        }

        public List<double> HoverBorderWidth
        {
            get;
            set;
        }

        #endregion Hover
    }
}
