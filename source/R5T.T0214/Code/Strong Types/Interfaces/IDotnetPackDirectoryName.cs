using System;

using R5T.T0178;
using R5T.T0180;


namespace R5T.T0214.N001
{
    /// <summary>
    /// Strongly-types a string as the name of a dotnet/packs/ pack directory name.
    /// (On Windows: C:\Program Files\dotnet\packs\)
    /// Example: Microsoft.NETCore.App.Ref
    /// <para>
    /// NOTE: this is <b>not</b> the directory name of a <see cref="IDotnetPackDirectoryPath"/>!
    /// (Example: C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.18\ref\net6.0\)
    /// That directory name is meaningless (it's a target framework name).
    /// This directory name is the meaningful "Microsoft.NETCore.App.Ref" directory name, which corresponds to a <see cref="IDotnetPackRootDirectoryPath"/>.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IDotnetPackDirectoryName : IStrongTypeMarker,
        IDirectoryName
    {
    }
}