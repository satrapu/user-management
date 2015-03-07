using SemanticTypes;

namespace UserManagement.Core
{
    public class PermissionId : SemanticType<int>
    {
        public static bool IsValid(int value)
        {
            var result = value > 0;
            return result;
        }

        public PermissionId(int value) : base(IsValid, value)
        {
        }
    }
}