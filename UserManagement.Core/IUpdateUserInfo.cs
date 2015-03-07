using System;

namespace UserManagement.Core
{
    public interface IUpdateUserInfo
    {
        string FirstName { get; set; }

        string MiddleName { get; set; }

        string LastName { get; set; }

        EmailAddress EmailAddress { get; set; }

        string Password { get; set; }

        DateTime ActiveFrom { get; set; }

        DateTime ActiveTo { get; set; }
    }
}