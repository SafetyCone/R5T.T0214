using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0214.N001
{
    /// <summary>
    /// Strongly-types a string as a the path of the root directory for a .NET pack.
    /// Example: C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\
    /// <para>
    /// This is not the <see cref="IDotnetPackDirectoryPath"/> (even though it seems like it should be) since it does not contain all the useful DLL and accompanying documentation XML files.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IDotnetPackRootDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}