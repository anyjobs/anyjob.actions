using System.Threading.Tasks;

namespace AnyJob.Packages.Core
{
    public class SleepAction : IAction
    {
        public int TimeOut { get; set; } = 10;
        public object Run(IActionContext context)
        {
            if (TimeOut > 0)
            {
                Task.Delay(System.Math.Min(TimeOut, 999) * 1000).Wait();
            }
            return null;
        }
    }
}
