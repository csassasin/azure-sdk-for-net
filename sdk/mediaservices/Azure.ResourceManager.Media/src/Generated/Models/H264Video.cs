// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes all the properties for encoding a video with the H.264 codec. </summary>
    public partial class H264Video : Video
    {
        /// <summary> Initializes a new instance of H264Video. </summary>
        public H264Video()
        {
            Layers = new ChangeTrackingList<H264Layer>();
            OdataType = "#Microsoft.Media.H264Video";
        }

        /// <summary> Initializes a new instance of H264Video. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        /// <param name="keyFrameInterval"> The distance between two key frames. The value should be non-zero in the range [0.5, 20] seconds, specified in ISO 8601 format. The default is 2 seconds(PT2S). Note that this setting is ignored if VideoSyncMode.Passthrough is set, where the KeyFrameInterval value will follow the input source setting. </param>
        /// <param name="stretchMode"> The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize. </param>
        /// <param name="syncMode"> The Video Sync Mode. </param>
        /// <param name="complexity"> Tells the encoder how to choose its encoding settings. The default value is Balanced. </param>
        /// <param name="layers"> The collection of output H.264 layers to be produced by the encoder. </param>
        /// <param name="rateControlMode"> The video rate control mode. </param>
        /// <param name="sceneChangeDetection"> Whether or not the encoder should insert key frames at scene changes. If not specified, the default is false. This flag should be set to true only when the encoder is being configured to produce a single output video. </param>
        internal H264Video(string odataType, string label, TimeSpan? keyFrameInterval, StretchMode? stretchMode, VideoSyncMode? syncMode, H264Complexity? complexity, IList<H264Layer> layers, H264RateControlMode? rateControlMode, bool? sceneChangeDetection) : base(odataType, label, keyFrameInterval, stretchMode, syncMode)
        {
            Complexity = complexity;
            Layers = layers;
            RateControlMode = rateControlMode;
            SceneChangeDetection = sceneChangeDetection;
            OdataType = odataType ?? "#Microsoft.Media.H264Video";
        }

        /// <summary> Tells the encoder how to choose its encoding settings. The default value is Balanced. </summary>
        public H264Complexity? Complexity { get; set; }
        /// <summary> The collection of output H.264 layers to be produced by the encoder. </summary>
        public IList<H264Layer> Layers { get; }
        /// <summary> The video rate control mode. </summary>
        public H264RateControlMode? RateControlMode { get; set; }
        /// <summary> Whether or not the encoder should insert key frames at scene changes. If not specified, the default is false. This flag should be set to true only when the encoder is being configured to produce a single output video. </summary>
        public bool? SceneChangeDetection { get; set; }
    }
}
