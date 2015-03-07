using SemanticTypes;

namespace UserManagement.Core
{
    public class TenantId : SemanticType<int>
    {
        public static bool IsValid(int value)
        {
            var result = value > 0;
            return result;
        }

        public TenantId(int value) : base(IsValid, value)
        {
        }
    }
}