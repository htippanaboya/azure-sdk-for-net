// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The trigger that results in a scaling action. </summary>
    public partial class MetricTrigger
    {
        /// <summary> Initializes a new instance of MetricTrigger. </summary>
        /// <param name="metricName"> the name of the metric that defines what the rule monitors. </param>
        /// <param name="metricResourceUri"> the resource identifier of the resource the rule monitors. </param>
        /// <param name="timeGrain"> the granularity of metrics the rule monitors. Must be one of the predefined values returned from metric definitions for the metric. Must be between 12 hours and 1 minute. </param>
        /// <param name="statistic"> the metric statistic type. How the metrics from multiple instances are combined. </param>
        /// <param name="timeWindow"> the range of time in which instance data is collected. This value must be greater than the delay in metric collection, which can vary from resource-to-resource. Must be between 12 hours and 5 minutes. </param>
        /// <param name="timeAggregation"> time aggregation type. How the data that is collected should be combined over time. The default value is Average. </param>
        /// <param name="operator"> the operator that is used to compare the metric data and the threshold. </param>
        /// <param name="threshold"> the threshold of the metric that triggers the scale action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="metricName"/> or <paramref name="metricResourceUri"/> is null. </exception>
        public MetricTrigger(string metricName, Uri metricResourceUri, TimeSpan timeGrain, MetricStatisticType statistic, TimeSpan timeWindow, TimeAggregationType timeAggregation, ComparisonOperationType @operator, double threshold)
        {
            if (metricName == null)
            {
                throw new ArgumentNullException(nameof(metricName));
            }
            if (metricResourceUri == null)
            {
                throw new ArgumentNullException(nameof(metricResourceUri));
            }

            MetricName = metricName;
            MetricResourceUri = metricResourceUri;
            TimeGrain = timeGrain;
            Statistic = statistic;
            TimeWindow = timeWindow;
            TimeAggregation = timeAggregation;
            Operator = @operator;
            Threshold = threshold;
            Dimensions = new ChangeTrackingList<ScaleRuleMetricDimension>();
        }

        /// <summary> Initializes a new instance of MetricTrigger. </summary>
        /// <param name="metricName"> the name of the metric that defines what the rule monitors. </param>
        /// <param name="metricNamespace"> the namespace of the metric that defines what the rule monitors. </param>
        /// <param name="metricResourceUri"> the resource identifier of the resource the rule monitors. </param>
        /// <param name="metricResourceLocation"> the location of the resource the rule monitors. </param>
        /// <param name="timeGrain"> the granularity of metrics the rule monitors. Must be one of the predefined values returned from metric definitions for the metric. Must be between 12 hours and 1 minute. </param>
        /// <param name="statistic"> the metric statistic type. How the metrics from multiple instances are combined. </param>
        /// <param name="timeWindow"> the range of time in which instance data is collected. This value must be greater than the delay in metric collection, which can vary from resource-to-resource. Must be between 12 hours and 5 minutes. </param>
        /// <param name="timeAggregation"> time aggregation type. How the data that is collected should be combined over time. The default value is Average. </param>
        /// <param name="operator"> the operator that is used to compare the metric data and the threshold. </param>
        /// <param name="threshold"> the threshold of the metric that triggers the scale action. </param>
        /// <param name="dimensions"> List of dimension conditions. For example: [{&quot;DimensionName&quot;:&quot;AppName&quot;,&quot;Operator&quot;:&quot;Equals&quot;,&quot;Values&quot;:[&quot;App1&quot;]},{&quot;DimensionName&quot;:&quot;Deployment&quot;,&quot;Operator&quot;:&quot;Equals&quot;,&quot;Values&quot;:[&quot;default&quot;]}]. </param>
        /// <param name="dividePerInstance"> a value indicating whether metric should divide per instance. </param>
        internal MetricTrigger(string metricName, string metricNamespace, Uri metricResourceUri, string metricResourceLocation, TimeSpan timeGrain, MetricStatisticType statistic, TimeSpan timeWindow, TimeAggregationType timeAggregation, ComparisonOperationType @operator, double threshold, IList<ScaleRuleMetricDimension> dimensions, bool? dividePerInstance)
        {
            MetricName = metricName;
            MetricNamespace = metricNamespace;
            MetricResourceUri = metricResourceUri;
            MetricResourceLocation = metricResourceLocation;
            TimeGrain = timeGrain;
            Statistic = statistic;
            TimeWindow = timeWindow;
            TimeAggregation = timeAggregation;
            Operator = @operator;
            Threshold = threshold;
            Dimensions = dimensions;
            DividePerInstance = dividePerInstance;
        }

        /// <summary> the name of the metric that defines what the rule monitors. </summary>
        public string MetricName { get; set; }
        /// <summary> the namespace of the metric that defines what the rule monitors. </summary>
        public string MetricNamespace { get; set; }
        /// <summary> the resource identifier of the resource the rule monitors. </summary>
        public Uri MetricResourceUri { get; set; }
        /// <summary> the location of the resource the rule monitors. </summary>
        public string MetricResourceLocation { get; set; }
        /// <summary> the granularity of metrics the rule monitors. Must be one of the predefined values returned from metric definitions for the metric. Must be between 12 hours and 1 minute. </summary>
        public TimeSpan TimeGrain { get; set; }
        /// <summary> the metric statistic type. How the metrics from multiple instances are combined. </summary>
        public MetricStatisticType Statistic { get; set; }
        /// <summary> the range of time in which instance data is collected. This value must be greater than the delay in metric collection, which can vary from resource-to-resource. Must be between 12 hours and 5 minutes. </summary>
        public TimeSpan TimeWindow { get; set; }
        /// <summary> time aggregation type. How the data that is collected should be combined over time. The default value is Average. </summary>
        public TimeAggregationType TimeAggregation { get; set; }
        /// <summary> the operator that is used to compare the metric data and the threshold. </summary>
        public ComparisonOperationType Operator { get; set; }
        /// <summary> the threshold of the metric that triggers the scale action. </summary>
        public double Threshold { get; set; }
        /// <summary> List of dimension conditions. For example: [{&quot;DimensionName&quot;:&quot;AppName&quot;,&quot;Operator&quot;:&quot;Equals&quot;,&quot;Values&quot;:[&quot;App1&quot;]},{&quot;DimensionName&quot;:&quot;Deployment&quot;,&quot;Operator&quot;:&quot;Equals&quot;,&quot;Values&quot;:[&quot;default&quot;]}]. </summary>
        public IList<ScaleRuleMetricDimension> Dimensions { get; set; }
        /// <summary> a value indicating whether metric should divide per instance. </summary>
        public bool? DividePerInstance { get; set; }
    }
}
