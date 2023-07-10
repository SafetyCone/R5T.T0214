using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0214.N001
{
    /// <inheritdoc cref="IDotnetPacksDirectoryPath"/>
    [StrongTypeImplementationMarker]
    public class DotnetPacksDirectoryPath : TypedBase<string>, IStrongTypeMarker,
        IDotnetPacksDirectoryPath
    {
        public DotnetPacksDirectoryPath(string value)
            : base(value)
        {
        }
    }
}