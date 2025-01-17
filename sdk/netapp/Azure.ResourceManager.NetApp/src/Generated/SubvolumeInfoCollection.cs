// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.NetApp
{
    /// <summary>
    /// A class representing a collection of <see cref="SubvolumeInfoResource" /> and their operations.
    /// Each <see cref="SubvolumeInfoResource" /> in the collection will belong to the same instance of <see cref="VolumeResource" />.
    /// To get a <see cref="SubvolumeInfoCollection" /> instance call the GetSubvolumeInfos method from an instance of <see cref="VolumeResource" />.
    /// </summary>
    public partial class SubvolumeInfoCollection : ArmCollection, IEnumerable<SubvolumeInfoResource>, IAsyncEnumerable<SubvolumeInfoResource>
    {
        private readonly ClientDiagnostics _subvolumeInfoSubvolumesClientDiagnostics;
        private readonly SubvolumesRestOperations _subvolumeInfoSubvolumesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubvolumeInfoCollection"/> class for mocking. </summary>
        protected SubvolumeInfoCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubvolumeInfoCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SubvolumeInfoCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _subvolumeInfoSubvolumesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetApp", SubvolumeInfoResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SubvolumeInfoResource.ResourceType, out string subvolumeInfoSubvolumesApiVersion);
            _subvolumeInfoSubvolumesRestClient = new SubvolumesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, subvolumeInfoSubvolumesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VolumeResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VolumeResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a subvolume in the path or clones the subvolume mentioned in the parentPath
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}
        /// Operation Id: Subvolumes_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="info"> Subvolume object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> or <paramref name="info"/> is null. </exception>
        public virtual async Task<ArmOperation<SubvolumeInfoResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string subvolumeName, SubvolumeInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _subvolumeInfoSubvolumesClientDiagnostics.CreateScope("SubvolumeInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subvolumeInfoSubvolumesRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, info, cancellationToken).ConfigureAwait(false);
                var operation = new NetAppArmOperation<SubvolumeInfoResource>(new SubvolumeInfoOperationSource(Client), _subvolumeInfoSubvolumesClientDiagnostics, Pipeline, _subvolumeInfoSubvolumesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, info).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates a subvolume in the path or clones the subvolume mentioned in the parentPath
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}
        /// Operation Id: Subvolumes_Create
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="info"> Subvolume object supplied in the body of the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> or <paramref name="info"/> is null. </exception>
        public virtual ArmOperation<SubvolumeInfoResource> CreateOrUpdate(WaitUntil waitUntil, string subvolumeName, SubvolumeInfoData info, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));
            Argument.AssertNotNull(info, nameof(info));

            using var scope = _subvolumeInfoSubvolumesClientDiagnostics.CreateScope("SubvolumeInfoCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subvolumeInfoSubvolumesRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, info, cancellationToken);
                var operation = new NetAppArmOperation<SubvolumeInfoResource>(new SubvolumeInfoOperationSource(Client), _subvolumeInfoSubvolumesClientDiagnostics, Pipeline, _subvolumeInfoSubvolumesRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, info).Request, response, OperationFinalStateVia.AzureAsyncOperation);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the path associated with the subvolumeName provided
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}
        /// Operation Id: Subvolumes_Get
        /// </summary>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> is null. </exception>
        public virtual async Task<Response<SubvolumeInfoResource>> GetAsync(string subvolumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));

            using var scope = _subvolumeInfoSubvolumesClientDiagnostics.CreateScope("SubvolumeInfoCollection.Get");
            scope.Start();
            try
            {
                var response = await _subvolumeInfoSubvolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubvolumeInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns the path associated with the subvolumeName provided
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}
        /// Operation Id: Subvolumes_Get
        /// </summary>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> is null. </exception>
        public virtual Response<SubvolumeInfoResource> Get(string subvolumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));

            using var scope = _subvolumeInfoSubvolumesClientDiagnostics.CreateScope("SubvolumeInfoCollection.Get");
            scope.Start();
            try
            {
                var response = _subvolumeInfoSubvolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SubvolumeInfoResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns a list of the subvolumes in the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes
        /// Operation Id: Subvolumes_ListByVolume
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SubvolumeInfoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SubvolumeInfoResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SubvolumeInfoResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subvolumeInfoSubvolumesClientDiagnostics.CreateScope("SubvolumeInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subvolumeInfoSubvolumesRestClient.ListByVolumeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubvolumeInfoResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SubvolumeInfoResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subvolumeInfoSubvolumesClientDiagnostics.CreateScope("SubvolumeInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subvolumeInfoSubvolumesRestClient.ListByVolumeNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SubvolumeInfoResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Returns a list of the subvolumes in the volume
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes
        /// Operation Id: Subvolumes_ListByVolume
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SubvolumeInfoResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SubvolumeInfoResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SubvolumeInfoResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _subvolumeInfoSubvolumesClientDiagnostics.CreateScope("SubvolumeInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subvolumeInfoSubvolumesRestClient.ListByVolume(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubvolumeInfoResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SubvolumeInfoResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _subvolumeInfoSubvolumesClientDiagnostics.CreateScope("SubvolumeInfoCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subvolumeInfoSubvolumesRestClient.ListByVolumeNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SubvolumeInfoResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}
        /// Operation Id: Subvolumes_Get
        /// </summary>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string subvolumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));

            using var scope = _subvolumeInfoSubvolumesClientDiagnostics.CreateScope("SubvolumeInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = await _subvolumeInfoSubvolumesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.NetApp/netAppAccounts/{accountName}/capacityPools/{poolName}/volumes/{volumeName}/subvolumes/{subvolumeName}
        /// Operation Id: Subvolumes_Get
        /// </summary>
        /// <param name="subvolumeName"> The name of the subvolume. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="subvolumeName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="subvolumeName"/> is null. </exception>
        public virtual Response<bool> Exists(string subvolumeName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subvolumeName, nameof(subvolumeName));

            using var scope = _subvolumeInfoSubvolumesClientDiagnostics.CreateScope("SubvolumeInfoCollection.Exists");
            scope.Start();
            try
            {
                var response = _subvolumeInfoSubvolumesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, subvolumeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SubvolumeInfoResource> IEnumerable<SubvolumeInfoResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SubvolumeInfoResource> IAsyncEnumerable<SubvolumeInfoResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
