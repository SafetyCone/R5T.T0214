using System;

using R5T.T0178;


namespace R5T.T0214
{
    /// <summary>
    /// Strongly-types a string as the path of a dotnet pack directory.
    /// Example: <inheritdoc cref="Documentation.Example_DotnetPackDirectoryPath" path="/summary"/>.
    /// <para>
    /// This directory contains all the .NET core DLL files and their accompanying documention XML files.
    /// </para>
    /// </summary>
    [StrongTypeMarker]
    public interface IDotnetPackDirectoryPath : IStrongTypeMarker,
        N001.IFrameworkedVersionedDotnetPackDirectoryPath
    {
    }
}