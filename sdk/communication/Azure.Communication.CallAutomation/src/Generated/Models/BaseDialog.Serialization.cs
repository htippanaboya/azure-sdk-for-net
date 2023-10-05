// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    public partial class BaseDialog : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (Optional.IsCollectionDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStartObject();
                foreach (var item in Context)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static BaseDialog DeserializeBaseDialog(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureOpenAIDialog": return AzureOpenAIDialog.DeserializeAzureOpenAIDialog(element);
                    case "PowerVirtualAgentsDialog": return PowerVirtualAgentsDialog.DeserializePowerVirtualAgentsDialog(element);
                }
            }
            return UnknownBaseDialog.DeserializeUnknownBaseDialog(element);
        }
    }
}
