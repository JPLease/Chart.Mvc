using System.Collections.Generic;

namespace Chart.Mvc.ComplexChart
{
    /// <summary>
    /// The complex data.
    /// </summary>
    public class ComplexData<TComplexDataset> where TComplexDataset : ComplexDataset
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexData"/> class.
        /// </summary>
        public ComplexData()
        {
            this.Labels = new List<string>();
            this.Datasets = new List<TComplexDataset>();
        }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        public List<string> Labels
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the datasets.
        /// </summary>
        public List<TComplexDataset> Datasets
        {
            get;
            set;
        }
    }
}
