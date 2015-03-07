using System.ComponentModel.DataAnnotations;
using SemanticTypes;

namespace UserManagement.Core
{
    /// <summary>
    /// Represents an e-mail address.
    /// </summary>
    public class EmailAddress : SemanticType<string>
    {
        private static readonly EmailAddressAttribute emailAddressAttribute = new EmailAddressAttribute();

        public static bool IsValid(string value)
        {
            var result = emailAddressAttribute.IsValid(value);
            return result;
        }

        public EmailAddress(string value) : base(IsValid, value)
        {
        }
    }
}