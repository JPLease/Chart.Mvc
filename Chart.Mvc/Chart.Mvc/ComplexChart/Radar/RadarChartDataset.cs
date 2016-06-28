using System.Collections.Generic;

namespace Chart.Mvc.ComplexChart
{
    public class RadarChartDataset : ComplexDataset
    {
        /// <summary>
        /// If true, fill the area under the line.
        /// </summary>
        public bool? Fill
        {
            get;
            set;
        }

        /// <summary>
        /// Bezier curve tension of the line. Set to 0 to draw straightlines. Note This was renamed from 'tension' but the old name still works.
        /// </summary>
        public double? LineTension
        {
            get;
            set;
        }

        #region Border

        /// <summary>
        /// Cap style of the line.
        /// </summary>
        public string BorderCapStyle
        {
            get;
            set;
        }

        /// <summary>
        /// Length and spacing of dashes.
        /// </summary>
        public List<double> BorderDash
        {
            get;
            set;
        }

        /// <summary>
        /// Offset for line dashes.
        /// </summary>
        public double? BorderDashOffset
        {
            get;
            set;
        }

        /// <summary>
        /// Line joint style.
        /// </summary>
        public string BorderJoinStyle
        {
            get;
            set;
        }

        #endregion Border

        #region Points

        /// <summary>
        /// The border color for points.
        /// </summary>
        public string PointBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// The fill color for points.
        /// </summary>
        public string PointBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// The width of the point border in pixels.
        /// </summary>
        public double? PointBorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// The radius of the point shape. If set to 0, nothing is rendered.
        /// </summary>
        public double? PointRadius
        {
            get;
            set;
        }

        /// <summary>
        /// The radius of the point when hovered.
        /// </summary>
        public double? PointHoverRadius
        {
            get;
            set;
        }

        /// <summary>
        /// The pixel size of the non-displayed point that reacts to mouse events.
        /// </summary>
        public double? PointHitRadius
        {
            get;
            set;
        }

        /// <summary>
        /// Point background color when hovered.
        /// </summary>
        public string PointHoverBackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Point border color when hovered.
        /// </summary>
        public string PointHoverBorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Border width of point when hovered.
        /// </summary>
        public double? PointHoverBorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// The style of point. Options are 'circle', 'triangle', 'rect', 'rectRot', 'cross', 'crossRot', 'star', 'line', and 'dash'.
        /// </summary>
        public string PointStyle
        {
            get;
            set;
        }

        #endregion Points
    }
}
