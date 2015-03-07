namespace UserManagement.Core
{
    public interface ISelfUpdateUserInfo
    {
        string FirstName { get; set; }

        string MiddleName { get; set; }

        string LastName { get; set; }

        EmailAddress EmailAddress { get; set; }

        string Password { get; set; }
    }
}