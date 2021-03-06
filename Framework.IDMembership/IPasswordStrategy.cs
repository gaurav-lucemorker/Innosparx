﻿namespace Framework.IDMembership
{
    /// <summary>
    /// Used to handle passwords.
    /// </summary>
    public interface IPasswordStrategy
    {
        /// <summary>
        /// Gets if passwords can be decrypted.
        /// </summary>
        bool IsPasswordsDecryptable { get; }

        /// <summary>
        /// Encrypt a password
        /// </summary>
        /// <param name="account">Account information used to encrypt password</param>
        /// <returns>encrypted password.</returns>
        /// <remarks>You can set the salt property which exist in the account information. 
        /// Encryption can be one way (hashing) or regular encryption</remarks>
        string Encrypt(AccountPasswordInfo account);

        /// <summary>
        /// Decrypt a password
        /// </summary>
        /// <param name="password">Encrpted password</param>
        /// <param name="passwordSalt">The password salt.</param>
        /// <returns>
        /// Decrypted password if decryption is possible; otherwise null.
        /// </returns>
        string Decrypt(string password, string passwordSalt);

        /// <summary>
        /// Generate a new password
        /// </summary>
        /// <param name="policy">Policy that should be used when generating a new password.</param>
        /// <returns>A password which is not encrypted.</returns>
        string GeneratePassword(IAccountPolicy policy);

        /// <summary>
        /// Compare if the specified password matches the encrypted password
        /// </summary>
        /// <param name="account">Stored acount informagtion.</param>
        /// <param name="clearTextPassword">Password specified by user.</param>
        /// <returns>true if passwords match; otherwise null</returns>
        /// <remarks>
        /// Method exists to make it possible to compare the password that the user have written
        /// with the one that have been stored in a database.
        /// </remarks>
        bool Compare(AccountPasswordInfo account, string clearTextPassword);

        /// <summary>
        /// Checks if the specified password is valid
        /// </summary>
        /// <param name="password">Password being checked</param>
        /// <param name="accountPolicy">Policy used to validate password.</param>
        /// <returns></returns>
        bool IsValid(string password, IAccountPolicy accountPolicy);
    }
}
