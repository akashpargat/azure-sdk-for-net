// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Kusto.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Kusto
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Kusto. </summary>
    public static partial class KustoExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Lists all Kusto clusters within a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Kusto/clusters
        /// Operation Id: Clusters_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ClusterResource> GetClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetClustersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists all Kusto clusters within a subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Kusto/clusters
        /// Operation Id: Clusters_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ClusterResource> GetClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetClusters(cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Kusto resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Kusto/skus
        /// Operation Id: Clusters_ListSkus
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SkuDescription" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<SkuDescription> GetSkusClustersAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkusClustersAsync(cancellationToken);
        }

        /// <summary>
        /// Lists eligible SKUs for Kusto resource provider.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Kusto/skus
        /// Operation Id: Clusters_ListSkus
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SkuDescription" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<SkuDescription> GetSkusClusters(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetSkusClusters(cancellationToken);
        }

        /// <summary>
        /// Checks that the cluster name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/checkNameAvailability
        /// Operation Id: Clusters_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> Azure location (region) name. </param>
        /// <param name="content"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<CheckNameResult>> CheckNameAvailabilityClusterAsync(this SubscriptionResource subscriptionResource, AzureLocation location, ClusterCheckNameContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).CheckNameAvailabilityClusterAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Checks that the cluster name is valid and is not already in use.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/checkNameAvailability
        /// Operation Id: Clusters_CheckNameAvailability
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> Azure location (region) name. </param>
        /// <param name="content"> The name of the cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<CheckNameResult> CheckNameAvailabilityCluster(this SubscriptionResource subscriptionResource, AzureLocation location, ClusterCheckNameContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).CheckNameAvailabilityCluster(location, content, cancellationToken);
        }

        /// <summary>
        /// Returns operation results.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/operationResults/{operationId}
        /// Operation Id: OperationsResults_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> Azure location (region) name. </param>
        /// <param name="operationId"> The Guid of the operation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static async Task<Response<OperationResult>> GetOperationsResultAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return await GetExtensionClient(subscriptionResource).GetOperationsResultAsync(location, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns operation results.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/operationResults/{operationId}
        /// Operation Id: OperationsResults_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> Azure location (region) name. </param>
        /// <param name="operationId"> The Guid of the operation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static Response<OperationResult> GetOperationsResult(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetOperationsResult(location, operationId, cancellationToken);
        }

        /// <summary>
        /// Returns operation results.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/operationResults/{operationId}
        /// Operation Id: OperationsResultsLocation_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> Azure location (region) name. </param>
        /// <param name="operationId"> The Guid of the operation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static async Task<Response> GetOperationsResultsLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return await GetExtensionClient(subscriptionResource).GetOperationsResultsLocationAsync(location, operationId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Returns operation results.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.Kusto/locations/{location}/operationResults/{operationId}
        /// Operation Id: OperationsResultsLocation_Get
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> Azure location (region) name. </param>
        /// <param name="operationId"> The Guid of the operation ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="operationId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="operationId"/> is null. </exception>
        public static Response GetOperationsResultsLocation(this SubscriptionResource subscriptionResource, AzureLocation location, string operationId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(operationId, nameof(operationId));

            return GetExtensionClient(subscriptionResource).GetOperationsResultsLocation(location, operationId, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of ClusterResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of ClusterResources and their operations over a ClusterResource. </returns>
        public static ClusterCollection GetClusters(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetClusters();
        }

        /// <summary>
        /// Gets a Kusto cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Kusto cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<ClusterResource>> GetClusterAsync(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetClusters().GetAsync(clusterName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a Kusto cluster.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Kusto/clusters/{clusterName}
        /// Operation Id: Clusters_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterName"> The name of the Kusto cluster. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<ClusterResource> GetCluster(this ResourceGroupResource resourceGroupResource, string clusterName, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetClusters().Get(clusterName, cancellationToken);
        }

        #region ClusterResource
        /// <summary>
        /// Gets an object representing a <see cref="ClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ClusterResource.CreateResourceIdentifier" /> to create a <see cref="ClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ClusterResource" /> object. </returns>
        public static ClusterResource GetClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ClusterResource.ValidateResourceId(id);
                return new ClusterResource(client, id);
            }
            );
        }
        #endregion

        #region ClusterPrincipalAssignmentResource
        /// <summary>
        /// Gets an object representing a <see cref="ClusterPrincipalAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ClusterPrincipalAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="ClusterPrincipalAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ClusterPrincipalAssignmentResource" /> object. </returns>
        public static ClusterPrincipalAssignmentResource GetClusterPrincipalAssignmentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ClusterPrincipalAssignmentResource.ValidateResourceId(id);
                return new ClusterPrincipalAssignmentResource(client, id);
            }
            );
        }
        #endregion

        #region DatabaseResource
        /// <summary>
        /// Gets an object representing a <see cref="DatabaseResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DatabaseResource.CreateResourceIdentifier" /> to create a <see cref="DatabaseResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DatabaseResource" /> object. </returns>
        public static DatabaseResource GetDatabaseResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DatabaseResource.ValidateResourceId(id);
                return new DatabaseResource(client, id);
            }
            );
        }
        #endregion

        #region AttachedDatabaseConfigurationResource
        /// <summary>
        /// Gets an object representing an <see cref="AttachedDatabaseConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AttachedDatabaseConfigurationResource.CreateResourceIdentifier" /> to create an <see cref="AttachedDatabaseConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AttachedDatabaseConfigurationResource" /> object. </returns>
        public static AttachedDatabaseConfigurationResource GetAttachedDatabaseConfigurationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AttachedDatabaseConfigurationResource.ValidateResourceId(id);
                return new AttachedDatabaseConfigurationResource(client, id);
            }
            );
        }
        #endregion

        #region ManagedPrivateEndpointResource
        /// <summary>
        /// Gets an object representing a <see cref="ManagedPrivateEndpointResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ManagedPrivateEndpointResource.CreateResourceIdentifier" /> to create a <see cref="ManagedPrivateEndpointResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ManagedPrivateEndpointResource" /> object. </returns>
        public static ManagedPrivateEndpointResource GetManagedPrivateEndpointResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ManagedPrivateEndpointResource.ValidateResourceId(id);
                return new ManagedPrivateEndpointResource(client, id);
            }
            );
        }
        #endregion

        #region DatabasePrincipalAssignmentResource
        /// <summary>
        /// Gets an object representing a <see cref="DatabasePrincipalAssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DatabasePrincipalAssignmentResource.CreateResourceIdentifier" /> to create a <see cref="DatabasePrincipalAssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DatabasePrincipalAssignmentResource" /> object. </returns>
        public static DatabasePrincipalAssignmentResource GetDatabasePrincipalAssignmentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DatabasePrincipalAssignmentResource.ValidateResourceId(id);
                return new DatabasePrincipalAssignmentResource(client, id);
            }
            );
        }
        #endregion

        #region ScriptResource
        /// <summary>
        /// Gets an object representing a <see cref="ScriptResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ScriptResource.CreateResourceIdentifier" /> to create a <see cref="ScriptResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ScriptResource" /> object. </returns>
        public static ScriptResource GetScriptResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                ScriptResource.ValidateResourceId(id);
                return new ScriptResource(client, id);
            }
            );
        }
        #endregion

        #region KustoPrivateEndpointConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create a <see cref="KustoPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoPrivateEndpointConnectionResource" /> object. </returns>
        public static KustoPrivateEndpointConnectionResource GetKustoPrivateEndpointConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                KustoPrivateEndpointConnectionResource.ValidateResourceId(id);
                return new KustoPrivateEndpointConnectionResource(client, id);
            }
            );
        }
        #endregion

        #region KustoPrivateLinkResource
        /// <summary>
        /// Gets an object representing a <see cref="KustoPrivateLinkResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="KustoPrivateLinkResource.CreateResourceIdentifier" /> to create a <see cref="KustoPrivateLinkResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="KustoPrivateLinkResource" /> object. </returns>
        public static KustoPrivateLinkResource GetKustoPrivateLinkResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                KustoPrivateLinkResource.ValidateResourceId(id);
                return new KustoPrivateLinkResource(client, id);
            }
            );
        }
        #endregion

        #region DataConnectionResource
        /// <summary>
        /// Gets an object representing a <see cref="DataConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataConnectionResource.CreateResourceIdentifier" /> to create a <see cref="DataConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataConnectionResource" /> object. </returns>
        public static DataConnectionResource GetDataConnectionResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataConnectionResource.ValidateResourceId(id);
                return new DataConnectionResource(client, id);
            }
            );
        }
        #endregion
    }
}
