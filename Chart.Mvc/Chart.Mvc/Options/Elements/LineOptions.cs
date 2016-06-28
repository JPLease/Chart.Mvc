using System.Collections.Generic;

namespace Chart.Mvc.Options.Elements
{
    public class LineOptions
    {
        /// <summary>
        /// Default bezier curve tension. Set to 0 for no bezier curves.
        /// </summary>
        public double? Tension
        {
            get;
            set;
        }

        /// <summary>
        /// Default line fill color.
        /// </summary>
        public string BackgroundColor
        {
            get;
            set;
        }

        /// <summary>
        /// Default line stroke width.
        /// </summary>
        public double? BorderWidth
        {
            get;
            set;
        }

        /// <summary>
        /// Default line stroke color.
        /// </summary>
        public string BorderColor
        {
            get;
            set;
        }

        /// <summary>
        /// Default line cap style. See MDN.
        /// </summary>
        public string BorderCapStyle
        {
            get;
            set;
        }

        /// <summary>
        /// Default line dash. See MDN.
        /// </summary>
        public List<double> BorderDash
        {
            get;
            set;
        }

        /// <summary>
        /// Default line dash offset. See MDN.
        /// </summary>
        public double? BorderDashOffset
        {
            get;
            set;
        }

        /// <summary>
        /// Default line join style. See MDN.
        /// </summary>
        public string BorderJoinStyle
        {
            get;
            set;
        }

        /// <summary>
        /// If true, the line is filled.
        /// </summary>
        public bool? Fill
        {
            get;
            set;
        }
    }
}
