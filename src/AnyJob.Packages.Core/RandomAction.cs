using System;
using System.Collections.Generic;
using System.Text;

namespace AnyJob.Packages.Core
{
    public class RandomAction : IAction
    {
        public int Max { get; set; } = 1000000000;
        public int Min { get; set; } = 0;
        public object Run(IActionContext context)
        {
            return new Random().Next(Min, Max);
        }
    }
}
