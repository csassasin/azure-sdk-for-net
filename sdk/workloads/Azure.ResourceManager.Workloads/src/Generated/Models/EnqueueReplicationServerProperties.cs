// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the SAP ERS Server properties. </summary>
    public partial class EnqueueReplicationServerProperties
    {
        /// <summary> Initializes a new instance of EnqueueReplicationServerProperties. </summary>
        public EnqueueReplicationServerProperties()
        {
        }

        /// <summary> Initializes a new instance of EnqueueReplicationServerProperties. </summary>
        /// <param name="ersVersion"> Defines the type of Enqueue Replication Server. </param>
        /// <param name="instanceNo"> The ERS server instance id. </param>
        /// <param name="hostname"> The ERS server SAP host name. </param>
        /// <param name="kernelVersion"> The ERS server SAP kernel version. </param>
        /// <param name="kernelPatch"> The ERS server SAP kernel patch. </param>
        /// <param name="ipAddress"> The ERS server SAP IP Address. </param>
        /// <param name="health"> Defines the SAP Instance health. </param>
        internal EnqueueReplicationServerProperties(EnqueueReplicationServerType? ersVersion, string instanceNo, string hostname, string kernelVersion, string kernelPatch, string ipAddress, SapHealthState? health)
        {
            ErsVersion = ersVersion;
            InstanceNo = instanceNo;
            Hostname = hostname;
            KernelVersion = kernelVersion;
            KernelPatch = kernelPatch;
            IPAddress = ipAddress;
            Health = health;
        }

        /// <summary> Defines the type of Enqueue Replication Server. </summary>
        public EnqueueReplicationServerType? ErsVersion { get; }
        /// <summary> The ERS server instance id. </summary>
        public string InstanceNo { get; }
        /// <summary> The ERS server SAP host name. </summary>
        public string Hostname { get; }
        /// <summary> The ERS server SAP kernel version. </summary>
        public string KernelVersion { get; }
        /// <summary> The ERS server SAP kernel patch. </summary>
        public string KernelPatch { get; }
        /// <summary> The ERS server SAP IP Address. </summary>
        public string IPAddress { get; }
        /// <summary> Defines the SAP Instance health. </summary>
        public SapHealthState? Health { get; }
    }
}
