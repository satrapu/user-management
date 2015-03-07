using System.Collections.Generic;

namespace UserManagement.Core
{
    /// <summary>
    /// Represents a specific user responsibility.
    /// It may optionally group several permissions.
    /// </summary>
    public interface IRole
    {
        RoleId Id { get; }

        string Name { get; }

        string Description { get; }

        IList<PermissionId> Permissions { get; }
    }
}