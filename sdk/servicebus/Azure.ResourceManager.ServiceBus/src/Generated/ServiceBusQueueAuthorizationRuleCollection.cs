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

namespace Azure.ResourceManager.ServiceBus
{
    /// <summary>
    /// A class representing a collection of <see cref="ServiceBusQueueAuthorizationRuleResource" /> and their operations.
    /// Each <see cref="ServiceBusQueueAuthorizationRuleResource" /> in the collection will belong to the same instance of <see cref="ServiceBusQueueResource" />.
    /// To get a <see cref="ServiceBusQueueAuthorizationRuleCollection" /> instance call the GetServiceBusQueueAuthorizationRules method from an instance of <see cref="ServiceBusQueueResource" />.
    /// </summary>
    public partial class ServiceBusQueueAuthorizationRuleCollection : ArmCollection, IEnumerable<ServiceBusQueueAuthorizationRuleResource>, IAsyncEnumerable<ServiceBusQueueAuthorizationRuleResource>
    {
        private readonly ClientDiagnostics _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics;
        private readonly QueueAuthorizationRulesRestOperations _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient;

        /// <summary> Initializes a new instance of the <see cref="ServiceBusQueueAuthorizationRuleCollection"/> class for mocking. </summary>
        protected ServiceBusQueueAuthorizationRuleCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ServiceBusQueueAuthorizationRuleCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ServiceBusQueueAuthorizationRuleCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ServiceBus", ServiceBusQueueAuthorizationRuleResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ServiceBusQueueAuthorizationRuleResource.ResourceType, out string serviceBusQueueAuthorizationRuleQueueAuthorizationRulesApiVersion);
            _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient = new QueueAuthorizationRulesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, serviceBusQueueAuthorizationRuleQueueAuthorizationRulesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ServiceBusQueueResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ServiceBusQueueResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates an authorization rule for a queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ServiceBusQueueAuthorizationRuleResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string authorizationRuleName, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusQueueAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ServiceBusArmOperation<ServiceBusQueueAuthorizationRuleResource>(Response.FromValue(new ServiceBusQueueAuthorizationRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates an authorization rule for a queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="data"> The shared access authorization rule. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ServiceBusQueueAuthorizationRuleResource> CreateOrUpdate(WaitUntil waitUntil, string authorizationRuleName, ServiceBusAuthorizationRuleData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusQueueAuthorizationRuleCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, data, cancellationToken);
                var operation = new ServiceBusArmOperation<ServiceBusQueueAuthorizationRuleResource>(Response.FromValue(new ServiceBusQueueAuthorizationRuleResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an authorization rule for a queue by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<ServiceBusQueueAuthorizationRuleResource>> GetAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusQueueAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = await _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusQueueAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an authorization rule for a queue by rule name.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<ServiceBusQueueAuthorizationRuleResource> Get(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusQueueAuthorizationRuleCollection.Get");
            scope.Start();
            try
            {
                var response = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ServiceBusQueueAuthorizationRuleResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets all authorization rules for a queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules
        /// Operation Id: QueueAuthorizationRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ServiceBusQueueAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ServiceBusQueueAuthorizationRuleResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ServiceBusQueueAuthorizationRuleResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusQueueAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusQueueAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ServiceBusQueueAuthorizationRuleResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusQueueAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusQueueAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Gets all authorization rules for a queue.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules
        /// Operation Id: QueueAuthorizationRules_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ServiceBusQueueAuthorizationRuleResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ServiceBusQueueAuthorizationRuleResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ServiceBusQueueAuthorizationRuleResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusQueueAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusQueueAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ServiceBusQueueAuthorizationRuleResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusQueueAuthorizationRuleCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ServiceBusQueueAuthorizationRuleResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusQueueAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = await _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/namespaces/{namespaceName}/queues/{queueName}/authorizationRules/{authorizationRuleName}
        /// Operation Id: QueueAuthorizationRules_Get
        /// </summary>
        /// <param name="authorizationRuleName"> The authorization rule name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="authorizationRuleName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="authorizationRuleName"/> is null. </exception>
        public virtual Response<bool> Exists(string authorizationRuleName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(authorizationRuleName, nameof(authorizationRuleName));

            using var scope = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesClientDiagnostics.CreateScope("ServiceBusQueueAuthorizationRuleCollection.Exists");
            scope.Start();
            try
            {
                var response = _serviceBusQueueAuthorizationRuleQueueAuthorizationRulesRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, authorizationRuleName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ServiceBusQueueAuthorizationRuleResource> IEnumerable<ServiceBusQueueAuthorizationRuleResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ServiceBusQueueAuthorizationRuleResource> IAsyncEnumerable<ServiceBusQueueAuthorizationRuleResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
