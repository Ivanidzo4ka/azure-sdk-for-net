// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AzureNetAppFilesManagementClient.
    /// </summary>
    public static partial class AzureNetAppFilesManagementClientExtensions
    {
            /// <summary>
            /// Check resource name availability
            /// </summary>
            /// <remarks>
            /// Check if a resource name is available.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location
            /// </param>
            public static ResourceNameAvailability CheckNameAvailability(this IAzureNetAppFilesManagementClient operations, string location)
            {
                return operations.CheckNameAvailabilityAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check resource name availability
            /// </summary>
            /// <remarks>
            /// Check if a resource name is available.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceNameAvailability> CheckNameAvailabilityAsync(this IAzureNetAppFilesManagementClient operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckNameAvailabilityWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Check file path availability
            /// </summary>
            /// <remarks>
            /// Check if a file path is available.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location
            /// </param>
            public static ResourceNameAvailability CheckFilePathAvailability(this IAzureNetAppFilesManagementClient operations, string location)
            {
                return operations.CheckFilePathAvailabilityAsync(location).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Check file path availability
            /// </summary>
            /// <remarks>
            /// Check if a file path is available.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='location'>
            /// The location
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ResourceNameAvailability> CheckFilePathAvailabilityAsync(this IAzureNetAppFilesManagementClient operations, string location, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckFilePathAvailabilityWithHttpMessagesAsync(location, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}