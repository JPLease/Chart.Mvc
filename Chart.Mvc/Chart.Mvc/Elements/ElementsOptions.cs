namespace Chart.Mvc.Elements
{
    public class ElementsOptions
    {
        private readonly ArcOptions arc = new ArcOptions();
        private readonly LineOptions line = new LineOptions();
        private readonly PointOptions point = new PointOptions();
        private readonly RectangleOptions rectangle = new RectangleOptions();

        public ArcOptions Arc { get { return arc; } }

        public LineOptions Line { get { return line; } }

        public PointOptions Point { get { return point; } }

        public RectangleOptions Rectangle { get { return rectangle; } }
    }
}
