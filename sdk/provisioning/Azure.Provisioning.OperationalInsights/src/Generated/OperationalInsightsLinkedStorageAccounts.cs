// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// OperationalInsightsLinkedStorageAccounts.
/// </summary>
public partial class OperationalInsightsLinkedStorageAccounts : Resource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Linked storage accounts type.
    /// </summary>
    public BicepValue<OperationalInsightsDataSourceType> DataSourceType { get => _dataSourceType; set => _dataSourceType.Assign(value); }
    private readonly BicepValue<OperationalInsightsDataSourceType> _dataSourceType;

    /// <summary>
    /// Linked storage accounts resources ids.
    /// </summary>
    public BicepList<ResourceIdentifier> StorageAccountIds { get => _storageAccountIds; set => _storageAccountIds.Assign(value); }
    private readonly BicepList<ResourceIdentifier> _storageAccountIds;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent OperationalInsightsWorkspace.
    /// </summary>
    public OperationalInsightsWorkspace? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<OperationalInsightsWorkspace> _parent;

    /// <summary>
    /// Creates a new OperationalInsightsLinkedStorageAccounts.
    /// </summary>
    /// <param name="resourceName">Name of the OperationalInsightsLinkedStorageAccounts.</param>
    /// <param name="resourceVersion">Version of the OperationalInsightsLinkedStorageAccounts.</param>
    public OperationalInsightsLinkedStorageAccounts(string resourceName, string? resourceVersion = default)
        : base(resourceName, "Microsoft.OperationalInsights/workspaces/linkedStorageAccounts", resourceVersion ?? "2023-09-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _dataSourceType = BicepValue<OperationalInsightsDataSourceType>.DefineProperty(this, "DataSourceType", ["properties", "dataSourceType"], isRequired: true);
        _storageAccountIds = BicepList<ResourceIdentifier>.DefineProperty(this, "StorageAccountIds", ["properties", "storageAccountIds"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<OperationalInsightsWorkspace>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported OperationalInsightsLinkedStorageAccounts resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2023-09-01.
        /// </summary>
        public static readonly string V2023_09_01 = "2023-09-01";

        /// <summary>
        /// 2020-08-01.
        /// </summary>
        public static readonly string V2020_08_01 = "2020-08-01";
    }

    /// <summary>
    /// Creates a reference to an existing
    /// OperationalInsightsLinkedStorageAccounts.
    /// </summary>
    /// <param name="resourceName">Name of the OperationalInsightsLinkedStorageAccounts.</param>
    /// <param name="resourceVersion">Version of the OperationalInsightsLinkedStorageAccounts.</param>
    /// <returns>The existing OperationalInsightsLinkedStorageAccounts resource.</returns>
    public static OperationalInsightsLinkedStorageAccounts FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
