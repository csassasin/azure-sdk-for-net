// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a data disk. </summary>
    public partial class RestorePointSourceVmDataDisk
    {
        /// <summary> Initializes a new instance of RestorePointSourceVmDataDisk. </summary>
        internal RestorePointSourceVmDataDisk()
        {
        }

        /// <summary> Initializes a new instance of RestorePointSourceVmDataDisk. </summary>
        /// <param name="lun"> Gets the logical unit number. </param>
        /// <param name="name"> Gets the disk name. </param>
        /// <param name="caching"> Gets the caching type. </param>
        /// <param name="diskSizeGB"> Gets the initial disk size in GB for blank data disks, and the new desired size for existing OS and Data disks. </param>
        /// <param name="managedDisk"> Gets the managed disk details. </param>
        /// <param name="diskRestorePoint"> Gets the disk restore point Id. </param>
        internal RestorePointSourceVmDataDisk(int? lun, string name, CachingType? caching, int? diskSizeGB, VirtualMachineManagedDisk managedDisk, WritableSubResource diskRestorePoint)
        {
            Lun = lun;
            Name = name;
            Caching = caching;
            DiskSizeGB = diskSizeGB;
            ManagedDisk = managedDisk;
            DiskRestorePoint = diskRestorePoint;
        }

        /// <summary> Gets the logical unit number. </summary>
        public int? Lun { get; }
        /// <summary> Gets the disk name. </summary>
        public string Name { get; }
        /// <summary> Gets the caching type. </summary>
        public CachingType? Caching { get; }
        /// <summary> Gets the initial disk size in GB for blank data disks, and the new desired size for existing OS and Data disks. </summary>
        public int? DiskSizeGB { get; }
        /// <summary> Gets the managed disk details. </summary>
        public VirtualMachineManagedDisk ManagedDisk { get; }
        /// <summary> Gets the disk restore point Id. </summary>
        internal WritableSubResource DiskRestorePoint { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier DiskRestorePointId
        {
            get => DiskRestorePoint?.Id;
        }
    }
}
