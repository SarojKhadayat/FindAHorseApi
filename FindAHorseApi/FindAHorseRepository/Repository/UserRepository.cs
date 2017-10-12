using FindAHorseApiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAHorseRepository.Repository
{
    public class UserRepository
    {
        private FindAHorseBoxDbEntities _db = new FindAHorseBoxDbEntities();
        public List<tblUser> GetAllUsers()
        {
            return (from users in _db.tblUsers select users).ToList();
        }
        public tblUser GetUser(int id)
        {
            return (tblUser)(from user in _db.tblUsers where user.UserId == id select user);
        }
        public tblUser UserLogin(string email, string password, int userType)
        {
            tblUser dbUser = (from user in _db.tblUsers where user.Email == email && user.Password == password && user.UserType == userType select user).FirstOrDefault();
            return dbUser;
        }
        public int CreateUser(tblUser user)
        {
            _db.tblUsers.Add(user);
            _db.SaveChanges();
            return user.UserId;
        }
        public bool CheckIfUserExist(string email, int userType)
        {
            var user = _db.tblUsers.Where(x => x.Email == email && x.UserType == userType).FirstOrDefault();
            return user != null ? true : false;
        }
    }
}
