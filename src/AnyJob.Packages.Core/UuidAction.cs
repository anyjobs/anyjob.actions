

namespace AnyJob.Packages.Core
{
    public class UuidAction : IAction
    {
        public GuidFormat Format { get; set; } = GuidFormat.D;

        public bool ToUpper { get; set; }
        public object Run(IActionContext context)
        {
            var text = System.Guid.NewGuid().ToString(this.Format.ToString());
            return ToUpper ? text.ToUpperInvariant() : text;
        }
    }
    public enum GuidFormat
    {
        N,
        D,
        B,
        P
    }
}
