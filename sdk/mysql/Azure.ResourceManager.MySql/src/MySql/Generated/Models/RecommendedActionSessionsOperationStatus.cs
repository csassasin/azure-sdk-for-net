// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Recommendation action session operation status. </summary>
    public partial class RecommendedActionSessionsOperationStatus
    {
        /// <summary> Initializes a new instance of RecommendedActionSessionsOperationStatus. </summary>
        internal RecommendedActionSessionsOperationStatus()
        {
        }

        /// <summary> Initializes a new instance of RecommendedActionSessionsOperationStatus. </summary>
        /// <param name="name"> Operation identifier. </param>
        /// <param name="startOn"> Operation start time. </param>
        /// <param name="status"> Operation status. </param>
        internal RecommendedActionSessionsOperationStatus(string name, DateTimeOffset? startOn, string status)
        {
            Name = name;
            StartOn = startOn;
            Status = status;
        }

        /// <summary> Operation identifier. </summary>
        public string Name { get; }
        /// <summary> Operation start time. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Operation status. </summary>
        public string Status { get; }
    }
}
