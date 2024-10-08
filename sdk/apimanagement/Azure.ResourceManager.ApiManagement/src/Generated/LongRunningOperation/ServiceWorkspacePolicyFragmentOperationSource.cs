// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement
{
    internal class ServiceWorkspacePolicyFragmentOperationSource : IOperationSource<ServiceWorkspacePolicyFragmentResource>
    {
        private readonly ArmClient _client;

        internal ServiceWorkspacePolicyFragmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        ServiceWorkspacePolicyFragmentResource IOperationSource<ServiceWorkspacePolicyFragmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = PolicyFragmentContractData.DeserializePolicyFragmentContractData(document.RootElement);
            return new ServiceWorkspacePolicyFragmentResource(_client, data);
        }

        async ValueTask<ServiceWorkspacePolicyFragmentResource> IOperationSource<ServiceWorkspacePolicyFragmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = PolicyFragmentContractData.DeserializePolicyFragmentContractData(document.RootElement);
            return new ServiceWorkspacePolicyFragmentResource(_client, data);
        }
    }
}
