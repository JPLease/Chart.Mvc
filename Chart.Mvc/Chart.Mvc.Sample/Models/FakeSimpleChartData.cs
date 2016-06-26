using System.Collections.Generic;
using Chart.Mvc.SimpleChart;

namespace Chart.Mvc.Sample.Models
{
    public static class FakeSimpleChartData
    {
        public static IEnumerable<string> Labels
        {
            get
            {
                return new[]
                           {
                               "Red",
                               "Green",
                               "Yellow"
                           };
            }
        }

        public static IEnumerable<SimpleDataset> Data
        {
            get
            {
                return new List<SimpleDataset>
                {
                    new SimpleDataset
                    {
                        Data = new List<double> { 300, 50, 100 },
                        BackgroundColor = new List<string> { "#F7464A", "#46BFBD", "#FDB45C" },
                        BorderColor = new List<string> { "#FF5A5E", "#5AD3D1", "#FFC870" },
                        Label = "My dataset"
                    }
                };
            }
        }
    }
}