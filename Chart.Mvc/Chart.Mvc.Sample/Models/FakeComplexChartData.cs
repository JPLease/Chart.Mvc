using Chart.Mvc.ComplexChart;
using System.Collections.Generic;

namespace Chart.Mvc.Sample.Models
{
    public static class FakeComplexChartData
    {
        public static IEnumerable<string> Labels
        {
            get
            {
                return new[]
                           {
                               "January",
                               "February",
                               "March",
                               "April",
                               "May",
                               "June",
                               "July"
                           };
            }
        }

        public static IEnumerable<LineChartDataset> LineChartDatasets
        {
            get
            {
                return new List<LineChartDataset>
                           {
                               new LineChartDataset
                                   {
                                       Data = new List<double> { 65, 59, 80, 81, 56, 55, 40 },
                                       Label = "My First dataset",
                                       BackgroundColor = "rgba(220,220,220,0.2)",
                                       BorderColor = "rgba(220,220,220,1)",
                                       PointBackgroundColor = "rgba(220,220,220,1)",
                                       PointBorderColor = "#fff",
                                       PointHoverBackgroundColor = "#fff",
                                       PointHoverBorderColor = "rgba(220,220,220,1)"
                                   },
                               new LineChartDataset
                                   {
                                       Data = new List<double> { 28, 48, 40, 19, 86, 27, 90 },
                                       Label = "My Second dataset",
                                       BackgroundColor = "rgba(151,187,205,0.2)",
                                       BorderColor = "rgba(151,187,205,1)",
                                       PointBackgroundColor = "rgba(151,187,205,1)",
                                       PointBorderColor = "#fff",
                                       PointHoverBackgroundColor = "#fff",
                                       PointHoverBorderColor = "rgba(151,187,205,1)"
                                   }
                           };
            }
        }

        public static IEnumerable<BarChartDataset> BarChartDatasets
        {
            get
            {
                return new List<BarChartDataset>
                           {
                               new BarChartDataset
                                   {
                                       Data = new List<double> { 65, 59, 80, 81, 56, 55, 40 },
                                       Label = "My First dataset",
                                       BackgroundColor = "rgba(220,220,220,0.2)",
                                       BorderColor = "rgba(220,220,220,1)",
                                       BorderWidth = 1,
                                       HoverBackgroundColor = "rgba(220,220,220,1)",
                                       HoverBorderColor = "rgba(220,220,220,0.2)"
                                   },
                               new BarChartDataset
                                   {
                                       Data = new List<double> { 28, 48, 40, 19, 86, 27, 90 },
                                       Label = "My Second dataset",
                                       BackgroundColor = "rgba(151,187,205,0.2)",
                                       BorderColor = "rgba(151,187,205,1)",
                                       BorderWidth = 1,
                                       HoverBackgroundColor = "rgba(151,187,205,1)",
                                       HoverBorderColor = "rgba(151,187,205,0.2)"
                                   }
                           };
            }
        }

        public static IEnumerable<RadarChartDataset> RadarChartDatasets
        {
            get
            {
                return new List<RadarChartDataset>
                           {
                               new RadarChartDataset
                                   {
                                       Data = new List<double> { 65, 59, 80, 81, 56, 55, 40 },
                                       Label = "My First dataset",
                                       BackgroundColor = "rgba(220,220,220,0.2)",
                                       BorderColor = "rgba(220,220,220,1)",
                                       PointBackgroundColor = "rgba(220,220,220,1)",
                                       PointBorderColor = "#fff",
                                       PointHoverBackgroundColor = "#fff",
                                       PointHoverBorderColor = "rgba(220,220,220,1)"
                                   },
                               new RadarChartDataset
                                   {
                                       Data = new List<double> { 28, 48, 40, 19, 86, 27, 90 },
                                       Label = "My Second dataset",
                                       BackgroundColor = "rgba(151,187,205,0.2)",
                                       BorderColor = "rgba(151,187,205,1)",
                                       PointBackgroundColor =  "rgba(151,187,205,1)",
                                       PointBorderColor = "#fff",
                                       PointHoverBackgroundColor = "#fff",
                                       PointHoverBorderColor = "rgba(151,187,205,1)"
                                   }
                           };
            }
        }
    }
}
