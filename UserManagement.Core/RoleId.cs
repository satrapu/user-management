using SemanticTypes;

namespace UserManagement.Core
{
    public class RoleId : SemanticType<int>
    {
        public static bool IsValid(int value)
        {
            var result = value > 0;
            return result;
        }

        public RoleId(int value) : base(IsValid, value)
        {
        }
    }
}