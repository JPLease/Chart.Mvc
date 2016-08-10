using Chart.Mvc.ComplexChart;
using Chart.Mvc.Options.Scale;
using Chart.Mvc.SimpleChart;
using System.Text;
using System.Web.Mvc;

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
            return CreateChart(canvasId, complexChart.ChartType.ToCamelCaseString(), complexChart.ComplexData.ToJson(), complexChart.ChartConfiguration.ToJson());
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
        public static MvcHtmlString CreateChart<TSimpleChartOptions, TSimpleDataset>(this HtmlHelper htmlHelper, string canvasId, SimpleChartBase<TSimpleChartOptions, TSimpleDataset> simpleChart) where TSimpleChartOptions : SimpleChartOptions where TSimpleDataset : SimpleDataset
        {
            return CreateChart(canvasId, simpleChart.ChartType.ToCamelCaseString(), simpleChart.SimpleData.ToJson(), simpleChart.ChartConfiguration.ToJson());
        }

        private static MvcHtmlString CreateChart(string canvasId, string chartType, string jsonData, string jsonOptions)
        {
            var tag = new TagBuilder("script");
            tag.Attributes.Add("type", "text/javascript");
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("var ctx = document.getElementById(\"{0}\").getContext(\"2d\");", canvasId);
            stringBuilder.AppendFormat("var data = JSON.parse('{0}');", jsonData);
            stringBuilder.AppendFormat("var options = JSON.parse('{0}');", jsonOptions);
            stringBuilder.AppendFormat("var {0}_chart = new Chart(ctx, {{type: '{1}', data: data, options: options}});", canvasId, chartType);
            tag.InnerHtml = stringBuilder.ToString();
            return new MvcHtmlString(tag.ToString());
        }

        public static MvcHtmlString ApplyGlobalDefaults(this HtmlHelper htmlHelper, DefaultChartOptions defaults)
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

        public static MvcHtmlString UpdateScaleDefaults(this HtmlHelper htmlHelper, ScaleOptions scaleOptions)
        {
            return UpdateScaleDefaults(scaleOptions.Type, scaleOptions.ToJson());
        }

        private static MvcHtmlString UpdateScaleDefaults(string type, string jsonOptions)
        {
            var tag = new TagBuilder("script");
            tag.Attributes.Add("type", "text/javascript");
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("var scaleOptions = JSON.parse('{0}');", jsonOptions);
            stringBuilder.AppendFormat("Chart.scaleService.updateScaleDefaults('{0}', scaleOptions);", type);
            tag.InnerHtml = stringBuilder.ToString();
            return new MvcHtmlString(tag.ToString());
        }
    }
}
