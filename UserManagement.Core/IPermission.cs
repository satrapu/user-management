namespace UserManagement.Core
{
    /// <summary>
    /// Represents a permission a user must have in order to access an application feature or resource.
    /// </summary>
    public interface IPermission
    {
        PermissionId Id { get; }

        string Name { get; }

        string Description { get; }
    }
}