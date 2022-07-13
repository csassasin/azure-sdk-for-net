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
using Azure.ResourceManager.CosmosDB.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary>
    /// A Class representing a RestorableCosmosDBAccount along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="RestorableCosmosDBAccountResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetRestorableCosmosDBAccountResource method.
    /// Otherwise you can get one from its parent resource <see cref="CosmosDBLocationResource" /> using the GetRestorableCosmosDBAccount method.
    /// </summary>
    public partial class RestorableCosmosDBAccountResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="RestorableCosmosDBAccountResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, AzureLocation location, string instanceId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics;
        private readonly RestorableDatabaseAccountsRestOperations _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient;
        private readonly ClientDiagnostics _restorableSqlDatabasesClientDiagnostics;
        private readonly RestorableSqlDatabasesRestOperations _restorableSqlDatabasesRestClient;
        private readonly ClientDiagnostics _restorableSqlContainersClientDiagnostics;
        private readonly RestorableSqlContainersRestOperations _restorableSqlContainersRestClient;
        private readonly ClientDiagnostics _restorableSqlResourcesClientDiagnostics;
        private readonly RestorableSqlResourcesRestOperations _restorableSqlResourcesRestClient;
        private readonly ClientDiagnostics _restorableMongoDBDatabasesClientDiagnostics;
        private readonly RestorableMongodbDatabasesRestOperations _restorableMongoDBDatabasesRestClient;
        private readonly ClientDiagnostics _restorableMongoDBCollectionsClientDiagnostics;
        private readonly RestorableMongodbCollectionsRestOperations _restorableMongoDBCollectionsRestClient;
        private readonly ClientDiagnostics _restorableMongoDBResourcesClientDiagnostics;
        private readonly RestorableMongodbResourcesRestOperations _restorableMongoDBResourcesRestClient;
        private readonly RestorableCosmosDBAccountData _data;

        /// <summary> Initializes a new instance of the <see cref="RestorableCosmosDBAccountResource"/> class for mocking. </summary>
        protected RestorableCosmosDBAccountResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "RestorableCosmosDBAccountResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal RestorableCosmosDBAccountResource(ArmClient client, RestorableCosmosDBAccountData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="RestorableCosmosDBAccountResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal RestorableCosmosDBAccountResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string restorableCosmosDBAccountRestorableDatabaseAccountsApiVersion);
            _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient = new RestorableDatabaseAccountsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, restorableCosmosDBAccountRestorableDatabaseAccountsApiVersion);
            _restorableSqlDatabasesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _restorableSqlDatabasesRestClient = new RestorableSqlDatabasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _restorableSqlContainersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _restorableSqlContainersRestClient = new RestorableSqlContainersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _restorableSqlResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _restorableSqlResourcesRestClient = new RestorableSqlResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _restorableMongoDBDatabasesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _restorableMongoDBDatabasesRestClient = new RestorableMongodbDatabasesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _restorableMongoDBCollectionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _restorableMongoDBCollectionsRestClient = new RestorableMongodbCollectionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
            _restorableMongoDBResourcesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDB", ProviderConstants.DefaultProviderNamespace, Diagnostics);
            _restorableMongoDBResourcesRestClient = new RestorableMongodbResourcesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.DocumentDB/locations/restorableDatabaseAccounts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual RestorableCosmosDBAccountData Data
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

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}
        /// Operation Id: RestorableDatabaseAccounts_GetByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<RestorableCosmosDBAccountResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.Get");
            scope.Start();
            try
            {
                var response = await _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient.GetByLocationAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableCosmosDBAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the properties of an existing Azure Cosmos DB restorable database account.  This call requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/read/*&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}
        /// Operation Id: RestorableDatabaseAccounts_GetByLocation
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<RestorableCosmosDBAccountResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _restorableCosmosDBAccountRestorableDatabaseAccountsClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.Get");
            scope.Start();
            try
            {
                var response = _restorableCosmosDBAccountRestorableDatabaseAccountsRestClient.GetByLocation(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RestorableCosmosDBAccountResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Show the event feed of all mutations done on all the Azure Cosmos DB SQL databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableSqlDatabases
        /// Operation Id: RestorableSqlDatabases_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableSqlDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableSqlDatabase> GetRestorableSqlDatabasesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableSqlDatabase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlDatabasesClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableSqlDatabases");
                scope.Start();
                try
                {
                    var response = await _restorableSqlDatabasesRestClient.ListAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Show the event feed of all mutations done on all the Azure Cosmos DB SQL databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableSqlDatabases
        /// Operation Id: RestorableSqlDatabases_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableSqlDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableSqlDatabase> GetRestorableSqlDatabases(CancellationToken cancellationToken = default)
        {
            Page<RestorableSqlDatabase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlDatabasesClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableSqlDatabases");
                scope.Start();
                try
                {
                    var response = _restorableSqlDatabasesRestClient.List(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Show the event feed of all mutations done on all the Azure Cosmos DB SQL containers under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableSqlContainers
        /// Operation Id: RestorableSqlContainers_List
        /// </summary>
        /// <param name="restorableSqlDatabaseRid"> The resource ID of the SQL database. </param>
        /// <param name="startTime"> The snapshot create timestamp after which snapshots need to be listed. </param>
        /// <param name="endTime"> The snapshot create timestamp before which snapshots need to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableSqlContainer" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableSqlContainer> GetRestorableSqlContainersAsync(string restorableSqlDatabaseRid = null, string startTime = null, string endTime = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableSqlContainer>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlContainersClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableSqlContainers");
                scope.Start();
                try
                {
                    var response = await _restorableSqlContainersRestClient.ListAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, restorableSqlDatabaseRid, startTime, endTime, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Show the event feed of all mutations done on all the Azure Cosmos DB SQL containers under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableSqlContainers
        /// Operation Id: RestorableSqlContainers_List
        /// </summary>
        /// <param name="restorableSqlDatabaseRid"> The resource ID of the SQL database. </param>
        /// <param name="startTime"> The snapshot create timestamp after which snapshots need to be listed. </param>
        /// <param name="endTime"> The snapshot create timestamp before which snapshots need to be listed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableSqlContainer" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableSqlContainer> GetRestorableSqlContainers(string restorableSqlDatabaseRid = null, string startTime = null, string endTime = null, CancellationToken cancellationToken = default)
        {
            Page<RestorableSqlContainer> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlContainersClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableSqlContainers");
                scope.Start();
                try
                {
                    var response = _restorableSqlContainersRestClient.List(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, restorableSqlDatabaseRid, startTime, endTime, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Return a list of database and container combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableSqlResources
        /// Operation Id: RestorableSqlResources_List
        /// </summary>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatabaseRestoreResourceInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatabaseRestoreResourceInfo> GetRestorableSqlResourcesAsync(string restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DatabaseRestoreResourceInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlResourcesClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableSqlResources");
                scope.Start();
                try
                {
                    var response = await _restorableSqlResourcesRestClient.ListAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, restoreLocation, restoreTimestampInUtc, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Return a list of database and container combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableSqlResources
        /// Operation Id: RestorableSqlResources_List
        /// </summary>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatabaseRestoreResourceInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatabaseRestoreResourceInfo> GetRestorableSqlResources(string restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            Page<DatabaseRestoreResourceInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableSqlResourcesClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableSqlResources");
                scope.Start();
                try
                {
                    var response = _restorableSqlResourcesRestClient.List(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, restoreLocation, restoreTimestampInUtc, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires  &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableMongodbDatabases
        /// Operation Id: RestorableMongodbDatabases_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableMongoDBDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableMongoDBDatabase> GetRestorableMongoDBDatabasesAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableMongoDBDatabase>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongoDBDatabasesClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableMongoDBDatabases");
                scope.Start();
                try
                {
                    var response = await _restorableMongoDBDatabasesRestClient.ListAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB databases under the restorable account.  This helps in scenario where database was accidentally deleted to get the deletion time.  This API requires  &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableMongodbDatabases
        /// Operation Id: RestorableMongodbDatabases_List
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableMongoDBDatabase" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableMongoDBDatabase> GetRestorableMongoDBDatabases(CancellationToken cancellationToken = default)
        {
            Page<RestorableMongoDBDatabase> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongoDBDatabasesClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableMongoDBDatabases");
                scope.Start();
                try
                {
                    var response = _restorableMongoDBDatabasesRestClient.List(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB collections under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableMongodbCollections
        /// Operation Id: RestorableMongodbCollections_List
        /// </summary>
        /// <param name="restorableMongoDBDatabaseRid"> The resource ID of the MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RestorableMongoDBCollection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RestorableMongoDBCollection> GetRestorableMongoDBCollectionsAsync(string restorableMongoDBDatabaseRid = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<RestorableMongoDBCollection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongoDBCollectionsClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableMongoDBCollections");
                scope.Start();
                try
                {
                    var response = await _restorableMongoDBCollectionsRestClient.ListAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, restorableMongoDBDatabaseRid, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Show the event feed of all mutations done on all the Azure Cosmos DB MongoDB collections under a specific database.  This helps in scenario where container was accidentally deleted.  This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableMongodbCollections
        /// Operation Id: RestorableMongodbCollections_List
        /// </summary>
        /// <param name="restorableMongoDBDatabaseRid"> The resource ID of the MongoDB database. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RestorableMongoDBCollection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RestorableMongoDBCollection> GetRestorableMongoDBCollections(string restorableMongoDBDatabaseRid = null, CancellationToken cancellationToken = default)
        {
            Page<RestorableMongoDBCollection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongoDBCollectionsClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableMongoDBCollections");
                scope.Start();
                try
                {
                    var response = _restorableMongoDBCollectionsRestClient.List(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, restorableMongoDBDatabaseRid, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Return a list of database and collection combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableMongodbResources
        /// Operation Id: RestorableMongodbResources_List
        /// </summary>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DatabaseRestoreResourceInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DatabaseRestoreResourceInfo> GetRestorableMongoDBResourcesAsync(string restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DatabaseRestoreResourceInfo>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongoDBResourcesClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableMongoDBResources");
                scope.Start();
                try
                {
                    var response = await _restorableMongoDBResourcesRestClient.ListAsync(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, restoreLocation, restoreTimestampInUtc, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
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
        /// Return a list of database and collection combo that exist on the account at the given timestamp and location. This helps in scenarios to validate what resources exist at given timestamp and location. This API requires &apos;Microsoft.DocumentDB/locations/restorableDatabaseAccounts/.../read&apos; permission.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DocumentDB/locations/{location}/restorableDatabaseAccounts/{instanceId}/restorableMongodbResources
        /// Operation Id: RestorableMongodbResources_List
        /// </summary>
        /// <param name="restoreLocation"> The location where the restorable resources are located. </param>
        /// <param name="restoreTimestampInUtc"> The timestamp when the restorable resources existed. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DatabaseRestoreResourceInfo" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DatabaseRestoreResourceInfo> GetRestorableMongoDBResources(string restoreLocation = null, string restoreTimestampInUtc = null, CancellationToken cancellationToken = default)
        {
            Page<DatabaseRestoreResourceInfo> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _restorableMongoDBResourcesClientDiagnostics.CreateScope("RestorableCosmosDBAccountResource.GetRestorableMongoDBResources");
                scope.Start();
                try
                {
                    var response = _restorableMongoDBResourcesRestClient.List(Id.SubscriptionId, new AzureLocation(Id.Parent.Name), Id.Name, restoreLocation, restoreTimestampInUtc, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }
    }
}
