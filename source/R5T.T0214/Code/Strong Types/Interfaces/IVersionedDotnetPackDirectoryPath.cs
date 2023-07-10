using System;

using R5T.T0178;
using R5T.T0216;


namespace R5T.T0214.N001
{
    /// <summary>
    /// Strongly-types a string as the path of the versioned directory for a dotnet pack.
    /// Example: C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.18\
    /// </summary>
    [StrongTypeMarker]
    public interface IVersionedDotnetPackDirectoryPath : IStrongTypeMarker,
        IVersionedDirectoryPath
    {
    }
}