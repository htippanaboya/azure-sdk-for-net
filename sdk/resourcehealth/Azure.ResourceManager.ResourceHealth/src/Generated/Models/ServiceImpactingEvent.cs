// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Lists the service impacting events that may be affecting the health of the resource. </summary>
    public partial class ServiceImpactingEvent
    {
        /// <summary> Initializes a new instance of ServiceImpactingEvent. </summary>
        internal ServiceImpactingEvent()
        {
        }

        /// <summary> Initializes a new instance of ServiceImpactingEvent. </summary>
        /// <param name="eventStartOn"> Timestamp for when the event started. </param>
        /// <param name="eventStatusLastModifiedOn"> Timestamp for when event was submitted/detected. </param>
        /// <param name="correlationId"> Correlation id for the event. </param>
        /// <param name="status"> Status of the service impacting event. </param>
        /// <param name="incidentProperties"> Properties of the service impacting event. </param>
        internal ServiceImpactingEvent(DateTimeOffset? eventStartOn, DateTimeOffset? eventStatusLastModifiedOn, string correlationId, ServiceImpactingEventStatus status, ServiceImpactingEventIncidentProperties incidentProperties)
        {
            EventStartOn = eventStartOn;
            EventStatusLastModifiedOn = eventStatusLastModifiedOn;
            CorrelationId = correlationId;
            Status = status;
            IncidentProperties = incidentProperties;
        }

        /// <summary> Timestamp for when the event started. </summary>
        public DateTimeOffset? EventStartOn { get; }
        /// <summary> Timestamp for when event was submitted/detected. </summary>
        public DateTimeOffset? EventStatusLastModifiedOn { get; }
        /// <summary> Correlation id for the event. </summary>
        public string CorrelationId { get; }
        /// <summary> Status of the service impacting event. </summary>
        internal ServiceImpactingEventStatus Status { get; }
        /// <summary> Current status of the event. </summary>
        public string StatusValue
        {
            get => Status?.Value;
        }

        /// <summary> Properties of the service impacting event. </summary>
        public ServiceImpactingEventIncidentProperties IncidentProperties { get; }
    }
}
