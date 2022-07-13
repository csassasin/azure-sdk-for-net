// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> A list of exposure control feature values. </summary>
    public partial class ExposureControlBatchResult
    {
        /// <summary> Initializes a new instance of ExposureControlBatchResult. </summary>
        /// <param name="exposureControlResponses"> List of exposure control feature values. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="exposureControlResponses"/> is null. </exception>
        internal ExposureControlBatchResult(IEnumerable<ExposureControlResult> exposureControlResponses)
        {
            if (exposureControlResponses == null)
            {
                throw new ArgumentNullException(nameof(exposureControlResponses));
            }

            ExposureControlResponses = exposureControlResponses.ToList();
        }

        /// <summary> Initializes a new instance of ExposureControlBatchResult. </summary>
        /// <param name="exposureControlResponses"> List of exposure control feature values. </param>
        internal ExposureControlBatchResult(IReadOnlyList<ExposureControlResult> exposureControlResponses)
        {
            ExposureControlResponses = exposureControlResponses;
        }

        /// <summary> List of exposure control feature values. </summary>
        public IReadOnlyList<ExposureControlResult> ExposureControlResponses { get; }
    }
}
