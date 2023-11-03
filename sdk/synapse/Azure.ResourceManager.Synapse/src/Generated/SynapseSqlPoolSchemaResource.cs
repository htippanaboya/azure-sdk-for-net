// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A Class representing a SynapseSqlPoolSchema along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SynapseSqlPoolSchemaResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSynapseSqlPoolSchemaResource method.
    /// Otherwise you can get one from its parent resource <see cref="SynapseSqlPoolResource" /> using the GetSynapseSqlPoolSchema method.
    /// </summary>
    public partial class SynapseSqlPoolSchemaResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SynapseSqlPoolSchemaResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="sqlPoolName"> The sqlPoolName. </param>
        /// <param name="schemaName"> The schemaName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string sqlPoolName, string schemaName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics;
        private readonly SqlPoolSchemasRestOperations _synapseSqlPoolSchemaSqlPoolSchemasRestClient;
        private readonly SynapseSqlPoolSchemaData _data;

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolSchemaResource"/> class for mocking. </summary>
        protected SynapseSqlPoolSchemaResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SynapseSqlPoolSchemaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SynapseSqlPoolSchemaResource(ArmClient client, SynapseSqlPoolSchemaData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolSchemaResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SynapseSqlPoolSchemaResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string synapseSqlPoolSchemaSqlPoolSchemasApiVersion);
            _synapseSqlPoolSchemaSqlPoolSchemasRestClient = new SqlPoolSchemasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseSqlPoolSchemaSqlPoolSchemasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Synapse/workspaces/sqlPools/schemas";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual SynapseSqlPoolSchemaData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of SynapseSqlPoolTableResources in the SynapseSqlPoolSchema. </summary>
        /// <returns> An object representing collection of SynapseSqlPoolTableResources and their operations over a SynapseSqlPoolTableResource. </returns>
        public virtual SynapseSqlPoolTableCollection GetSynapseSqlPoolTables()
        {
            return GetCachedClient(client => new SynapseSqlPoolTableCollection(client, Id));
        }

        /// <summary>
        /// Get Sql pool table
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTables_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<SynapseSqlPoolTableResource>> GetSynapseSqlPoolTableAsync(string tableName, CancellationToken cancellationToken = default)
        {
            return await GetSynapseSqlPoolTables().GetAsync(tableName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get Sql pool table
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}/tables/{tableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolTables_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="tableName"> The name of the table. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="tableName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="tableName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<SynapseSqlPoolTableResource> GetSynapseSqlPoolTable(string tableName, CancellationToken cancellationToken = default)
        {
            return GetSynapseSqlPoolTables().Get(tableName, cancellationToken);
        }

        /// <summary>
        /// Get Sql Pool schema
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSchemas_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SynapseSqlPoolSchemaResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics.CreateScope("SynapseSqlPoolSchemaResource.Get");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolSchemaSqlPoolSchemasRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Sql Pool schema
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}/schemas/{schemaName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPoolSchemas_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SynapseSqlPoolSchemaResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _synapseSqlPoolSchemaSqlPoolSchemasClientDiagnostics.CreateScope("SynapseSqlPoolSchemaResource.Get");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolSchemaSqlPoolSchemasRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolSchemaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
