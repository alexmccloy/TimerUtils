using System;
using System.Threading;
using System.Threading.Tasks;

namespace Amccloy.TimerUtils
{
    public static class TimerUtils
    {
        public static async Task DoAfter(Action action, int milliseconds, CancellationToken cancellationToken)
        {
            await Task.Delay(milliseconds, cancellationToken);
            
            if (!cancellationToken.IsCancellationRequested) {
                action.Invoke();
            }
        }
        
        //TODO add DoEvery
    }
}