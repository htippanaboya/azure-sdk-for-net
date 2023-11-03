// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Monitor.OpenTelemetry.LiveMetrics.Models
{
    /// <summary> A filter set on UX. </summary>
    internal partial class FilterInfo
    {
        /// <summary> Initializes a new instance of FilterInfo. </summary>
        internal FilterInfo()
        {
        }

        /// <summary> Initializes a new instance of FilterInfo. </summary>
        /// <param name="fieldName"> dimension name of the filter. </param>
        /// <param name="predicate"> Operator of the filter. </param>
        /// <param name="comparand"></param>
        internal FilterInfo(string fieldName, FilterInfoPredicate? predicate, string comparand)
        {
            FieldName = fieldName;
            Predicate = predicate;
            Comparand = comparand;
        }

        /// <summary> dimension name of the filter. </summary>
        public string FieldName { get; }
        /// <summary> Operator of the filter. </summary>
        public FilterInfoPredicate? Predicate { get; }
        /// <summary> Gets the comparand. </summary>
        public string Comparand { get; }
    }
}
