// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The desired maximum forecast horizon in units of time-series frequency. </summary>
    public partial class ForecastHorizon
    {
        /// <summary> Initializes a new instance of ForecastHorizon. </summary>
        public ForecastHorizon()
        {
        }

        /// <summary> Initializes a new instance of ForecastHorizon. </summary>
        /// <param name="mode"> [Required] Set forecast horizon value selection mode. </param>
        internal ForecastHorizon(ForecastHorizonMode mode)
        {
            Mode = mode;
        }

        /// <summary> [Required] Set forecast horizon value selection mode. </summary>
        internal ForecastHorizonMode Mode { get; set; }
    }
}
