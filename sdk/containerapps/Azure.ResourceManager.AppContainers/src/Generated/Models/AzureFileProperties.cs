// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Azure File Properties. </summary>
    public partial class AzureFileProperties
    {
        /// <summary> Initializes a new instance of AzureFileProperties. </summary>
        public AzureFileProperties()
        {
        }

        /// <summary> Initializes a new instance of AzureFileProperties. </summary>
        /// <param name="accountName"> Storage account name for azure file. </param>
        /// <param name="accountKey"> Storage account key for azure file. </param>
        /// <param name="accessMode"> Access mode for storage. </param>
        /// <param name="shareName"> Azure file share name. </param>
        internal AzureFileProperties(string accountName, string accountKey, AccessMode? accessMode, string shareName)
        {
            AccountName = accountName;
            AccountKey = accountKey;
            AccessMode = accessMode;
            ShareName = shareName;
        }

        /// <summary> Storage account name for azure file. </summary>
        public string AccountName { get; set; }
        /// <summary> Storage account key for azure file. </summary>
        public string AccountKey { get; set; }
        /// <summary> Access mode for storage. </summary>
        public AccessMode? AccessMode { get; set; }
        /// <summary> Azure file share name. </summary>
        public string ShareName { get; set; }
    }
}
