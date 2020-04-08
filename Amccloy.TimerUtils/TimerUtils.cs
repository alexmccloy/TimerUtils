using System;
using System.Threading.Tasks;

namespace Amccloy.TimerUtils
{
    public static class TimerUtils
    {
        public static async Task DoAfter(Action action, int milliseconds)
        {
            await Task.Delay(milliseconds);
            action.Invoke();
        }
        
        //TODO add DoEvery
    }
}