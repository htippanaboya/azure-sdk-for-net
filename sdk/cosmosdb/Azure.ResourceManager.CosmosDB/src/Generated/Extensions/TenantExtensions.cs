// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class to add extension methods to Tenant. </summary>
    public static partial class TenantExtensions
    {
        private static DatabaseAccountsRestOperations GetDatabaseAccountsRestOperations(ClientDiagnostics clientDiagnostics, TokenCredential credential, ArmClientOptions clientOptions, HttpPipeline pipeline, Uri endpoint = null)
        {
            return new DatabaseAccountsRestOperations(clientDiagnostics, pipeline, clientOptions, endpoint);
        }

        /// <summary> Checks that the Azure Cosmos DB account name already exists. A valid account name may contain only lowercase letters, numbers, and the &apos;-&apos; character, and must be between 3 and 50 characters. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public static async Task<Response<bool>> CheckNameExistsDatabaseAccountAsync(this Tenant tenant, string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            return await tenant.UseClientContext(async (baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("TenantExtensions.CheckNameExistsDatabaseAccount");
                scope.Start();
                try
                {
                    var restOperations = GetDatabaseAccountsRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                    var response = await restOperations.CheckNameExistsAsync(accountName, cancellationToken).ConfigureAwait(false);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            ).ConfigureAwait(false);
        }

        /// <summary> Checks that the Azure Cosmos DB account name already exists. A valid account name may contain only lowercase letters, numbers, and the &apos;-&apos; character, and must be between 3 and 50 characters. </summary>
        /// <param name="tenant"> The <see cref="Tenant" /> instance the method will execute against. </param>
        /// <param name="accountName"> Cosmos DB database account name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/> is null. </exception>
        public static Response<bool> CheckNameExistsDatabaseAccount(this Tenant tenant, string accountName, CancellationToken cancellationToken = default)
        {
            if (accountName == null)
            {
                throw new ArgumentNullException(nameof(accountName));
            }

            return tenant.UseClientContext((baseUri, credential, options, pipeline) =>
            {
                var clientDiagnostics = new ClientDiagnostics(options);
                using var scope = clientDiagnostics.CreateScope("TenantExtensions.CheckNameExistsDatabaseAccount");
                scope.Start();
                try
                {
                    var restOperations = GetDatabaseAccountsRestOperations(clientDiagnostics, credential, options, pipeline, baseUri);
                    var response = restOperations.CheckNameExists(accountName, cancellationToken);
                    return response;
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            );
        }
    }
}
