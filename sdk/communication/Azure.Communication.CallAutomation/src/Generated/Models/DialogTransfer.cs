// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The DialogTransfer. </summary>
    internal partial class DialogTransfer
    {
        /// <summary> Initializes a new instance of DialogTransfer. </summary>
        internal DialogTransfer()
        {
        }

        /// <summary> Call connection ID. </summary>
        public string CallConnectionId { get; }
        /// <summary> Server call ID. </summary>
        public string ServerCallId { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
        /// <summary> Used by customers when calling answerCall action to correlate the request to the response event. </summary>
        public string OperationContext { get; }
        /// <summary> Contains the resulting SIP code/sub-code and message from NGC services. </summary>
        public ResultInformation ResultInformation { get; }
        /// <summary> Determines the type of the dialog. </summary>
        public DialogInputType? DialogInputType { get; }
        /// <summary> Dialog ID. </summary>
        public string DialogId { get; }
        /// <summary> Transfer type. </summary>
        public string TransferType { get; }
        /// <summary> Transfer destination. </summary>
        public string TransferDestination { get; }
        /// <summary> IVR context. </summary>
        public object IvrContext { get; }
    }
}
