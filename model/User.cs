/*

Module Name: User
Description: Class to create and interact with individual player data.
Date Created: 02/18/16
Author: Shawn Moore

Module Name: Users
Description: Class to save, read, update and delete total players data.
Date Created: 02/18/16
Author: Shawn Moore

*/

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PitchPerfect.model
{
    // Data Class used to Read, Update, Delete from user JSON data file.
    public static class Users
    {
        #region fields
        // Path to the User.json data. 
        public static readonly string UserPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"../../data/user.json");
        // Transform User.json data into List of User objects.
        // JSON object to c# User object uses: default (empty constructor) and property setters.
        private static List<User> _userList = JsonConvert.DeserializeObject<List<User>>(File.ReadAllText(UserPath));
        #endregion

        #region properties (getters/setters)
        // Getter and setter for full list of users.
        public static List<User> UserList { get { return _userList; } set { _userList = value; } }
        #endregion

        #region methods
        // Get single user by ID.
        public static User GetUser(int id)
        {
            User user = _userList.SingleOrDefault(x => x.Id == id);
            return user;
        }

        // Get single user by Name.
        public static User GetUser(string name)
        {
            User user = _userList.SingleOrDefault(x => x.Name == name);
            return user;
        }

        // Add single user to full list of users.
        public static bool AddUser(User user)
        {
            if (!_userList.Exists(x => x.Name == user.Name))
            {
                _userList.Add(user);
                return true;
            }
            return false;
        }

        // Update single user in full list of users.
        public static bool UpdateUser(User user)
        {
            User userFromList = _userList.SingleOrDefault(x => x.Id == user.Id);
            int index = _userList.IndexOf(userFromList);

            if (index > -1)
            {
                _userList[index] = user;
                return true;
            }
            return false;
        }

        // Remove single user from full list of users.
        public static bool RemoveUser(User user)
        {
            User userFromList = _userList.SingleOrDefault(x => x.Id == user.Id);
            if (userFromList != null)
            {
                _userList.Remove(userFromList);
                return true;
            }
            return false;
        }

        // Write the current user list to the JSON data file.
        public static void Save()
        {
            File.WriteAllText(UserPath, JsonConvert.SerializeObject(_userList, Formatting.Indented));
        }

        // Clear the user JSON data file.
        public static void EraseAllUsers()
        {
            _userList.Clear();
            File.WriteAllText(UserPath, JsonConvert.SerializeObject(_userList, Formatting.Indented));
        }

        // Get the total count of users within the full list of users.
        public static int GetUserCount()
        {
            return _userList.Count;
        }
        #endregion
    }

    // Class used to create and operate individual users.
    public class User
    {
        #region fields
        private string _name;
        private int _id;
        private int _highScores;
        #endregion

        #region properties (getters/setters)
        public string Name { get { return _name; } set { _name = value; } }
        public int Id { get { return _id; } set { _id = value; } }
        public int HighScores { get { return _highScores; } set { _highScores = value; } }
        #endregion

        #region constructors
        // Default constructor.
        public User() { }

        // Constructor overloaded with name parameter.
        // Other properties are determined by the application.
        public User(string name)
        {
            _name = name;
            _id = NewId();
            _highScores = 0;
        }
        #endregion

        #region methods
        

        // Create auto-incrementing ID for new User.
        private int NewId()
        {
            int newId = 1;

            if (Users.UserList == null)
            {
                throw new System.Exception("User List is Null");
            }

            if (Users.GetUserCount() > 0)
            {
                newId = Users.GetUserCount() + 1;
            }

            return newId;
        }
        #endregion
    }
}