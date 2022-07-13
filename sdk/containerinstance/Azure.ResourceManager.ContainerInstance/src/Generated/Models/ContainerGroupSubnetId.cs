// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> Container group subnet information. </summary>
    public partial class ContainerGroupSubnetId
    {
        /// <summary> Initializes a new instance of ContainerGroupSubnetId. </summary>
        /// <param name="id"> Resource ID of virtual network and subnet. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public ContainerGroupSubnetId(ResourceIdentifier id)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            Id = id;
        }

        /// <summary> Initializes a new instance of ContainerGroupSubnetId. </summary>
        /// <param name="id"> Resource ID of virtual network and subnet. </param>
        /// <param name="name"> Friendly name for the subnet. </param>
        internal ContainerGroupSubnetId(ResourceIdentifier id, string name)
        {
            Id = id;
            Name = name;
        }

        /// <summary> Resource ID of virtual network and subnet. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Friendly name for the subnet. </summary>
        public string Name { get; set; }
    }
}
