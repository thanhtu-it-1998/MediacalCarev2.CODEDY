using MedialCare.Models.EF;
using MedialCare.Models.Entities;
using MedialCare.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedialCare.Areas.Account.Data
{
    public class UserDao
    {
        public ApplicationDbContext context;

        public UserDao(ApplicationDbContext _ctx)
        {
            context = _ctx;
        }

        public bool Login(string userName, string password, Level level)
        {
            var res = context.Users.Where(x => x.Username == userName && x.Password == password).Count();
            if (res > 0) return true;
            else return false;
        }
        public User GetByID(string userName)
        {
            return context.Users.SingleOrDefault(x=>x.Username  == userName);
        }
        public int Insert(User entity)
        {
            context.Users.Add(entity);
            context.SaveChanges();
            return entity.ID;
        }
    }
}
