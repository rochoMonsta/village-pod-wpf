using VillagePod.Persistence.Models;

namespace VillagePod.Persistence.Services.Interfaces
{
    public interface IEncryptedCredentialService
    {
        public bool SaveEncryptedCredential(AccountCredentialModel accountCredential);

        public AccountCredentialModel? GetEncryptedCredential(string credentialKey);

        public bool DeleteEncryptedCredential(string credentialKey);
    }
}
