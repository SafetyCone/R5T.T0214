using System;


namespace R5T.T0214.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToDotnetPackDirectoryPath(string)"/>
        public static IDotnetPackDirectoryPath ToDotnetPackDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDotnetPackDirectoryPath(value);
        }
    }
}


namespace R5T.T0214.N001.Extensions
{
    /// <summary>
    /// Extensions to N001 types are put in a separate extensions namespace to avoid 
    /// </summary>
    public static class StringExtensions
    {
        /// <inheritdoc cref="T0214.Extensions.IStringOperator.ToDotnetPackDirectoryName(string)"/>
        public static IDotnetPackDirectoryName ToDotnetPackDirectoryName(this string value)
        {
            return Instances.StringOperator_Extensions.ToDotnetPackDirectoryName(value);
        }

        /// <inheritdoc cref="T0214.Extensions.IStringOperator.ToDotnetPackReferenceDirectoryPath(string)"/>
        public static IDotnetPackReferenceDirectoryPath ToDotnetPackReferenceDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDotnetPackReferenceDirectoryPath(value);
        }

        /// <inheritdoc cref="T0214.Extensions.IStringOperator.ToDotnetPackRootDirectoryPath(string)"/>
        public static IDotnetPackRootDirectoryPath ToDotnetPackRootDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDotnetPackRootDirectoryPath(value);
        }

        /// <inheritdoc cref="T0214.Extensions.IStringOperator.ToDotnetPackRootDirectoryPath(string)"/>
        public static IDotnetPacksDirectoryPath ToDotnetPacksDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToDotnetPacksDirectoryPath(value);
        }

        /// <inheritdoc cref="T0214.Extensions.IStringOperator.ToFrameworkedVersionedDotnetPackDirectoryPath(string)"/>
        public static IFrameworkedVersionedDotnetPackDirectoryPath ToFrameworkedVersionedDotnetPackDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToFrameworkedVersionedDotnetPackDirectoryPath(value);
        }

        /// <inheritdoc cref="T0214.Extensions.IStringOperator.ToVersionedDotnetPackDirectoryPath(string)"/>
        public static IVersionedDotnetPackDirectoryPath ToVersionedDotnetPackDirectoryPath(this string value)
        {
            return Instances.StringOperator_Extensions.ToVersionedDotnetPackDirectoryPath(value);
        }
    }
}
