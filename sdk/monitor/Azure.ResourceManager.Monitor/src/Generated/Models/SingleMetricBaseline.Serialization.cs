// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class SingleMetricBaseline
    {
        internal static SingleMetricBaseline DeserializeSingleMetricBaseline(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string timespan = default;
            TimeSpan interval = default;
            Optional<string> @namespace = default;
            IReadOnlyList<TimeSeriesBaseline> baselines = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("timespan"))
                        {
                            timespan = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("interval"))
                        {
                            interval = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("namespace"))
                        {
                            @namespace = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("baselines"))
                        {
                            List<TimeSeriesBaseline> array = new List<TimeSeriesBaseline>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(TimeSeriesBaseline.DeserializeTimeSeriesBaseline(item));
                            }
                            baselines = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SingleMetricBaseline(id, name, type, systemData, timespan, interval, @namespace.Value, baselines);
        }
    }
}
