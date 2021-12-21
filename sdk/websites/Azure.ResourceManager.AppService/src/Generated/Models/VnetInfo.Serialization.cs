// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class VnetInfo
    {
        internal static VnetInfo DeserializeVnetInfo(JsonElement element)
        {
            Optional<string> vnetResourceId = default;
            Optional<string> certThumbprint = default;
            Optional<string> certBlob = default;
            Optional<IReadOnlyList<VnetRoute>> routes = default;
            Optional<bool> resyncRequired = default;
            Optional<string> dnsServers = default;
            Optional<bool> isSwift = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vnetResourceId"))
                {
                    vnetResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certThumbprint"))
                {
                    certThumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("certBlob"))
                {
                    certBlob = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("routes"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<VnetRoute> array = new List<VnetRoute>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VnetRoute.DeserializeVnetRoute(item));
                    }
                    routes = array;
                    continue;
                }
                if (property.NameEquals("resyncRequired"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    resyncRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("dnsServers"))
                {
                    dnsServers = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isSwift"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isSwift = property.Value.GetBoolean();
                    continue;
                }
            }
            return new VnetInfo(vnetResourceId.Value, certThumbprint.Value, certBlob.Value, Optional.ToList(routes), Optional.ToNullable(resyncRequired), dnsServers.Value, Optional.ToNullable(isSwift));
        }
    }
}
