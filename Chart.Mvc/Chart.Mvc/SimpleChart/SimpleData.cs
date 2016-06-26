using System.Collections.Generic;

namespace Chart.Mvc.SimpleChart
{
    /// <summary>
    /// The simple data.
    /// </summary>
    public class SimpleData<TSimpleDataset> where TSimpleDataset : SimpleDataset
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleData"/> class.
        /// </summary>
        public SimpleData()
        {
            this.Labels = new List<string>();
            this.Datasets = new List<TSimpleDataset>();
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
        public List<TSimpleDataset> Datasets
        {
            get;
            set;
        }
    }
}
