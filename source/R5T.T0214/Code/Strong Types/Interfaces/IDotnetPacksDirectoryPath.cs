using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0214.N001
{
    /// <summary>
    /// Strongly-types a string as the path of a directory containing all the dotnet packs.
    /// Example: C:\Program Files\dotnet\packs\.
    /// <para>
    /// NOTE: this is <b>not</b> the <see cref="IDotnetPackRootDirectoryPath"/> that contains all the <see cref="IVersionedDotnetPackDirectoryPath"/>s.
    /// But instead the directory that contains all the <see cref="IDotnetPackRootDirectoryPath"/> themselves.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IDotnetPacksDirectoryPath : IStrongTypeMarker,
        IDirectoryPath
    {
    }
}