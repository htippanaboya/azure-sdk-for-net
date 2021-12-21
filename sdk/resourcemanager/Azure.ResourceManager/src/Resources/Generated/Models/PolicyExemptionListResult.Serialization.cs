// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class PolicyExemptionListResult
    {
        internal static PolicyExemptionListResult DeserializePolicyExemptionListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PolicyExemptionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PolicyExemptionData> array = new List<PolicyExemptionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PolicyExemptionData.DeserializePolicyExemptionData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new PolicyExemptionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
