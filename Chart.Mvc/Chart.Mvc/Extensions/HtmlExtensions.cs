using System.Text;
using System.Web.Mvc;
using Chart.Mvc.ComplexChart;
using Chart.Mvc.SimpleChart;

namespace Chart.Mvc.Extensions
{
    /// <summary>
    /// The html extensions.
    /// </summary>
    public static class HtmlExtensions
    {
        /// <summary>
        /// The create chart.
        /// </summary>
        /// <param name="htmlHelper">
        /// The html helper.
        /// </param>
        /// <param name="canvasId">
        /// The canvas id.
        /// </param>
        /// <param name="complexChart">
        /// The complex chart.
        /// </param>
        /// <returns>
        /// The <see cref="MvcHtmlString"/>.
        /// </returns>
        public static MvcHtmlString CreateChart<TComplexChartOptions, TComplexDataset>(this HtmlHelper htmlHelper, string canvasId, ComplexChartBase<TComplexChartOptions, TComplexDataset> complexChart) where TComplexChartOptions : ComplexChartOptions where TComplexDataset : ComplexDataset
        {
            return CreateChart(canvasId, complexChart.ChartType.ToString(), complexChart.ComplexData.ToJson(), complexChart.ChartConfiguration.ToJson());
        }

        /// <summary>
        /// The create chart.
        /// </summary>
        /// <param name="htmlHelper">
        /// The html helper.
        /// </param>
        /// <param name="canvasId">
        /// The canvas id.
        /// </param>
        /// <param name="simpleChart">
        /// The simple chart.
        /// </param>
        /// <returns>
        /// The <see cref="MvcHtmlString"/>.
        /// </returns>
        public static MvcHtmlString CreateChart<TSimpleChartOptions>(this HtmlHelper htmlHelper, string canvasId, SimpleChartBase<TSimpleChartOptions> simpleChart) where TSimpleChartOptions : SimpleChartOptions
        {
            return CreateChart(canvasId, simpleChart.ChartType.ToString(), simpleChart.Data.ToJson(), simpleChart.ChartConfiguration.ToJson());
        }

        private static MvcHtmlString CreateChart(string canvasId, string chartType, string jsonData, string jsonOptions)
        {
            var tag = new TagBuilder("script");
            tag.Attributes.Add("type", "text/javascript");
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("var ctx = document.getElementById(\"{0}\").getContext(\"2d\");", canvasId);
            stringBuilder.AppendFormat("var data = JSON.parse('{0}');", jsonData);
            stringBuilder.AppendFormat("var options = JSON.parse('{0}');", jsonOptions);
            stringBuilder.AppendFormat("var {0}_chart = new Chart.{1}(ctx, {{data: data, options: options}});", canvasId, chartType);
            tag.InnerHtml = stringBuilder.ToString();
            return new MvcHtmlString(tag.ToString());
        }

        public static MvcHtmlString ApplyGlobalDefaults(this HtmlHelper htmlHelper, GlobalChartOptions defaults)
        {
            return ApplyGlobalDefaults(defaults.ToJson());
        }

        private static MvcHtmlString ApplyGlobalDefaults(string jsonDefaults)
        {
            var tag = new TagBuilder("script");
            tag.Attributes.Add("type", "text/javascript");
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("var defaults = JSON.parse('{0}');", jsonDefaults);
            stringBuilder.Append("Chart.defaults.global = Chart.helpers.configMerge(Chart.defaults.global, defaults);");
            tag.InnerHtml = stringBuilder.ToString();
            return new MvcHtmlString(tag.ToString());
        }
    }
}
