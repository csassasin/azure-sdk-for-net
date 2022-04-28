// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Single sign-on request information for domain management. </summary>
    public partial class DomainControlCenterSsoRequest
    {
        /// <summary> Initializes a new instance of DomainControlCenterSsoRequest. </summary>
        internal DomainControlCenterSsoRequest()
        {
        }

        /// <summary> Initializes a new instance of DomainControlCenterSsoRequest. </summary>
        /// <param name="uri"> URL where the single sign-on request is to be made. </param>
        /// <param name="postParameterKey"> Post parameter key. </param>
        /// <param name="postParameterValue"> Post parameter value. Client should use &apos;application/x-www-form-urlencoded&apos; encoding for this value. </param>
        internal DomainControlCenterSsoRequest(Uri uri, string postParameterKey, string postParameterValue)
        {
            Uri = uri;
            PostParameterKey = postParameterKey;
            PostParameterValue = postParameterValue;
        }

        /// <summary> URL where the single sign-on request is to be made. </summary>
        public Uri Uri { get; }
        /// <summary> Post parameter key. </summary>
        public string PostParameterKey { get; }
        /// <summary> Post parameter value. Client should use &apos;application/x-www-form-urlencoded&apos; encoding for this value. </summary>
        public string PostParameterValue { get; }
    }
}
