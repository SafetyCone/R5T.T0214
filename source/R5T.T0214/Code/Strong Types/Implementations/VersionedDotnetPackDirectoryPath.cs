using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0214.N001
{
    /// <inheritdoc cref="IVersionedDotnetPackDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class VersionedDotnetPackDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IVersionedDotnetPackDirectoryPath
    {
        public VersionedDotnetPackDirectoryPath(string value)
            : base(value)
        {
        }
    }
}