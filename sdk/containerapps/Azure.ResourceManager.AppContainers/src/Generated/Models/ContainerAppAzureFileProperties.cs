// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Azure File Properties. </summary>
    public partial class ContainerAppAzureFileProperties
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerAppAzureFileProperties"/>. </summary>
        public ContainerAppAzureFileProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppAzureFileProperties"/>. </summary>
        /// <param name="accountName"> Storage account name for azure file. </param>
        /// <param name="accountKey"> Storage account key for azure file. </param>
        /// <param name="accessMode"> Access mode for storage. </param>
        /// <param name="shareName"> Azure file share name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppAzureFileProperties(string accountName, string accountKey, ContainerAppAccessMode? accessMode, string shareName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AccountName = accountName;
            AccountKey = accountKey;
            AccessMode = accessMode;
            ShareName = shareName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Storage account name for azure file. </summary>
        [WirePath("accountName")]
        public string AccountName { get; set; }
        /// <summary> Storage account key for azure file. </summary>
        [WirePath("accountKey")]
        public string AccountKey { get; set; }
        /// <summary> Access mode for storage. </summary>
        [WirePath("accessMode")]
        public ContainerAppAccessMode? AccessMode { get; set; }
        /// <summary> Azure file share name. </summary>
        [WirePath("shareName")]
        public string ShareName { get; set; }
    }
}
