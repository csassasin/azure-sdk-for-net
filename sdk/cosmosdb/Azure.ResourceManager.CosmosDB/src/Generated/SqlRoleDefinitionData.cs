// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.CosmosDB.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB
{
    /// <summary> A class representing the SqlRoleDefinition data model. </summary>
    public partial class SqlRoleDefinitionData : ResourceData
    {
        /// <summary> Initializes a new instance of SqlRoleDefinitionData. </summary>
        public SqlRoleDefinitionData()
        {
            AssignableScopes = new ChangeTrackingList<string>();
            Permissions = new ChangeTrackingList<Permission>();
        }

        /// <summary> Initializes a new instance of SqlRoleDefinitionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="roleName"> A user-friendly name for the Role Definition. Must be unique for the database account. </param>
        /// <param name="typePropertiesType"> Indicates whether the Role Definition was built-in or user created. </param>
        /// <param name="assignableScopes"> A set of fully qualified Scopes at or below which Role Assignments may be created using this Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Must have at least one element. Scopes higher than Database account are not enforceable as assignable Scopes. Note that resources referenced in assignable Scopes need not exist. </param>
        /// <param name="permissions"> The set of operations allowed through this Role Definition. </param>
        internal SqlRoleDefinitionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string roleName, RoleDefinitionType? typePropertiesType, IList<string> assignableScopes, IList<Permission> permissions) : base(id, name, resourceType, systemData)
        {
            RoleName = roleName;
            TypePropertiesType = typePropertiesType;
            AssignableScopes = assignableScopes;
            Permissions = permissions;
        }

        /// <summary> A user-friendly name for the Role Definition. Must be unique for the database account. </summary>
        public string RoleName { get; set; }
        /// <summary> Indicates whether the Role Definition was built-in or user created. </summary>
        public RoleDefinitionType? TypePropertiesType { get; set; }
        /// <summary> A set of fully qualified Scopes at or below which Role Assignments may be created using this Role Definition. This will allow application of this Role Definition on the entire database account or any underlying Database / Collection. Must have at least one element. Scopes higher than Database account are not enforceable as assignable Scopes. Note that resources referenced in assignable Scopes need not exist. </summary>
        public IList<string> AssignableScopes { get; }
        /// <summary> The set of operations allowed through this Role Definition. </summary>
        public IList<Permission> Permissions { get; }
    }
}
