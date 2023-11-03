// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Communication.JobRouter
{
    public partial class RoundRobinMode
    {
        internal static RoundRobinMode DeserializeRoundRobinMode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> minConcurrentOffers = default;
            Optional<int> maxConcurrentOffers = default;
            Optional<bool> bypassSelectors = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minConcurrentOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minConcurrentOffers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConcurrentOffers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentOffers = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("bypassSelectors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bypassSelectors = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new RoundRobinMode(minConcurrentOffers, maxConcurrentOffers, Optional.ToNullable(bypassSelectors), kind);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new RoundRobinMode FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRoundRobinMode(document.RootElement);
        }
    }
}
