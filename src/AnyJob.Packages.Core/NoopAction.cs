using System;

namespace AnyJob.Packages.Core
{
    public class NoopAction : IAction
    {
        public object Run(IActionContext context)
        {
            return null;
        }
    }
}
