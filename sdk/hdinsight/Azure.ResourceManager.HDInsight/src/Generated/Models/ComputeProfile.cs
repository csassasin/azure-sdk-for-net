// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Describes the compute profile. </summary>
    internal partial class ComputeProfile
    {
        /// <summary> Initializes a new instance of ComputeProfile. </summary>
        public ComputeProfile()
        {
            Roles = new ChangeTrackingList<Role>();
        }

        /// <summary> Initializes a new instance of ComputeProfile. </summary>
        /// <param name="roles"> The list of roles in the cluster. </param>
        internal ComputeProfile(IList<Role> roles)
        {
            Roles = roles;
        }

        /// <summary> The list of roles in the cluster. </summary>
        public IList<Role> Roles { get; }
    }
}
