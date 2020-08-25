using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Components.Web.Extensions
{
    /// <summary>
    /// Contains the result of a protected browser storage operation.
    /// </summary>
    public readonly struct ProtectedBrowserStorageResult<TValue>
    {
        /// <summary>
        /// Gets whether the operation succeeded.
        /// </summary>
        public bool Success { get; }

        /// <summary>
        /// Gets the result value of the operation.
        /// </summary>
        public TValue? Value { get; }

        internal ProtectedBrowserStorageResult(bool success, TValue? value)
        {
            Success = success;
            Value = value;
        }
    }
}
