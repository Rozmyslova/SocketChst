using SocketChat.Common.Entities;

namespace SocketChat.DAL.Repositories
{
    public static class UserRepository
    {
        private static List<User> users = new List<User>();

        public static async Task <List<User>> GetAll()
        {
            return users;
        }

        public static async Task AddUser(User user)
        {
           users.Add(user);
        }
        //private static List<User> users = new List<User>();

        //public static List<User> GetAll()
        //{
        //    return users;
        //}

        //public static void AddUser(User user)
        //{
        //    users.Add(user);
        //}
    }
}
