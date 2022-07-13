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

namespace Azure.ResourceManager.AppContainers
{
    /// <summary>
    /// A class representing a collection of <see cref="ContainerAppReplicaResource" /> and their operations.
    /// Each <see cref="ContainerAppReplicaResource" /> in the collection will belong to the same instance of <see cref="ContainerAppRevisionResource" />.
    /// To get a <see cref="ContainerAppReplicaCollection" /> instance call the GetContainerAppReplicas method from an instance of <see cref="ContainerAppRevisionResource" />.
    /// </summary>
    public partial class ContainerAppReplicaCollection : ArmCollection, IEnumerable<ContainerAppReplicaResource>, IAsyncEnumerable<ContainerAppReplicaResource>
    {
        private readonly ClientDiagnostics _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics;
        private readonly ContainerAppsRevisionReplicasRestOperations _containerAppReplicaContainerAppsRevisionReplicasRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContainerAppReplicaCollection"/> class for mocking. </summary>
        protected ContainerAppReplicaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContainerAppReplicaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContainerAppReplicaCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppContainers", ContainerAppReplicaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContainerAppReplicaResource.ResourceType, out string containerAppReplicaContainerAppsRevisionReplicasApiVersion);
            _containerAppReplicaContainerAppsRevisionReplicasRestClient = new ContainerAppsRevisionReplicasRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, containerAppReplicaContainerAppsRevisionReplicasApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ContainerAppRevisionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ContainerAppRevisionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get a replica for a Container App Revision.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{revisionName}/replicas/{replicaName}
        /// Operation Id: ContainerAppsRevisionReplicas_GetReplica
        /// </summary>
        /// <param name="replicaName"> Name of the Container App Revision Replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public virtual async Task<Response<ContainerAppReplicaResource>> GetAsync(string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var scope = _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics.CreateScope("ContainerAppReplicaCollection.Get");
            scope.Start();
            try
            {
                var response = await _containerAppReplicaContainerAppsRevisionReplicasRestClient.GetReplicaAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, replicaName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppReplicaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a replica for a Container App Revision.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{revisionName}/replicas/{replicaName}
        /// Operation Id: ContainerAppsRevisionReplicas_GetReplica
        /// </summary>
        /// <param name="replicaName"> Name of the Container App Revision Replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public virtual Response<ContainerAppReplicaResource> Get(string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var scope = _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics.CreateScope("ContainerAppReplicaCollection.Get");
            scope.Start();
            try
            {
                var response = _containerAppReplicaContainerAppsRevisionReplicasRestClient.GetReplica(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, replicaName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContainerAppReplicaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List replicas for a Container App Revision.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{revisionName}/replicas
        /// Operation Id: ContainerAppsRevisionReplicas_ListReplicas
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerAppReplicaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerAppReplicaResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ContainerAppReplicaResource>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics.CreateScope("ContainerAppReplicaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _containerAppReplicaContainerAppsRevisionReplicasRestClient.ListReplicasAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerAppReplicaResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// List replicas for a Container App Revision.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{revisionName}/replicas
        /// Operation Id: ContainerAppsRevisionReplicas_ListReplicas
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerAppReplicaResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerAppReplicaResource> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ContainerAppReplicaResource> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics.CreateScope("ContainerAppReplicaCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _containerAppReplicaContainerAppsRevisionReplicasRestClient.ListReplicas(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ContainerAppReplicaResource(Client, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{revisionName}/replicas/{replicaName}
        /// Operation Id: ContainerAppsRevisionReplicas_GetReplica
        /// </summary>
        /// <param name="replicaName"> Name of the Container App Revision Replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var scope = _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics.CreateScope("ContainerAppReplicaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _containerAppReplicaContainerAppsRevisionReplicasRestClient.GetReplicaAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, replicaName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.App/containerApps/{containerAppName}/revisions/{revisionName}/replicas/{replicaName}
        /// Operation Id: ContainerAppsRevisionReplicas_GetReplica
        /// </summary>
        /// <param name="replicaName"> Name of the Container App Revision Replica. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="replicaName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="replicaName"/> is null. </exception>
        public virtual Response<bool> Exists(string replicaName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(replicaName, nameof(replicaName));

            using var scope = _containerAppReplicaContainerAppsRevisionReplicasClientDiagnostics.CreateScope("ContainerAppReplicaCollection.Exists");
            scope.Start();
            try
            {
                var response = _containerAppReplicaContainerAppsRevisionReplicasRestClient.GetReplica(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, replicaName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContainerAppReplicaResource> IEnumerable<ContainerAppReplicaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContainerAppReplicaResource> IAsyncEnumerable<ContainerAppReplicaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
