using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0214
{
    /// <inheritdoc cref="IDotnetPackDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class DotnetPackDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IDotnetPackDirectoryPath
    {
        public DotnetPackDirectoryPath(string value)
            : base(value)
        {
        }
    }
}