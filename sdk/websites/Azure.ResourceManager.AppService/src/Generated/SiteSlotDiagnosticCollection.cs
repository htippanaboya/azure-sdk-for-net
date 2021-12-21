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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of DiagnosticCategory and their operations over its parent. </summary>
    public partial class SiteSlotDiagnosticCollection : ArmCollection, IEnumerable<SiteSlotDiagnostic>, IAsyncEnumerable<SiteSlotDiagnostic>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DiagnosticsRestOperations _diagnosticsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SiteSlotDiagnosticCollection"/> class for mocking. </summary>
        protected SiteSlotDiagnosticCollection()
        {
        }

        /// <summary> Initializes a new instance of SiteSlotDiagnosticCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SiteSlotDiagnosticCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _diagnosticsRestClient = new DiagnosticsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SiteSlot.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: Diagnostics_GetSiteDiagnosticCategorySlot
        /// <summary> Description for Get Diagnostics Category. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<SiteSlotDiagnostic> Get(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = _diagnosticsRestClient.GetSiteDiagnosticCategorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteSlotDiagnostic(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics/{diagnosticCategory}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: Diagnostics_GetSiteDiagnosticCategorySlot
        /// <summary> Description for Get Diagnostics Category. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public async virtual Task<Response<SiteSlotDiagnostic>> GetAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticsRestClient.GetSiteDiagnosticCategorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SiteSlotDiagnostic(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<SiteSlotDiagnostic> GetIfExists(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diagnosticsRestClient.GetSiteDiagnosticCategorySlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SiteSlotDiagnostic>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotDiagnostic(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public async virtual Task<Response<SiteSlotDiagnostic>> GetIfExistsAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _diagnosticsRestClient.GetSiteDiagnosticCategorySlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, diagnosticCategory, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SiteSlotDiagnostic>(null, response.GetRawResponse())
                    : Response.FromValue(new SiteSlotDiagnostic(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public virtual Response<bool> CheckIfExists(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(diagnosticCategory, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="diagnosticCategory"> Diagnostic Category. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="diagnosticCategory"/> is null. </exception>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string diagnosticCategory, CancellationToken cancellationToken = default)
        {
            if (diagnosticCategory == null)
            {
                throw new ArgumentNullException(nameof(diagnosticCategory));
            }

            using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(diagnosticCategory, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: Diagnostics_ListSiteDiagnosticCategoriesSlot
        /// <summary> Description for Get Diagnostics Categories. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SiteSlotDiagnostic" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SiteSlotDiagnostic> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SiteSlotDiagnostic> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticsRestClient.ListSiteDiagnosticCategoriesSlot(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnostic(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SiteSlotDiagnostic> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticsRestClient.ListSiteDiagnosticCategoriesSlotNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnostic(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{siteName}/slots/{slot}/diagnostics
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/slots/{slot}
        /// OperationId: Diagnostics_ListSiteDiagnosticCategoriesSlot
        /// <summary> Description for Get Diagnostics Categories. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SiteSlotDiagnostic" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SiteSlotDiagnostic> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SiteSlotDiagnostic>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticsRestClient.ListSiteDiagnosticCategoriesSlotAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnostic(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SiteSlotDiagnostic>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SiteSlotDiagnosticCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticsRestClient.ListSiteDiagnosticCategoriesSlotNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SiteSlotDiagnostic(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SiteSlotDiagnostic> IEnumerable<SiteSlotDiagnostic>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SiteSlotDiagnostic> IAsyncEnumerable<SiteSlotDiagnostic>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SiteSlotDiagnostic, DiagnosticCategoryData> Construct() { }
    }
}
