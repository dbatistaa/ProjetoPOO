using System.IO;
using System.Text.Json;
using trabalhoPOO.Models.Entidades;

namespace trabalhoPOO.Models.Repositorio
{
    public class UserRepository
    {
        #region Fields

        private readonly string _basePath = Path.Combine("." + Path.DirectorySeparatorChar, "Data");
        private readonly string _usersFile;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        public UserRepository()
        {
            _usersFile = Path.Combine(_basePath, "users.json");

            // Ensure the file exists to avoid null or file not found issues
            if (!File.Exists(_usersFile))
            {
                File.WriteAllText(_usersFile, "[]"); // Initialize with empty JSON array
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Gets a <see cref="User"/> by username.
        /// </summary>
        /// <param name="username">The username to search for.</param>
        /// <returns>The <see cref="User"/> if found; otherwise, <c>null</c>.</returns>
        public Utilizador? GetUserByUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                return null;
            }

            List<Utilizador> users = LoadUsers();
            return users.FirstOrDefault(x => x.Username == username);
        }

        /// <summary>
        /// Loads the users from the JSON file.
        /// </summary>
        /// <returns>A list of <see cref="User"/> entities.</returns>
        private List<Utilizador> LoadUsers()
        {
            try
            {
                string readJsonString = File.ReadAllText(_usersFile);
                return JsonSerializer.Deserialize<List<Utilizador>>(readJsonString) ?? new List<Utilizador>();
            }
            catch (IOException)
            {
                // Log exception if needed
                return new List<Utilizador>();
            }
            catch (Exception)
            {
                // Log exception if needed
                return new List<Utilizador>();
            }
        }

        #endregion
    }
}
