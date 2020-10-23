using Microsoft.AspNetCore.Identity;

namespace Simbelmawa.Identity
{
    public class BypassNormalizer : ILookupNormalizer
    {
        public string Normalize(string key)
        {
            return key;
        }

        public string NormalizeEmail(string email)
        {
            return email.ToLower();
        }

        public string NormalizeName(string name)
        {
            return name;
        }
    }
}
