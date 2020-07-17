using System;
using System.Globalization;

namespace AnyJob.Packages.Core
{
    public class FormatAction : IAction
    {
        public string Format { get; set; }
        public object[] Arguments { get; set; }

        public object Run(IActionContext context)
        {
            if (string.IsNullOrEmpty(Format)) return string.Empty;

            return string.Format(CultureInfo.InvariantCulture, this.Format, this.Arguments ?? Array.Empty<object>());
        }
    }
}
