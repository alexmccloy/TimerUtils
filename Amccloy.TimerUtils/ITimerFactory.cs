namespace Amccloy.TimerUtils
{
    /// <summary>
    /// Factory for producing <see cref="ITimer"/> objects
    /// </summary>
    public interface ITimerFactory
    {
        /// <summary>
        /// Generates a new instance of <see cref="ITimer"/>
        /// </summary>
        ITimer GenerateTimer();
    }
}