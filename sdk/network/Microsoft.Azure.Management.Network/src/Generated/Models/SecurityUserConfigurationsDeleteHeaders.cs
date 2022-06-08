// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for Delete operation.
    /// </summary>
    public partial class SecurityUserConfigurationsDeleteHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// SecurityUserConfigurationsDeleteHeaders class.
        /// </summary>
        public SecurityUserConfigurationsDeleteHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// SecurityUserConfigurationsDeleteHeaders class.
        /// </summary>
        /// <param name="location">The URL of the resource used to check the
        /// status of the asynchronous operation.</param>
        public SecurityUserConfigurationsDeleteHeaders(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of the resource used to check the status of
        /// the asynchronous operation.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
