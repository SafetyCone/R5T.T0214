using System;

using R5T.T0132;


namespace R5T.T0214.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="N001.IDotnetPackDirectoryName"/>
        public N001.IDotnetPackDirectoryName ToDotnetPackDirectoryName(string value)
        {
            var output = new N001.DotnetPackDirectoryName(value);
            return output;
        }

        /// <inheritdoc cref="IDotnetPackDirectoryPath"/>
        public IDotnetPackDirectoryPath ToDotnetPackDirectoryPath(string value)
        {
            var output = new DotnetPackDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="N001.IDotnetPackReferenceDirectoryPath"/>
        public N001.IDotnetPackReferenceDirectoryPath ToDotnetPackReferenceDirectoryPath(string value)
        {
            var output = new N001.DotnetPackReferenceDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="N001.IDotnetPackRootDirectoryPath"/>
        public N001.IDotnetPackRootDirectoryPath ToDotnetPackRootDirectoryPath(string value)
        {
            var output = new N001.DotnetPackRootDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="N001.IDotnetPacksDirectoryPath"/>
        public N001.IDotnetPacksDirectoryPath ToDotnetPacksDirectoryPath(string value)
        {
            var output = new N001.DotnetPacksDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="N001.IFrameworkedVersionedDotnetPackDirectoryPath"/>
        public N001.IFrameworkedVersionedDotnetPackDirectoryPath ToFrameworkedVersionedDotnetPackDirectoryPath(string value)
        {
            var output = new N001.FrameworkedVersionedDotnetPackDirectoryPath(value);
            return output;
        }

        /// <inheritdoc cref="N001.IVersionedDotnetPackDirectoryPath"/>
        public N001.IVersionedDotnetPackDirectoryPath ToVersionedDotnetPackDirectoryPath(string value)
        {
            var output = new N001.VersionedDotnetPackDirectoryPath(value);
            return output;
        }
    }
}
