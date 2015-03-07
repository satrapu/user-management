namespace UserManagement.Core
{
    public interface ITenant
    {
        TenantId Id { get; }

        string Name { get; }

        string Description { get; }
    }
}