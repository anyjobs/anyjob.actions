

namespace AnyJob.Packages.Core
{
    public class GuidAction : IAction
    {
        public string Format { get; set; }

        public object Run(IActionContext context)
        {
            return System.Guid.NewGuid().ToString(this.Format);
        }
    }
}
