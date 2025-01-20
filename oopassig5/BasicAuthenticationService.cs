using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopassig5
{
    internal class BasicAuthenticationService: IAuthenticationService
    {
        private readonly Dictionary<string, (string Password, List<string> Roles)> users = new()
    {
        { "admin", ("password123", new List<string> { "Admin", "User" }) },
        { "user", ("userpass", new List<string> { "User" }) }
    };

        public bool AuthenticateUser(string username, string password)
        {
            return users.ContainsKey(username) && users[username].Password == password;
        }
        public bool AuthorizeUser(string username, string role)
        {
            return users.ContainsKey(username) && users[username].Roles.Contains(role);
        }
    }
}
