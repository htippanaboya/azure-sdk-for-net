// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Database metrics. </summary>
    public partial class SqlMetric
    {
        /// <summary> Initializes a new instance of SqlMetric. </summary>
        internal SqlMetric()
        {
            MetricValues = new ChangeTrackingList<MetricValue>();
        }

        /// <summary> Initializes a new instance of SqlMetric. </summary>
        /// <param name="startTime"> The start time for the metric (ISO-8601 format). </param>
        /// <param name="endTime"> The end time for the metric (ISO-8601 format). </param>
        /// <param name="timeGrain"> The time step to be used to summarize the metric values. </param>
        /// <param name="unit"> The unit of the metric. </param>
        /// <param name="name"> The name information for the metric. </param>
        /// <param name="metricValues"> The metric values for the specified time window and timestep. </param>
        internal SqlMetric(DateTimeOffset? startTime, DateTimeOffset? endTime, string timeGrain, UnitType? unit, MetricName name, IReadOnlyList<MetricValue> metricValues)
        {
            StartTime = startTime;
            EndTime = endTime;
            TimeGrain = timeGrain;
            Unit = unit;
            Name = name;
            MetricValues = metricValues;
        }

        /// <summary> The start time for the metric (ISO-8601 format). </summary>
        public DateTimeOffset? StartTime { get; }
        /// <summary> The end time for the metric (ISO-8601 format). </summary>
        public DateTimeOffset? EndTime { get; }
        /// <summary> The time step to be used to summarize the metric values. </summary>
        public string TimeGrain { get; }
        /// <summary> The unit of the metric. </summary>
        public UnitType? Unit { get; }
        /// <summary> The name information for the metric. </summary>
        public MetricName Name { get; }
        /// <summary> The metric values for the specified time window and timestep. </summary>
        public IReadOnlyList<MetricValue> MetricValues { get; }
    }
}
