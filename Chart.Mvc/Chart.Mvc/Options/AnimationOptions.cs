namespace Chart.Mvc.Options
{
    public class AnimationOptions
    {
        /// <summary>
        /// The number of milliseconds an animation takes.
        /// </summary>
        public double? Duration
        {
            get;
            set;
        }

        /// <summary>
        /// Easing function to use.
        /// </summary>
        public string Easing
        {
            get;
            set;
        }

        /// <summary>
        /// Callback called on each step of an animation. Passed a single argument, an object, containing the chart instance and an object with details of the animation.
        /// </summary>
        public string OnProgress
        {
            get;
            set;
        }

        /// <summary>
        /// Callback called at the end of an animation. Passed the same arguments as onProgress.
        /// </summary>
        public string OnComplete
        {
            get;
            set;
        }
    }
}
