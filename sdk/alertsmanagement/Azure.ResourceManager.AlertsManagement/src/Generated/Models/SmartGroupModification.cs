// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> Alert Modification details. </summary>
    public partial class SmartGroupModification : ResourceData
    {
        /// <summary> Initializes a new instance of SmartGroupModification. </summary>
        public SmartGroupModification()
        {
            Modifications = new ChangeTrackingList<SmartGroupModificationItemData>();
        }

        /// <summary> Initializes a new instance of SmartGroupModification. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="smartGroupId"> Unique Id of the smartGroup for which the history is being retrieved. </param>
        /// <param name="modifications"> Modification details. </param>
        /// <param name="nextLink"> URL to fetch the next set of results. </param>
        internal SmartGroupModification(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string smartGroupId, IList<SmartGroupModificationItemData> modifications, string nextLink) : base(id, name, resourceType, systemData)
        {
            SmartGroupId = smartGroupId;
            Modifications = modifications;
            NextLink = nextLink;
        }

        /// <summary> Unique Id of the smartGroup for which the history is being retrieved. </summary>
        public string SmartGroupId { get; }
        /// <summary> Modification details. </summary>
        public IList<SmartGroupModificationItemData> Modifications { get; }
        /// <summary> URL to fetch the next set of results. </summary>
        public string NextLink { get; set; }
    }
}
