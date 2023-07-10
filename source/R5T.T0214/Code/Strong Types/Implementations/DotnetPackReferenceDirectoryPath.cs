using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0214.N001
{
    /// <inheritdoc cref="IDotnetPackReferenceDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class DotnetPackReferenceDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IDotnetPackReferenceDirectoryPath
    {
        public DotnetPackReferenceDirectoryPath(string value)
            : base(value)
        {
        }
    }
}