using System.Collections.Generic;

namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The complex dataset.
    /// </summary>
    public abstract class ComplexDataset
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexDataset"/> class.
        /// </summary>
        public ComplexDataset()
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
        /// The fill color under the line.
        /// </summary>
        public string BackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Bar border color.
        /// </summary>
        public string BorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Border width of bar in pixels.
        /// </summary>
        public double? BorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        public List<double> Data
        {
            get;
            set;
        }
    }
}
