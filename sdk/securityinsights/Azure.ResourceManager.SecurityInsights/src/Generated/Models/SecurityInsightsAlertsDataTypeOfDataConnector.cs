// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Alerts data type for data connectors. </summary>
    public partial class SecurityInsightsAlertsDataTypeOfDataConnector
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAlertsDataTypeOfDataConnector"/>. </summary>
        /// <param name="alerts"> Alerts data type connection. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="alerts"/> is null. </exception>
        public SecurityInsightsAlertsDataTypeOfDataConnector(DataConnectorDataTypeCommon alerts)
        {
            Argument.AssertNotNull(alerts, nameof(alerts));

            Alerts = alerts;
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsAlertsDataTypeOfDataConnector"/>. </summary>
        /// <param name="alerts"> Alerts data type connection. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsAlertsDataTypeOfDataConnector(DataConnectorDataTypeCommon alerts, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Alerts = alerts;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Alerts data type connection. </summary>
        internal DataConnectorDataTypeCommon Alerts { get; set; }
        /// <summary> Describe whether this data type connection is enabled or not. </summary>
        [WirePath("alerts.state")]
        public SecurityInsightsDataTypeConnectionState? AlertsState
        {
            get => Alerts is null ? default(SecurityInsightsDataTypeConnectionState?) : Alerts.State;
            set
            {
                Alerts = value.HasValue ? new DataConnectorDataTypeCommon(value.Value) : null;
            }
        }
    }
}
