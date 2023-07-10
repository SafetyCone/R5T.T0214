using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0214.N001
{
    /// <summary>
    /// Strongly-types a string as the path of the reference ("ref") directory in a version dotnet pack directory.
    /// Example: C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.18\ref\
    /// </summary>
    [StrongTypeMarker]
    public interface IDotnetPackReferenceDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}
