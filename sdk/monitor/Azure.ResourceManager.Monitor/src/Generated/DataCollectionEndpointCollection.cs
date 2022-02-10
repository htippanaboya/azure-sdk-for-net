// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Monitor.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing collection of DataCollectionEndpoint and their operations over its parent. </summary>
    public partial class DataCollectionEndpointCollection : ArmCollection, IEnumerable<DataCollectionEndpoint>, IAsyncEnumerable<DataCollectionEndpoint>
    {
        private readonly ClientDiagnostics _dataCollectionEndpointClientDiagnostics;
        private readonly DataCollectionEndpointsRestOperations _dataCollectionEndpointRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataCollectionEndpointCollection"/> class for mocking. </summary>
        protected DataCollectionEndpointCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataCollectionEndpointCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataCollectionEndpointCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataCollectionEndpointClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", DataCollectionEndpoint.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(DataCollectionEndpoint.ResourceType, out string dataCollectionEndpointApiVersion);
            _dataCollectionEndpointRestClient = new DataCollectionEndpointsRestOperations(_dataCollectionEndpointClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, dataCollectionEndpointApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroup.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroup.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Create
        /// <summary> Creates or updates a data collection endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="body"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public async virtual Task<DataCollectionEndpointCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string dataCollectionEndpointName, DataCollectionEndpointData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataCollectionEndpointRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, body, cancellationToken).ConfigureAwait(false);
                var operation = new DataCollectionEndpointCreateOrUpdateOperation(Client, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Create
        /// <summary> Creates or updates a data collection endpoint. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="body"> The payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual DataCollectionEndpointCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string dataCollectionEndpointName, DataCollectionEndpointData body = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataCollectionEndpointRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, body, cancellationToken);
                var operation = new DataCollectionEndpointCreateOrUpdateOperation(Client, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Get
        /// <summary> Returns the specified data collection endpoint. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public async virtual Task<Response<DataCollectionEndpoint>> GetAsync(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataCollectionEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _dataCollectionEndpointClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DataCollectionEndpoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Get
        /// <summary> Returns the specified data collection endpoint. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual Response<DataCollectionEndpoint> Get(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.Get");
            scope.Start();
            try
            {
                var response = _dataCollectionEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken);
                if (response.Value == null)
                    throw _dataCollectionEndpointClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataCollectionEndpoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_ListByResourceGroup
        /// <summary> Lists all data collection endpoints in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataCollectionEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataCollectionEndpoint> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DataCollectionEndpoint>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataCollectionEndpointRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionEndpoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DataCollectionEndpoint>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _dataCollectionEndpointRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionEndpoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_ListByResourceGroup
        /// <summary> Lists all data collection endpoints in the specified resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataCollectionEndpoint" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataCollectionEndpoint> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DataCollectionEndpoint> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataCollectionEndpointRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionEndpoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DataCollectionEndpoint> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _dataCollectionEndpointRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DataCollectionEndpoint(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(dataCollectionEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual Response<bool> Exists(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(dataCollectionEndpointName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public async virtual Task<Response<DataCollectionEndpoint>> GetIfExistsAsync(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataCollectionEndpointRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DataCollectionEndpoint>(null, response.GetRawResponse());
                return Response.FromValue(new DataCollectionEndpoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/dataCollectionEndpoints/{dataCollectionEndpointName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: DataCollectionEndpoints_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="dataCollectionEndpointName"> The name of the data collection endpoint. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="dataCollectionEndpointName"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="dataCollectionEndpointName"/> is null. </exception>
        public virtual Response<DataCollectionEndpoint> GetIfExists(string dataCollectionEndpointName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(dataCollectionEndpointName, nameof(dataCollectionEndpointName));

            using var scope = _dataCollectionEndpointClientDiagnostics.CreateScope("DataCollectionEndpointCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataCollectionEndpointRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, dataCollectionEndpointName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DataCollectionEndpoint>(null, response.GetRawResponse());
                return Response.FromValue(new DataCollectionEndpoint(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataCollectionEndpoint> IEnumerable<DataCollectionEndpoint>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataCollectionEndpoint> IAsyncEnumerable<DataCollectionEndpoint>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
