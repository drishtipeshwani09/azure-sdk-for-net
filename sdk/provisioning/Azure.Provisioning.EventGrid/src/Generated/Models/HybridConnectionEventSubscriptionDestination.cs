// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.EventGrid;

/// <summary>
/// Information about the HybridConnection destination for an event
/// subscription.
/// </summary>
public partial class HybridConnectionEventSubscriptionDestination : EventSubscriptionDestination
{
    /// <summary>
    /// The Azure Resource ID of an hybrid connection that is the destination
    /// of an event subscription.
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId { get => _resourceId; set => _resourceId.Assign(value); }
    private readonly BicepValue<ResourceIdentifier> _resourceId;

    /// <summary>
    /// Delivery attribute details.             Please note
    /// Azure.ResourceManager.EventGrid.Models.DeliveryAttributeMapping is the
    /// base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.EventGrid.Models.DynamicDeliveryAttributeMapping
    /// and
    /// Azure.ResourceManager.EventGrid.Models.StaticDeliveryAttributeMapping.
    /// </summary>
    public BicepList<DeliveryAttributeMapping> DeliveryAttributeMappings { get => _deliveryAttributeMappings; set => _deliveryAttributeMappings.Assign(value); }
    private readonly BicepList<DeliveryAttributeMapping> _deliveryAttributeMappings;

    /// <summary>
    /// Creates a new HybridConnectionEventSubscriptionDestination.
    /// </summary>
    public HybridConnectionEventSubscriptionDestination() : base()
    {
        BicepValue<string>.DefineProperty(this, "endpointType", ["endpointType"], defaultValue: "HybridConnection");
        _resourceId = BicepValue<ResourceIdentifier>.DefineProperty(this, "ResourceId", ["properties", "resourceId"]);
        _deliveryAttributeMappings = BicepList<DeliveryAttributeMapping>.DefineProperty(this, "DeliveryAttributeMappings", ["properties", "deliveryAttributeMappings"]);
    }
}
