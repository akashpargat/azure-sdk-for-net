// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the Addon data model.
    /// Please note <see cref="AddonData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ArcAddon"/> and <see cref="IoTAddon"/>.
    /// </summary>
    public partial class AddonData : ResourceData
    {
        /// <summary> Initializes a new instance of AddonData. </summary>
        public AddonData()
        {
        }

        /// <summary> Initializes a new instance of AddonData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Addon type. </param>
        internal AddonData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AddonType kind) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
        }

        /// <summary> Addon type. </summary>
        internal AddonType Kind { get; set; }
    }
}
