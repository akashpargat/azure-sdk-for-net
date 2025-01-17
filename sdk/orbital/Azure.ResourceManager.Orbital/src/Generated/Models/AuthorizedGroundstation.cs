// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Authorized groundstation. </summary>
    public partial class AuthorizedGroundstation
    {
        /// <summary> Initializes a new instance of AuthorizedGroundstation. </summary>
        internal AuthorizedGroundstation()
        {
        }

        /// <summary> Initializes a new instance of AuthorizedGroundstation. </summary>
        /// <param name="groundStation"> Groundstation name. </param>
        /// <param name="expireOn"> Date of authorization expiration. </param>
        internal AuthorizedGroundstation(string groundStation, DateTimeOffset? expireOn)
        {
            GroundStation = groundStation;
            ExpireOn = expireOn;
        }

        /// <summary> Groundstation name. </summary>
        public string GroundStation { get; }
        /// <summary> Date of authorization expiration. </summary>
        public DateTimeOffset? ExpireOn { get; }
    }
}
