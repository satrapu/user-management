using SemanticTypes;

namespace UserManagement.Core
{
    public class UserId : SemanticType<long>
    {
        public static bool IsValid(long value)
        {
            var result = value > 0;
            return result;
        }

        public UserId(long value) : base(IsValid, value)
        {
        }
    }
}