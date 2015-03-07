using System;

namespace UserManagement.Core
{
    /// <summary>
    /// Represents the data required to create a new user.
    /// </summary>
    public interface INewUserInfo
    {
        TenantId TenantId { get; set; }

        string UserName { get; set; }

        string FirstName { get; set; }

        string MiddleName { get; set; }

        string LastName { get; set; }

        EmailAddress Email { get; set; }

        string Password { get; set; }

        DateTime ActiveFrom { get; set; }

        DateTime ActiveTo { get; set; }
    }
}