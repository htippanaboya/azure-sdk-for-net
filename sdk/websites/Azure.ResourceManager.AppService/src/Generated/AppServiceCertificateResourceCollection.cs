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
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of AppServiceCertificateResource and their operations over its parent. </summary>
    public partial class AppServiceCertificateResourceCollection : ArmCollection, IEnumerable<AppServiceCertificateResource>, IAsyncEnumerable<AppServiceCertificateResource>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly AppServiceCertificateOrdersRestOperations _appServiceCertificateOrdersRestClient;

        /// <summary> Initializes a new instance of the <see cref="AppServiceCertificateResourceCollection"/> class for mocking. </summary>
        protected AppServiceCertificateResourceCollection()
        {
        }

        /// <summary> Initializes a new instance of AppServiceCertificateResourceCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal AppServiceCertificateResourceCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _appServiceCertificateOrdersRestClient = new AppServiceCertificateOrdersRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => AppServiceCertificateOrder.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: AppServiceCertificateOrders_CreateOrUpdateCertificate
        /// <summary> Description for Creates or updates a certificate and associates with key vault secret. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="keyVaultCertificate"> Key vault certificate resource Id. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="keyVaultCertificate"/> is null. </exception>
        public virtual AppServiceCertificateOrderCreateOrUpdateCertificateOperation CreateOrUpdate(string name, AppServiceCertificateResourceData keyVaultCertificate, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (keyVaultCertificate == null)
            {
                throw new ArgumentNullException(nameof(keyVaultCertificate));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrdersRestClient.CreateOrUpdateCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, keyVaultCertificate, cancellationToken);
                var operation = new AppServiceCertificateOrderCreateOrUpdateCertificateOperation(Parent, _clientDiagnostics, Pipeline, _appServiceCertificateOrdersRestClient.CreateCreateOrUpdateCertificateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, keyVaultCertificate).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: AppServiceCertificateOrders_CreateOrUpdateCertificate
        /// <summary> Description for Creates or updates a certificate and associates with key vault secret. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="keyVaultCertificate"> Key vault certificate resource Id. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="keyVaultCertificate"/> is null. </exception>
        public async virtual Task<AppServiceCertificateOrderCreateOrUpdateCertificateOperation> CreateOrUpdateAsync(string name, AppServiceCertificateResourceData keyVaultCertificate, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (keyVaultCertificate == null)
            {
                throw new ArgumentNullException(nameof(keyVaultCertificate));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrdersRestClient.CreateOrUpdateCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, keyVaultCertificate, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceCertificateOrderCreateOrUpdateCertificateOperation(Parent, _clientDiagnostics, Pipeline, _appServiceCertificateOrdersRestClient.CreateCreateOrUpdateCertificateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, keyVaultCertificate).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: AppServiceCertificateOrders_GetCertificate
        /// <summary> Description for Get the certificate associated with a certificate order. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AppServiceCertificateResource> Get(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.Get");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrdersRestClient.GetCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new AppServiceCertificateResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates/{name}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: AppServiceCertificateOrders_GetCertificate
        /// <summary> Description for Get the certificate associated with a certificate order. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<AppServiceCertificateResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.Get");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrdersRestClient.GetCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new AppServiceCertificateResource(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<AppServiceCertificateResource> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _appServiceCertificateOrdersRestClient.GetCertificate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<AppServiceCertificateResource>(null, response.GetRawResponse())
                    : Response.FromValue(new AppServiceCertificateResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<AppServiceCertificateResource>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _appServiceCertificateOrdersRestClient.GetCertificateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<AppServiceCertificateResource>(null, response.GetRawResponse())
                    : Response.FromValue(new AppServiceCertificateResource(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.CheckIfExists");
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

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> Name of the certificate. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.CheckIfExistsAsync");
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: AppServiceCertificateOrders_ListCertificates
        /// <summary> Description for List all certificates associated with a certificate order. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="AppServiceCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<AppServiceCertificateResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<AppServiceCertificateResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceCertificateOrdersRestClient.ListCertificates(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<AppServiceCertificateResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _appServiceCertificateOrdersRestClient.ListCertificatesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}/certificates
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CertificateRegistration/certificateOrders/{certificateOrderName}
        /// OperationId: AppServiceCertificateOrders_ListCertificates
        /// <summary> Description for List all certificates associated with a certificate order. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="AppServiceCertificateResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<AppServiceCertificateResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<AppServiceCertificateResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceCertificateOrdersRestClient.ListCertificatesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<AppServiceCertificateResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("AppServiceCertificateResourceCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _appServiceCertificateOrdersRestClient.ListCertificatesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new AppServiceCertificateResource(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<AppServiceCertificateResource> IEnumerable<AppServiceCertificateResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<AppServiceCertificateResource> IAsyncEnumerable<AppServiceCertificateResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, AppServiceCertificateResource, AppServiceCertificateResourceData> Construct() { }
    }
}
