using System;
using Microsoft.AspNetCore.Identity;

namespace Simbelmawa.Identity
{
    public class SimbelmawaPasswordHasher : IPasswordHasher<SimbelmawaUser>
    {
        public string HashPassword(SimbelmawaUser user, string password)
        {
            throw new NotImplementedException();
        }

        public PasswordVerificationResult VerifyHashedPassword(SimbelmawaUser user, string hashedPassword, string providedPassword)
        {
            return (hashedPassword == providedPassword) ? PasswordVerificationResult.Success : PasswordVerificationResult.Failed;
        }
    }
}