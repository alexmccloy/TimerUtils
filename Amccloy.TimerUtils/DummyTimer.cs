using System;

namespace Amccloy.TimerUtils
{
    /// <summary>
    /// Timer that does not actually run, but instead is triggered manually. Intended for use in unit test projects.
    /// </summary>
    public class DummyTimer : ITimer
    {
        public Action? Action { get; set; }
        
        public bool Repeats { get; set; }
        
        public bool IsStarted { get; set; }
        
        public void Start(TimeSpan duration)
        {
            if (Action == null)
            {
                throw new TimerException("Cannot start the timer while the Action is null");
            }
            
            IsStarted = true;
        }

        public void Start(int milliseconds)
        {
            Start(new TimeSpan());
        }

        public void Stop()
        {
            IsStarted = false;
        }

        public void TriggerTimer()
        {
            if (!IsStarted)
            {
                throw new TimerException("The timer must be started before it is triggered");
            }

            IsStarted = false;
            Action.Invoke();
            IsStarted = Repeats;
        }
    }
}