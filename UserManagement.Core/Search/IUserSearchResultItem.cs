using System;

namespace UserManagement.Core.Search
{
    public interface IUserSearchResultItem
    {
        UserId Id { get; }

        TenantId TenantId { get; }

        string UserName { get; }

        string FirstName { get; }

        string MiddleName { get; }

        string LastName { get; }

        EmailAddress EmailAddress { get; }

        DateTime ActiveFrom { get; }

        DateTime ActiveTo { get; }

        DateTime CreatedAt { get; }

        DateTime? LastUpdatedAt { get; }
    }
}