using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0214.N001
{
    /// <inheritdoc cref="IDotnetPackDirectoryName"/>
    [StrongTypeImplementationMarker]
    public class DotnetPackDirectoryName : TypedBase<string>, IStrongTypeMarker,
        IDotnetPackDirectoryName
    {
        public DotnetPackDirectoryName(string value)
            : base(value)
        {
        }
    }
}