// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.MediaComposition
{
    /// <summary> Media output to be used by the composition. </summary>
    public partial class MediaOutput
    {
        /// <summary> Initializes a new instance of MediaOutput. </summary>
        public MediaOutput()
        {
        }

        /// <summary> Initializes a new instance of MediaOutput. </summary>
        /// <param name="kind"> Kind of media output. </param>
        /// <param name="groupCall"> Group call to be used as an input or output. </param>
        /// <param name="room"> Group call to be used as an input or output. </param>
        /// <param name="teamsMeeting"> A Teams meeting to be used as an input or output. </param>
        /// <param name="rtmp"> Rtmp stream to be used as an input or output. </param>
        /// <param name="srt"> Srt stream to be used as an input or output. </param>
        internal MediaOutput(MediaOutputType? kind, GroupCall groupCall, GroupCall room, TeamsMeeting teamsMeeting, RtmpStream rtmp, SrtStream srt)
        {
            Kind = kind;
            GroupCall = groupCall;
            Room = room;
            TeamsMeeting = teamsMeeting;
            Rtmp = rtmp;
            Srt = srt;
        }

        /// <summary> Kind of media output. </summary>
        public MediaOutputType? Kind { get; set; }
        /// <summary> Group call to be used as an input or output. </summary>
        public GroupCall GroupCall { get; set; }
        /// <summary> Group call to be used as an input or output. </summary>
        public GroupCall Room { get; set; }
        /// <summary> A Teams meeting to be used as an input or output. </summary>
        public TeamsMeeting TeamsMeeting { get; set; }
        /// <summary> Rtmp stream to be used as an input or output. </summary>
        public RtmpStream Rtmp { get; set; }
        /// <summary> Srt stream to be used as an input or output. </summary>
        public SrtStream Srt { get; set; }
    }
}
