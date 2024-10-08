// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the NetworkManagerRoutingRule data model.
    /// Network routing rule.
    /// </summary>
    public partial class NetworkManagerRoutingRuleData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="NetworkManagerRoutingRuleData"/>. </summary>
        public NetworkManagerRoutingRuleData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="NetworkManagerRoutingRuleData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="description"> A description for this rule. </param>
        /// <param name="provisioningState"> The provisioning state of the resource. </param>
        /// <param name="resourceGuid"> Unique identifier for this resource. </param>
        /// <param name="destination"> Indicates the destination for this particular rule. </param>
        /// <param name="nextHop"> Indicates the next hop for this particular rule. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkManagerRoutingRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string description, NetworkProvisioningState? provisioningState, Guid? resourceGuid, RoutingRuleRouteDestination destination, RoutingRuleNextHop nextHop, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            Description = description;
            ProvisioningState = provisioningState;
            ResourceGuid = resourceGuid;
            Destination = destination;
            NextHop = nextHop;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A description for this rule. </summary>
        public string Description { get; set; }
        /// <summary> The provisioning state of the resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> Unique identifier for this resource. </summary>
        public Guid? ResourceGuid { get; }
        /// <summary> Indicates the destination for this particular rule. </summary>
        public RoutingRuleRouteDestination Destination { get; set; }
        /// <summary> Indicates the next hop for this particular rule. </summary>
        public RoutingRuleNextHop NextHop { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
    }
}
