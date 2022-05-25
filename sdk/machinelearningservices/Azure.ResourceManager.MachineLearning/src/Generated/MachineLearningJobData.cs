// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.MachineLearning.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary> A class representing the MachineLearningJob data model. </summary>
    public partial class MachineLearningJobData : ResourceData
    {
        /// <summary> Initializes a new instance of MachineLearningJobData. </summary>
        /// <param name="properties"> [Required] Additional attributes of the entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public MachineLearningJobData(MachineLearningJobProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
        }

        /// <summary> Initializes a new instance of MachineLearningJobData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> [Required] Additional attributes of the entity. </param>
        internal MachineLearningJobData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, MachineLearningJobProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> [Required] Additional attributes of the entity. </summary>
        public MachineLearningJobProperties Properties { get; set; }
    }
}
