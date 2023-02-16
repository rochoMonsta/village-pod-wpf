using Meziantou.Framework.Win32;
using System;
using VillagePod.Persistence.Models;
using VillagePod.Persistence.Services.Interfaces;

namespace VillagePod.Persistence.Services
{
    public class EncryptedCredentialService : IEncryptedCredentialService
    {
        public bool DeleteEncryptedCredential(string credentialKey)
        {
            try
            {
                CredentialManager.DeleteCredential(applicationName: credentialKey);
                return true;
            }
            catch(Exception ex)
            {
                // call logger service here
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public AccountCredentialModel? GetEncryptedCredential(string credentialKey)
        {
            try
            {
                var credential = CredentialManager.ReadCredential(applicationName: credentialKey);

                if (credential == null)
                    return null;

                return new AccountCredentialModel()
                {
                    Login = credential.UserName,
                    Password = credential.Password
                };
            }
            catch(Exception ex)
            {
                // call logger service here
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool SaveEncryptedCredential(AccountCredentialModel accountCredential)
        {
            try
            {
                CredentialManager.WriteCredential(
                    applicationName: accountCredential.CredentialKey,
                    userName: accountCredential.Login,
                    secret: accountCredential.Password,
                    comment: null,
                    persistence: CredentialPersistence.LocalMachine);

                return true;
            }
            catch (Exception ex)
            {
                // call logger service here
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
