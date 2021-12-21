// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.SchemaRegistry.Models
{
    internal partial class ErrorDetail
    {
        internal static ErrorDetail DeserializeErrorDetail(JsonElement element)
        {
            string code = default;
            string message = default;
            Optional<IReadOnlyList<ErrorDetail>> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ErrorDetail> array = new List<ErrorDetail>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeErrorDetail(item));
                    }
                    details = array;
                    continue;
                }
            }
            return new ErrorDetail(code, message, Optional.ToList(details));
        }
    }
}
