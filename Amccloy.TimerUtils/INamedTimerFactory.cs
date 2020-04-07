namespace Amccloy.TimerUtils
{
    /// <summary>
    /// Factory that produces timers with a name attached to them. The implementation can then use this name to
    /// retrieve the timers.
    /// This should be used when creating multiple timers in a single class that will be unit tested
    /// </summary>
    public interface INamedTimerFactory
    {
        /// <summary>
        /// Generates a new <see cref="ITimer"/> with the given name
        /// </summary>
        /// <param name="name">The name of the timer</param>
        /// <returns>A new instance of a timer</returns>
        ITimer GenerateTimer(string name);
    }
}