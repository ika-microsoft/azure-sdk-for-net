// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Fluent.Redis
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for PatchSchedulesOperations.
    /// </summary>
    public static partial class PatchSchedulesOperationsExtensions
    {
            /// <summary>
            /// Create or replace the patching schedule for redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to set patch schedules for redis cache.
            /// </param>
            public static RedisPatchScheduleInner CreateOrUpdate(this IPatchSchedulesOperations operations, string resourceGroupName, string name, RedisPatchScheduleInner parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPatchSchedulesOperations)s).CreateOrUpdateAsync(resourceGroupName, name, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace the patching schedule for redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='parameters'>
            /// Parameters to set patch schedules for redis cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<RedisPatchScheduleInner> CreateOrUpdateAsync(this IPatchSchedulesOperations operations, string resourceGroupName, string name, RedisPatchScheduleInner parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, name, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the patching schedule for redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            public static void Delete(this IPatchSchedulesOperations operations, string resourceGroupName, string name)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((IPatchSchedulesOperations)s).DeleteAsync(resourceGroupName, name), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the patching schedule for redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IPatchSchedulesOperations operations, string resourceGroupName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets the patching schedule for redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            public static RedisPatchScheduleInner Get(this IPatchSchedulesOperations operations, string resourceGroupName, string name)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((IPatchSchedulesOperations)s).GetAsync(resourceGroupName, name), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the patching schedule for redis cache.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='name'>
            /// The name of the redis cache.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<RedisPatchScheduleInner> GetAsync(this IPatchSchedulesOperations operations, string resourceGroupName, string name, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
