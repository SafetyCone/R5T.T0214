using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0214.N001
{
    /// <inheritdoc cref="IFrameworkedVersionedDotnetPackDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class FrameworkedVersionedDotnetPackDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IFrameworkedVersionedDotnetPackDirectoryPath
    {
        public FrameworkedVersionedDotnetPackDirectoryPath(string value)
            : base(value)
        {
        }
    }
}