using System;

namespace Users.Repository
{
    public class UserRepository
    {
        public int AddUser(Domain.Entities.Users user)
        {
            //Context add user

            var rnd = new Random();
            return rnd.Next(1, 100);
        }
    }
}