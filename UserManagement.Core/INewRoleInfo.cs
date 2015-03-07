using System.Collections.Generic;

namespace UserManagement.Core
{
    /// <summary>
    /// Represents the data required to create a new role.
    /// </summary>
    public interface INewRoleInfo
    {
        /// <summary>
        /// Gets or sets the tenant to contain the new role.
        /// </summary>
        TenantId TenantId { get; set; }

        /// <summary>
        /// Gets or sets the name of the new role.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the new role.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the permissions to be contained by the new role.
        /// </summary>
        IList<PermissionId> Permissions { get; set; }
    }
}