using System;

using R5T.T0131;

using R5T.T0214.N001.Extensions;


namespace R5T.T0214.Z001
{
    [ValuesMarker]
    public partial interface IDotnetPacksDirectoryPaths : IValuesMarker
    {
        /// <summary>
        /// <para>"C:\Program Files\dotnet\packs\"</para>
        /// The Windows default location for .NET core library packs containg DLLs and accompanying XML documentation files.
        /// </summary>
        public N001.IDotnetPacksDirectoryPath Windows => @"C:\Program Files\dotnet\packs\".ToDotnetPacksDirectoryPath();
    }
}
