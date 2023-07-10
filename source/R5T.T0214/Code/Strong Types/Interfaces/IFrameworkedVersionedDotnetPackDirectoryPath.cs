using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0214.N001
{
    /// <summary>
    /// Strongly-types a string as versioned, frameworked, directory path of a dotnet pack.
    /// Example: C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.18\ref\net6.0\
    /// <para>
    /// NOTE: this type is the base type for <see cref="IDotnetPackDirectoryPath"/>, but better describes the path.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IFrameworkedVersionedDotnetPackDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}