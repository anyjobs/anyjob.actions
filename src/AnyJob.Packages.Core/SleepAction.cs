using System.Threading.Tasks;

namespace AnyJob.Packages.Core
{
    public class SleepAction : IAction
    {
        public int TimeOut { get; set; }
        public object Run(IActionContext context)
        {
            if (TimeOut > 0)
            {
                Task.Delay(TimeOut * 1000).Wait();
            }
            return null;
        }
    }
}
