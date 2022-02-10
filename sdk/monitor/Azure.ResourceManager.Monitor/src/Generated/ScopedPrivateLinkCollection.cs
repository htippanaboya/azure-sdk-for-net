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

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing collection of ScopedPrivateLink and their operations over its parent. </summary>
    public partial class ScopedPrivateLinkCollection : ArmCollection, IEnumerable<ScopedPrivateLink>, IAsyncEnumerable<ScopedPrivateLink>
    {
        private readonly ClientDiagnostics _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics;
        private readonly PrivateLinkScopedResourcesRestOperations _scopedPrivateLinkPrivateLinkScopedResourcesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ScopedPrivateLinkCollection"/> class for mocking. </summary>
        protected ScopedPrivateLinkCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ScopedPrivateLinkCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ScopedPrivateLinkCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Monitor", ScopedPrivateLink.ResourceType.Namespace, DiagnosticOptions);
            Client.TryGetApiVersion(ScopedPrivateLink.ResourceType, out string scopedPrivateLinkPrivateLinkScopedResourcesApiVersion);
            _scopedPrivateLinkPrivateLinkScopedResourcesRestClient = new PrivateLinkScopedResourcesRestOperations(_scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics, Pipeline, DiagnosticOptions.ApplicationId, BaseUri, scopedPrivateLinkPrivateLinkScopedResourcesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != PrivateLinkScope.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, PrivateLinkScope.ResourceType), nameof(id));
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}
        /// OperationId: PrivateLinkScopedResources_CreateOrUpdate
        /// <summary> Approve or reject a private endpoint connection with a given name. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="parameters"> The ScopedPrivateLink to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ScopedPrivateLinkCreateOrUpdateOperation> CreateOrUpdateAsync(bool waitForCompletion, string name, ScopedPrivateLinkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new ScopedPrivateLinkCreateOrUpdateOperation(Client, _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics, Pipeline, _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}
        /// OperationId: PrivateLinkScopedResources_CreateOrUpdate
        /// <summary> Approve or reject a private endpoint connection with a given name. </summary>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="parameters"> The ScopedPrivateLink to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ScopedPrivateLinkCreateOrUpdateOperation CreateOrUpdate(bool waitForCompletion, string name, ScopedPrivateLinkData parameters, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, parameters, cancellationToken);
                var operation = new ScopedPrivateLinkCreateOrUpdateOperation(Client, _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics, Pipeline, _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}
        /// OperationId: PrivateLinkScopedResources_Get
        /// <summary> Gets a scoped resource in a private link scope. </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<ScopedPrivateLink>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = await _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ScopedPrivateLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}
        /// OperationId: PrivateLinkScopedResources_Get
        /// <summary> Gets a scoped resource in a private link scope. </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<ScopedPrivateLink> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.Get");
            scope.Start();
            try
            {
                var response = _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ScopedPrivateLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}
        /// OperationId: PrivateLinkScopedResources_ListByPrivateLinkScope
        /// <summary> Gets all private endpoint connections on a private link scope. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ScopedPrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ScopedPrivateLink> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ScopedPrivateLink>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.ListByPrivateLinkScopeAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ScopedPrivateLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ScopedPrivateLink>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.ListByPrivateLinkScopeNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ScopedPrivateLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}
        /// OperationId: PrivateLinkScopedResources_ListByPrivateLinkScope
        /// <summary> Gets all private endpoint connections on a private link scope. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ScopedPrivateLink" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ScopedPrivateLink> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ScopedPrivateLink> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.ListByPrivateLinkScope(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ScopedPrivateLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ScopedPrivateLink> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.ListByPrivateLinkScopeNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ScopedPrivateLink(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}
        /// OperationId: PrivateLinkScopedResources_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}
        /// OperationId: PrivateLinkScopedResources_Get
        /// <summary> Checks to see if the resource exists in azure. </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}
        /// OperationId: PrivateLinkScopedResources_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<ScopedPrivateLink>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<ScopedPrivateLink>(null, response.GetRawResponse());
                return Response.FromValue(new ScopedPrivateLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Insights/privateLinkScopes/{scopeName}/scopedResources/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/microsoft.insights/privateLinkScopes/{scopeName}
        /// OperationId: PrivateLinkScopedResources_Get
        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the scoped resource object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<ScopedPrivateLink> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _scopedPrivateLinkPrivateLinkScopedResourcesClientDiagnostics.CreateScope("ScopedPrivateLinkCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _scopedPrivateLinkPrivateLinkScopedResourcesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<ScopedPrivateLink>(null, response.GetRawResponse());
                return Response.FromValue(new ScopedPrivateLink(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ScopedPrivateLink> IEnumerable<ScopedPrivateLink>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ScopedPrivateLink> IAsyncEnumerable<ScopedPrivateLink>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
