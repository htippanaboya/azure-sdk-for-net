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
using Azure.ResourceManager.Consumption.Models;

namespace Azure.ResourceManager.Consumption
{
    /// <summary>
    /// A class extending from the SubscriptionBillingPeriodResource in Azure.ResourceManager.Consumption along with the instance operations that can be performed on it.
    /// You can only construct a <see cref="SubscriptionBillingPeriodConsumptionResource" /> from a <see cref="ResourceIdentifier" /> with a resource type of Microsoft.Billing/billingPeriods.
    /// </summary>
    public partial class SubscriptionBillingPeriodConsumptionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SubscriptionBillingPeriodConsumptionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="billingPeriodName"> The billingPeriodName. </param>
        internal static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string billingPeriodName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _priceSheetClientDiagnostics;
        private readonly PriceSheetRestOperations _priceSheetRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionBillingPeriodConsumptionResource"/> class for mocking. </summary>
        protected SubscriptionBillingPeriodConsumptionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionBillingPeriodConsumptionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionBillingPeriodConsumptionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _priceSheetClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Consumption", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _priceSheetRestClient = new PriceSheetRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Billing/billingPeriods";

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the price sheet for a scope by subscriptionId and billing period. Price sheet is available via this API only for May 1, 2014 or later.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}/providers/Microsoft.Consumption/pricesheets/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PriceSheet_GetByBillingPeriod</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the properties/meterDetails within a price sheet. By default, these fields are not included when returning price sheet. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the top N results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PriceSheetResult>> GetPriceSheetAsync(string expand = null, string skipToken = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _priceSheetClientDiagnostics.CreateScope("SubscriptionBillingPeriodConsumptionResource.GetPriceSheet");
            scope.Start();
            try
            {
                var response = await _priceSheetRestClient.GetByBillingPeriodAsync(Id.SubscriptionId, Id.Name, expand, skipToken, top, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the price sheet for a scope by subscriptionId and billing period. Price sheet is available via this API only for May 1, 2014 or later.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Billing/billingPeriods/{billingPeriodName}/providers/Microsoft.Consumption/pricesheets/default</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PriceSheet_GetByBillingPeriod</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expand"> May be used to expand the properties/meterDetails within a price sheet. By default, these fields are not included when returning price sheet. </param>
        /// <param name="skipToken"> Skiptoken is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skiptoken parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the top N results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PriceSheetResult> GetPriceSheet(string expand = null, string skipToken = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _priceSheetClientDiagnostics.CreateScope("SubscriptionBillingPeriodConsumptionResource.GetPriceSheet");
            scope.Start();
            try
            {
                var response = _priceSheetRestClient.GetByBillingPeriod(Id.SubscriptionId, Id.Name, expand, skipToken, top, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
