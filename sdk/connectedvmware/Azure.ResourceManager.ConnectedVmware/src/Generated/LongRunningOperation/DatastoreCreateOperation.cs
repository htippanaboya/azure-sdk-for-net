// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.ConnectedVmware;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.ConnectedVmware.Models
{
    /// <summary> Create Or Update datastore. </summary>
    public partial class DatastoreCreateOperation : Operation<VmwareDatastore>, IOperationSource<VmwareDatastore>
    {
        private readonly OperationInternals<VmwareDatastore> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of DatastoreCreateOperation for mocking. </summary>
        protected DatastoreCreateOperation()
        {
        }

        internal DatastoreCreateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<VmwareDatastore>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.AzureAsyncOperation, "DatastoreCreateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override VmwareDatastore Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VmwareDatastore>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<VmwareDatastore>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        VmwareDatastore IOperationSource<VmwareDatastore>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new VmwareDatastore(_operationBase, VmwareDatastoreData.DeserializeVmwareDatastoreData(document.RootElement));
        }

        async ValueTask<VmwareDatastore> IOperationSource<VmwareDatastore>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new VmwareDatastore(_operationBase, VmwareDatastoreData.DeserializeVmwareDatastoreData(document.RootElement));
        }
    }
}
