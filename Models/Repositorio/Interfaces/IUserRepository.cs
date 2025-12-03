//-----------------------------------------------------------------
//    <copyright file="Helper.cs" company="IPCA">
//     Copyright IPCA-EST. All rights reserved.
//    </copyright>
//    <date>13-10-2025</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Ernesto Casanova</author>
//-----------------------------------------------------------------

using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.Models.Repositorio.Interfaces
{
    /// <summary>
    /// Defines the contract for user data access operations.
    /// </summary>
    public interface IUserRepository
    {
        #region Methods

        /// <summary>
        /// Retrieves a <see cref="User"/> by its username.
        /// </summary>
        /// <param name="username">The username of the user to retrieve.</param>
        /// <returns>The <see cref="User"/> if found; otherwise, <c>null</c>.</returns>
        Utilizador? GetUserByUsername(string username);

        #endregion
    }
}
