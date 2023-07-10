using System;

using R5T.T0131;
using R5T.T0180;
using R5T.T0180.Extensions;


namespace R5T.T0214.Z001
{
    /// <summary>
    /// Names of the directories in a .NET pack directory (example: C:\Program Files\dotnet\packs\Microsoft.NETCore.App.Ref\6.0.18\).
    /// </summary>
    [ValuesMarker]
    public partial interface IDotnetPackDirectoryNames : IValuesMarker
    {
        /// <summary>
        /// "analyzers"
        /// </summary>
        public IDirectoryName Analyzers => "analyzers".ToDirectoryName();

        /// <summary>
        /// "data"
        /// </summary>
        public IDirectoryName Data => "data".ToDirectoryName();

        /// <summary>
        /// "ref"
        /// </summary>
        public IDirectoryName Ref => "ref".ToDirectoryName();
    }
}
