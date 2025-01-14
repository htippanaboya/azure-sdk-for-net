// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Support.Models;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A class representing the ChatTranscriptDetail data model.
    /// Object that represents a Chat Transcript resource.
    /// </summary>
    public partial class ChatTranscriptDetailData : ResourceData
    {
        /// <summary> Initializes a new instance of ChatTranscriptDetailData. </summary>
        public ChatTranscriptDetailData()
        {
            Messages = new ChangeTrackingList<ChatTranscriptMessageProperties>();
        }

        /// <summary> Initializes a new instance of ChatTranscriptDetailData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="messages"> List of chat transcript communication resources. </param>
        /// <param name="startOn"> Time in UTC (ISO 8601 format) when the chat began. </param>
        internal ChatTranscriptDetailData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<ChatTranscriptMessageProperties> messages, DateTimeOffset? startOn) : base(id, name, resourceType, systemData)
        {
            Messages = messages;
            StartOn = startOn;
        }

        /// <summary> List of chat transcript communication resources. </summary>
        public IList<ChatTranscriptMessageProperties> Messages { get; }
        /// <summary> Time in UTC (ISO 8601 format) when the chat began. </summary>
        public DateTimeOffset? StartOn { get; }
    }
}
