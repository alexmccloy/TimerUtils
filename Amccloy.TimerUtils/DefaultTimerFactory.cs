namespace Amccloy.TimerUtils
{
    public class DefaultTimerFactory : ITimerFactory
    {
        public ITimer GenerateTimer() => new DefaultTimer();
    }
}