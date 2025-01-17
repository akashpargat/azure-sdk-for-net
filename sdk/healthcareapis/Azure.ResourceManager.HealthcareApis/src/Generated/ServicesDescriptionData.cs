// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HealthcareApis
{
    /// <summary> A class representing the ServicesDescription data model. </summary>
    public partial class ServicesDescriptionData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ServicesDescriptionData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="kind"> The kind of the service. </param>
        public ServicesDescriptionData(AzureLocation location, HealthcareApisKind kind) : base(location)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of ServicesDescriptionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="properties"> The common properties of a service. </param>
        /// <param name="kind"> The kind of the service. </param>
        /// <param name="etag"> An etag associated with the resource, used for optimistic concurrency when editing it. </param>
        /// <param name="identity"> Setting indicating whether the service has a managed identity associated with it. Current supported identity types: SystemAssigned, None. </param>
        internal ServicesDescriptionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ServicesProperties properties, HealthcareApisKind kind, ETag? etag, ManagedServiceIdentity identity) : base(id, name, resourceType, systemData, tags, location)
        {
            Properties = properties;
            Kind = kind;
            ETag = etag;
            Identity = identity;
        }

        /// <summary> The common properties of a service. </summary>
        public ServicesProperties Properties { get; set; }
        /// <summary> The kind of the service. </summary>
        public HealthcareApisKind Kind { get; set; }
        /// <summary> An etag associated with the resource, used for optimistic concurrency when editing it. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Setting indicating whether the service has a managed identity associated with it. Current supported identity types: SystemAssigned, None. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
