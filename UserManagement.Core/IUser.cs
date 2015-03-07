using System;
using System.Collections.Generic;
using UserManagement.Core.Search;

namespace UserManagement.Core
{
    public interface IUser
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

        IRole Create(INewRoleInfo newRoleInfo);

        void Update(RoleId roleId, RoleUpdateInfo roleUpdateInfo);

        void GrantRole(IRole role, IEnumerable<UserId> users);

        bool HasPermissions(IEnumerable<PermissionId> permissions);

        bool HasPermission(PermissionId permission);

        IUser Create(INewUserInfo newUserInfo);

        void Update(ISelfUpdateUserInfo selfUpdateUserInfo);

        void Update(UserId userId, IUpdateUserInfo updateUserInfo);

        IUser Get(UserId userId);

        ISearchResult<IUserSearchResultItem> Get(UserSearchCriteria searchCriteria);
    }
}