// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxDiskCopyLogDetails
    {
        internal static DataBoxDiskCopyLogDetails DeserializeDataBoxDiskCopyLogDetails(JsonElement element)
        {
            Optional<string> diskSerialNumber = default;
            Optional<string> errorLogLink = default;
            Optional<string> verboseLogLink = default;
            ClassDiscriminator copyLogDetailsType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSerialNumber"))
                {
                    diskSerialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("errorLogLink"))
                {
                    errorLogLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("verboseLogLink"))
                {
                    verboseLogLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("copyLogDetailsType"))
                {
                    copyLogDetailsType = property.Value.GetString().ToClassDiscriminator();
                    continue;
                }
            }
            return new DataBoxDiskCopyLogDetails(copyLogDetailsType, diskSerialNumber.Value, errorLogLink.Value, verboseLogLink.Value);
        }
    }
}
