using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_management_system.Security
{
    // I made this class static because I don't want it to be instantiated
    static class UserAuthentication
    {
        // Private dictionary to store user credentials
        private static Dictionary<string, string> users = new Dictionary<string, string>
        {
            { "admin", "1234" }
        };

        // Public method to authenticate users
        public static bool Authenticate(string username, string password)
        {
            username = username.Trim();
            password = password.Trim();

            return users.ContainsKey(username) && users[username] == password;
        }
    }
}
