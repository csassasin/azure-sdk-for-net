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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A class representing a collection of <see cref="KubeEnvironmentResource" /> and their operations.
    /// Each <see cref="KubeEnvironmentResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="KubeEnvironmentCollection" /> instance call the GetKubeEnvironments method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class KubeEnvironmentCollection : ArmCollection, IEnumerable<KubeEnvironmentResource>, IAsyncEnumerable<KubeEnvironmentResource>
    {
        private readonly ClientDiagnostics _kubeEnvironmentClientDiagnostics;
        private readonly KubeEnvironmentsRestOperations _kubeEnvironmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="KubeEnvironmentCollection"/> class for mocking. </summary>
        protected KubeEnvironmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="KubeEnvironmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal KubeEnvironmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _kubeEnvironmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", KubeEnvironmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(KubeEnvironmentResource.ResourceType, out string kubeEnvironmentApiVersion);
            _kubeEnvironmentRestClient = new KubeEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, kubeEnvironmentApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Creates or updates a Kubernetes Environment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/kubeEnvironments/{name}
        /// Operation Id: KubeEnvironments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the Kubernetes Environment. </param>
        /// <param name="data"> Configuration details of the Kubernetes Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<KubeEnvironmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string name, KubeEnvironmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kubeEnvironmentClientDiagnostics.CreateScope("KubeEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _kubeEnvironmentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<KubeEnvironmentResource>(new KubeEnvironmentOperationSource(Client), _kubeEnvironmentClientDiagnostics, Pipeline, _kubeEnvironmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Creates or updates a Kubernetes Environment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/kubeEnvironments/{name}
        /// Operation Id: KubeEnvironments_CreateOrUpdate
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="name"> Name of the Kubernetes Environment. </param>
        /// <param name="data"> Configuration details of the Kubernetes Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<KubeEnvironmentResource> CreateOrUpdate(WaitUntil waitUntil, string name, KubeEnvironmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _kubeEnvironmentClientDiagnostics.CreateScope("KubeEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _kubeEnvironmentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, name, data, cancellationToken);
                var operation = new AppServiceArmOperation<KubeEnvironmentResource>(new KubeEnvironmentOperationSource(Client), _kubeEnvironmentClientDiagnostics, Pipeline, _kubeEnvironmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, name, data).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get the properties of a Kubernetes Environment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/kubeEnvironments/{name}
        /// Operation Id: KubeEnvironments_Get
        /// </summary>
        /// <param name="name"> Name of the Kubernetes Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<KubeEnvironmentResource>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _kubeEnvironmentClientDiagnostics.CreateScope("KubeEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _kubeEnvironmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KubeEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the properties of a Kubernetes Environment.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/kubeEnvironments/{name}
        /// Operation Id: KubeEnvironments_Get
        /// </summary>
        /// <param name="name"> Name of the Kubernetes Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<KubeEnvironmentResource> Get(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _kubeEnvironmentClientDiagnostics.CreateScope("KubeEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = _kubeEnvironmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new KubeEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get all the Kubernetes Environments in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/kubeEnvironments
        /// Operation Id: KubeEnvironments_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="KubeEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<KubeEnvironmentResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<KubeEnvironmentResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _kubeEnvironmentClientDiagnostics.CreateScope("KubeEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _kubeEnvironmentRestClient.ListByResourceGroupAsync(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new KubeEnvironmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<KubeEnvironmentResource>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _kubeEnvironmentClientDiagnostics.CreateScope("KubeEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _kubeEnvironmentRestClient.ListByResourceGroupNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new KubeEnvironmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Description for Get all the Kubernetes Environments in a resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/kubeEnvironments
        /// Operation Id: KubeEnvironments_ListByResourceGroup
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="KubeEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<KubeEnvironmentResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<KubeEnvironmentResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _kubeEnvironmentClientDiagnostics.CreateScope("KubeEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _kubeEnvironmentRestClient.ListByResourceGroup(Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new KubeEnvironmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<KubeEnvironmentResource> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _kubeEnvironmentClientDiagnostics.CreateScope("KubeEnvironmentCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _kubeEnvironmentRestClient.ListByResourceGroupNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new KubeEnvironmentResource(Client, value)), response.Value.NextLink, response.GetRawResponse());
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/kubeEnvironments/{name}
        /// Operation Id: KubeEnvironments_Get
        /// </summary>
        /// <param name="name"> Name of the Kubernetes Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _kubeEnvironmentClientDiagnostics.CreateScope("KubeEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _kubeEnvironmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/kubeEnvironments/{name}
        /// Operation Id: KubeEnvironments_Get
        /// </summary>
        /// <param name="name"> Name of the Kubernetes Environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="name"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(name, nameof(name));

            using var scope = _kubeEnvironmentClientDiagnostics.CreateScope("KubeEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _kubeEnvironmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<KubeEnvironmentResource> IEnumerable<KubeEnvironmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<KubeEnvironmentResource> IAsyncEnumerable<KubeEnvironmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
