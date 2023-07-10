using System;


namespace R5T.T0214.Z001
{
    public class DotnetPackDirectoryNames : IDotnetPackDirectoryNames
    {
        #region Infrastructure

        public static IDotnetPackDirectoryNames Instance { get; } = new DotnetPackDirectoryNames();


        private DotnetPackDirectoryNames()
        {
        }

        #endregion
    }
}
