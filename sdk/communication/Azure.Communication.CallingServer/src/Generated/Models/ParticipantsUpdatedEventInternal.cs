// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The participant update event. </summary>
    internal partial class ParticipantsUpdatedEventInternal
    {
        /// <summary> Initializes a new instance of ParticipantsUpdatedEventInternal. </summary>
        internal ParticipantsUpdatedEventInternal()
        {
            Participants = new ChangeTrackingList<CommunicationParticipantInternal>();
        }

        /// <summary> Initializes a new instance of ParticipantsUpdatedEventInternal. </summary>
        /// <param name="callConnectionId"> The call connection id. </param>
        /// <param name="participants"> The list of participants. </param>
        internal ParticipantsUpdatedEventInternal(string callConnectionId, IReadOnlyList<CommunicationParticipantInternal> participants)
        {
            CallConnectionId = callConnectionId;
            Participants = participants;
        }

        /// <summary> The call connection id. </summary>
        public string CallConnectionId { get; }
        /// <summary> The list of participants. </summary>
        public IReadOnlyList<CommunicationParticipantInternal> Participants { get; }
    }
}
