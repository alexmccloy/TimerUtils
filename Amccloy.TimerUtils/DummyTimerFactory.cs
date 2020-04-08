namespace Amccloy.TimerUtils
{
    public class DummyTimerFactory : ITimerFactory
    {
        public ITimer GenerateTimer() => new DummyTimer();
    }
}