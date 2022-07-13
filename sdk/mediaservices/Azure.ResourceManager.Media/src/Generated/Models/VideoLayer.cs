// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the settings to be used when encoding the input video into a desired output bitrate layer. </summary>
    public partial class VideoLayer : Layer
    {
        /// <summary> Initializes a new instance of VideoLayer. </summary>
        /// <param name="bitrate"> The average bitrate in bits per second at which to encode the input video when generating this layer. This is a required field. </param>
        public VideoLayer(int bitrate)
        {
            Bitrate = bitrate;
        }

        /// <summary> Initializes a new instance of VideoLayer. </summary>
        /// <param name="width"> The width of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in width as the input. </param>
        /// <param name="height"> The height of the output video for this layer. The value can be absolute (in pixels) or relative (in percentage). For example 50% means the output video has half as many pixels in height as the input. </param>
        /// <param name="label"> The alphanumeric label for this layer, which can be used in multiplexing different video and audio layers, or in naming the output file. </param>
        /// <param name="bitrate"> The average bitrate in bits per second at which to encode the input video when generating this layer. This is a required field. </param>
        /// <param name="maxBitrate"> The maximum bitrate (in bits per second), at which the VBV buffer should be assumed to refill. If not specified, defaults to the same value as bitrate. </param>
        /// <param name="bFrames"> The number of B-frames to be used when encoding this layer.  If not specified, the encoder chooses an appropriate number based on the video profile and level. </param>
        /// <param name="frameRate"> The frame rate (in frames per second) at which to encode this layer. The value can be in the form of M/N where M and N are integers (For example, 30000/1001), or in the form of a number (For example, 30, or 29.97). The encoder enforces constraints on allowed frame rates based on the profile and level. If it is not specified, the encoder will use the same frame rate as the input video. </param>
        /// <param name="slices"> The number of slices to be used when encoding this layer. If not specified, default is zero, which means that encoder will use a single slice for each frame. </param>
        /// <param name="adaptiveBFrame"> Whether or not adaptive B-frames are to be used when encoding this layer. If not specified, the encoder will turn it on whenever the video profile permits its use. </param>
        internal VideoLayer(string width, string height, string label, int bitrate, int? maxBitrate, int? bFrames, string frameRate, int? slices, bool? adaptiveBFrame) : base(width, height, label)
        {
            Bitrate = bitrate;
            MaxBitrate = maxBitrate;
            BFrames = bFrames;
            FrameRate = frameRate;
            Slices = slices;
            AdaptiveBFrame = adaptiveBFrame;
        }

        /// <summary> The average bitrate in bits per second at which to encode the input video when generating this layer. This is a required field. </summary>
        public int Bitrate { get; set; }
        /// <summary> The maximum bitrate (in bits per second), at which the VBV buffer should be assumed to refill. If not specified, defaults to the same value as bitrate. </summary>
        public int? MaxBitrate { get; set; }
        /// <summary> The number of B-frames to be used when encoding this layer.  If not specified, the encoder chooses an appropriate number based on the video profile and level. </summary>
        public int? BFrames { get; set; }
        /// <summary> The frame rate (in frames per second) at which to encode this layer. The value can be in the form of M/N where M and N are integers (For example, 30000/1001), or in the form of a number (For example, 30, or 29.97). The encoder enforces constraints on allowed frame rates based on the profile and level. If it is not specified, the encoder will use the same frame rate as the input video. </summary>
        public string FrameRate { get; set; }
        /// <summary> The number of slices to be used when encoding this layer. If not specified, default is zero, which means that encoder will use a single slice for each frame. </summary>
        public int? Slices { get; set; }
        /// <summary> Whether or not adaptive B-frames are to be used when encoding this layer. If not specified, the encoder will turn it on whenever the video profile permits its use. </summary>
        public bool? AdaptiveBFrame { get; set; }
    }
}
