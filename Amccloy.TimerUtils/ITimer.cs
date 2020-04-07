using System;

namespace Amccloy.TimerUtils
{
    /// <summary>
    /// An interface for a timer that can be started, stopped, and performs an action when the timer expires.
    /// </summary>
    public interface ITimer
    {
        /// <summary>
        /// The action that will occur when the timer expires
        /// </summary>
        Action Action { get; set; }
        
        /// <summary>
        /// If true, then the timer will automatically restart when it expires
        /// </summary>
        bool Repeats { get; set; }

        /// <summary>
        /// Starts the timer so that it expires after the given timespan
        /// </summary>
        /// <param name="duration">How long the timer should run for</param>
        void Start(TimeSpan duration);

        /// <summary>
        /// Starts the timer so that it expires after the given number of milliseconds
        /// </summary>
        /// <param name="milliseconds">How many milliseconds before the timer should expire</param>
        void Start(int milliseconds);

        /// <summary>
        /// Stops the timer. The <see cref="Action"/> will not occur
        /// </summary>
        void Stop();
    }
}