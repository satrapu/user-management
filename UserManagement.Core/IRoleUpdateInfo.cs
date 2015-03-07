using System.Collections.Generic;

namespace UserManagement.Core
{
    /// <summary>
    /// Represents the data required for a user to update a role.
    /// </summary>
    public class RoleUpdateInfo
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public IList<PermissionId> Permissions { get; set; }
    }
}