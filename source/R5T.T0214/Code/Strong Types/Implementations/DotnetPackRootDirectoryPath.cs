using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0214.N001
{
    /// <inheritdoc cref="IDotnetPackRootDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class DotnetPackRootDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IDotnetPackRootDirectoryPath
    {
        public DotnetPackRootDirectoryPath(string value)
            : base(value)
        {
        }
    }
}