// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of Route and their operations over its parent. </summary>
    public partial class RouteCollection : ArmCollection, IEnumerable<Route>, IAsyncEnumerable<Route>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly RoutesRestOperations _routesRestClient;

        /// <summary> Initializes a new instance of the <see cref="RouteCollection"/> class for mocking. </summary>
        protected RouteCollection()
        {
        }

        /// <summary> Initializes a new instance of RouteCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal RouteCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _routesRestClient = new RoutesRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => RouteTable.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a route in the specified route table. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="routeParameters"> Parameters supplied to the create or update route operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="routeParameters"/> is null. </exception>
        public virtual RouteCreateOrUpdateOperation CreateOrUpdate(string routeName, RouteData routeParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (routeParameters == null)
            {
                throw new ArgumentNullException(nameof(routeParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _routesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, routeParameters, cancellationToken);
                var operation = new RouteCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _routesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, routeParameters).Request, response);
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

        /// <summary> Creates or updates a route in the specified route table. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="routeParameters"> Parameters supplied to the create or update route operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> or <paramref name="routeParameters"/> is null. </exception>
        public async virtual Task<RouteCreateOrUpdateOperation> CreateOrUpdateAsync(string routeName, RouteData routeParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }
            if (routeParameters == null)
            {
                throw new ArgumentNullException(nameof(routeParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _routesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, routeParameters, cancellationToken).ConfigureAwait(false);
                var operation = new RouteCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _routesRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, routeParameters).Request, response);
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

        /// <summary> Gets the specified route from a route table. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<Route> Get(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.Get");
            scope.Start();
            try
            {
                var response = _routesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new Route(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified route from a route table. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<Route>> GetAsync(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.Get");
            scope.Start();
            try
            {
                var response = await _routesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new Route(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<Route> GetIfExists(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _routesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<Route>(null, response.GetRawResponse())
                    : Response.FromValue(new Route(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<Route>> GetIfExistsAsync(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _routesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<Route>(null, response.GetRawResponse())
                    : Response.FromValue(new Route(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public virtual Response<bool> Exists(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(routeName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeName"> The name of the route. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string routeName, CancellationToken cancellationToken = default)
        {
            if (routeName == null)
            {
                throw new ArgumentNullException(nameof(routeName));
            }

            using var scope = _clientDiagnostics.CreateScope("RouteCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(routeName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all routes in a route table. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Route" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<Route> GetAll(CancellationToken cancellationToken = default)
        {
            Page<Route> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Route> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _routesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all routes in a route table. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Route" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<Route> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Route>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Route>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("RouteCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _routesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Route(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<Route> IEnumerable<Route>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<Route> IAsyncEnumerable<Route>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, Route, RouteData> Construct() { }
    }
}
