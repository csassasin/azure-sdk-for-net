// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The result of a request to check the availability of a container registry name. </summary>
    public partial class RegistryNameStatus
    {
        /// <summary> Initializes a new instance of RegistryNameStatus. </summary>
        internal RegistryNameStatus()
        {
        }

        /// <summary> Initializes a new instance of RegistryNameStatus. </summary>
        /// <param name="nameAvailable"> The value that indicates whether the name is available. </param>
        /// <param name="reason"> If any, the reason that the name is not available. </param>
        /// <param name="message"> If any, the error message that provides more detail for the reason that the name is not available. </param>
        internal RegistryNameStatus(bool? nameAvailable, string reason, string message)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> The value that indicates whether the name is available. </summary>
        public bool? NameAvailable { get; }
        /// <summary> If any, the reason that the name is not available. </summary>
        public string Reason { get; }
        /// <summary> If any, the error message that provides more detail for the reason that the name is not available. </summary>
        public string Message { get; }
    }
}
