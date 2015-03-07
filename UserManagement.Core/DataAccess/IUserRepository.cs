using UserManagement.Core.Search;

namespace UserManagement.Core.DataAccess
{
    public interface IUserRepository
    {
        ISearchResult<IUserSearchResultItem> Get(UserSearchCriteria searchCriteria);

        IUser Get(UserId userId);

        IUser CreateUser(INewUserInfo newUserInfo, IUser editor);

        void UpdateUser(IUpdateUserInfo updateUserInfo, IUser editor);
    }
}