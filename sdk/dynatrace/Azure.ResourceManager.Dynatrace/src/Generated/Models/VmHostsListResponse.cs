// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Dynatrace.Models
{
    /// <summary> Response of a list VM Host Operation. </summary>
    internal partial class VmHostsListResponse
    {
        /// <summary> Initializes a new instance of VmHostsListResponse. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> or <paramref name="nextLink"/> is null. </exception>
        internal VmHostsListResponse(IEnumerable<VmInfo> value, string nextLink)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }

            Value = value.ToList();
            NextLink = nextLink;
        }

        /// <summary> Initializes a new instance of VmHostsListResponse. </summary>
        /// <param name="value"> The items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal VmHostsListResponse(IReadOnlyList<VmInfo> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The items on this page. </summary>
        public IReadOnlyList<VmInfo> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public string NextLink { get; }
    }
}
