using System;


namespace R5T.T0214.Z001
{
    public class DotnetPacksDirectoryPaths : IDotnetPacksDirectoryPaths
    {
        #region Infrastructure

        public static IDotnetPacksDirectoryPaths Instance { get; } = new DotnetPacksDirectoryPaths();


        private DotnetPacksDirectoryPaths()
        {
        }

        #endregion
    }
}
