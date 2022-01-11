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

namespace Azure.ResourceManager.EventHubs
{
    /// <summary> A class representing collection of AuthorizationRule and their operations over its parent. </summary>
    public partial class DisasterRecoveryAuthorizationRuleCollection : ArmCollection, IEnumerable<DisasterRecoveryAuthorizationRule>, IAsyncEnumerable<DisasterRecoveryAuthorizationRule>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DisasterRecoveryConfigsRestOperations _disasterRecoveryConfigsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DisasterRecoveryAuthorizationRuleCollection"/> class for mocking. </summary>
        protected DisasterRecoveryAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of DisasterRecoveryAuthorizationRuleCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DisasterRecoveryAuthorizationRuleCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _disasterRecoveryConfigsRestClient = new DisasterRecoveryConfigsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => DisasterRecovery.ResourceType;

        // Collection level operations.

        /// <summary> Gets an AuthorizationRule for a Namespace by rule name. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<DisasterRecoveryAuthorizationRule> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _disasterRecoveryConfigsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DisasterRecoveryAuthorizationRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets an AuthorizationRule for a Namespace by rule name. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<DisasterRecoveryAuthorizationRule>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryConfigsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DisasterRecoveryAuthorizationRule(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<DisasterRecoveryAuthorizationRule> GetIfExists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _disasterRecoveryConfigsRestClient.GetAuthorizationRule(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<DisasterRecoveryAuthorizationRule>(null, response.GetRawResponse())
                    : Response.FromValue(new DisasterRecoveryAuthorizationRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<DisasterRecoveryAuthorizationRule>> GetIfExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _disasterRecoveryConfigsRestClient.GetAuthorizationRuleAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<DisasterRecoveryAuthorizationRule>(null, response.GetRawResponse())
                    : Response.FromValue(new DisasterRecoveryAuthorizationRule(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(authorizationRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            if (authorizationRuleName == null)
            {
                throw new ArgumentNullException(nameof(authorizationRuleName));
            }

            using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of authorization rules for a Namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DisasterRecoveryAuthorizationRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DisasterRecoveryAuthorizationRule> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DisasterRecoveryAuthorizationRule> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _disasterRecoveryConfigsRestClient.ListAuthorizationRules(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecoveryAuthorizationRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DisasterRecoveryAuthorizationRule> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _disasterRecoveryConfigsRestClient.ListAuthorizationRulesNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecoveryAuthorizationRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets a list of authorization rules for a Namespace. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DisasterRecoveryAuthorizationRule" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DisasterRecoveryAuthorizationRule> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DisasterRecoveryAuthorizationRule>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _disasterRecoveryConfigsRestClient.ListAuthorizationRulesAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecoveryAuthorizationRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DisasterRecoveryAuthorizationRule>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DisasterRecoveryAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _disasterRecoveryConfigsRestClient.ListAuthorizationRulesNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DisasterRecoveryAuthorizationRule(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<DisasterRecoveryAuthorizationRule> IEnumerable<DisasterRecoveryAuthorizationRule>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DisasterRecoveryAuthorizationRule> IAsyncEnumerable<DisasterRecoveryAuthorizationRule>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DisasterRecoveryAuthorizationRule, AuthorizationRuleData> Construct() { }
    }
}
