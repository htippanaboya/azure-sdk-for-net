// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    public partial class ToneReceivedEvent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ToneInfo))
            {
                writer.WritePropertyName("toneInfo");
                writer.WriteObjectValue(ToneInfo);
            }
            if (Optional.IsDefined(CallConnectionId))
            {
                writer.WritePropertyName("callConnectionId");
                writer.WriteStringValue(CallConnectionId);
            }
            writer.WriteEndObject();
        }

        internal static ToneReceivedEvent DeserializeToneReceivedEvent(JsonElement element)
        {
            Optional<ToneInfo> toneInfo = default;
            Optional<string> callConnectionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("toneInfo"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    toneInfo = ToneInfo.DeserializeToneInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("callConnectionId"))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
            }
            return new ToneReceivedEvent(toneInfo.Value, callConnectionId.Value);
        }
    }
}
