using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Simbelmawa.Data;
using Simbelmawa.Models.Identity;

namespace Simbelmawa.Identity
{
    public class SimbelmawaUserStore : IUserStore<SimbelmawaUser>, IUserPasswordStore<SimbelmawaUser>
    {
        private readonly PenggunaDbContext _penggunaDbContext;
        private bool disposedValue;

        public SimbelmawaUserStore(PenggunaDbContext penggunaDbContext)
        {
            _penggunaDbContext = penggunaDbContext;
        }

        public Task AddToRoleAsync(SimbelmawaUser user, string roleName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> CreateAsync(SimbelmawaUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> DeleteAsync(SimbelmawaUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<SimbelmawaUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<SimbelmawaUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return Task.Run(() => {
                var identitasPengguna = _penggunaDbContext.IdentitasPengguna
                    .FirstOrDefaultAsync(ip => ip.NamaUser == normalizedUserName, cancellationToken).Result;
                var simbelmawaUser = new SimbelmawaUser {IdentitasPengguna = identitasPengguna};
                return simbelmawaUser;
            }, cancellationToken);
        }

        public Task<string> GetNormalizedUserNameAsync(SimbelmawaUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetPasswordHashAsync(SimbelmawaUser user, CancellationToken cancellationToken)
        {
            return Task.Run(() => user.IdentitasPengguna.Pswd);
        }

        public Task<IList<string>> GetRolesAsync(SimbelmawaUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetUserIdAsync(SimbelmawaUser user, CancellationToken cancellationToken)
        {
            return Task.Run(() => user.IdentitasPengguna.IdPersonal.ToString());
        }

        public Task<string> GetUserNameAsync(SimbelmawaUser user, CancellationToken cancellationToken)
        {
            return Task.Run(() => user.IdentitasPengguna.NamaUser);
        }

        public Task<IList<SimbelmawaUser>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> HasPasswordAsync(SimbelmawaUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> IsInRoleAsync(SimbelmawaUser user, string roleName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task RemoveFromRoleAsync(SimbelmawaUser user, string roleName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetNormalizedUserNameAsync(SimbelmawaUser user, string normalizedName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetPasswordHashAsync(SimbelmawaUser user, string passwordHash, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task SetUserNameAsync(SimbelmawaUser user, string userName, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        public Task<IdentityResult> UpdateAsync(SimbelmawaUser user, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~SimbelmawaUserStore()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            System.GC.SuppressFinalize(this);
        }
    }
}