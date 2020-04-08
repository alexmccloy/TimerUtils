using System;
using System.Timers;

namespace Amccloy.TimerUtils
{
    /// <summary>
    /// Implementation of a timer that uses a System.Timer.Timer and just kinda does what you would expect tbh.
    /// </summary>
    public class DefaultTimer : ITimer, IDisposable
    {
        private Timer _timer;
        
        /// <inheritdoc cref="ITimer"/>
        public Action? Action { get; set; }
        
        /// <inheritdoc cref="ITimer"/>
        public bool Repeats { get; set; }

        private TimeSpan _duration;
        
        /// <inheritdoc cref="ITimer"/>
        public void Start(TimeSpan duration)
        {
            if (Action == null)
            {
                throw new TimerException("Cannot start the timer when the Action has not been set");
            }
            
            _duration = duration;
            
            _timer = new Timer();
            _timer.Interval = _duration.TotalMilliseconds;
            _timer.Elapsed += TimerElapsed;
        }
        
        /// <inheritdoc cref="ITimer"/>
        public void Start(int milliseconds)
        {
            Start(new TimeSpan(0,0, 0,0, milliseconds));
        }

        /// <inheritdoc cref="ITimer"/>
        public void Stop()
        {
            _timer.Stop();
        }

        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            //TODO implement locking strategy
            _timer?.Stop();
            Action?.Invoke();

            if (Repeats)
            {
                _timer?.Start();
            }
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}