using FindAHorseApiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAHorseRepository.Repository
{
    public class UserRepository:IUserRepository
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
        public bool UserLogin(string email, string password)
        {
            var dbUser = (from user in _db.tblUsers where user.Email == email && user.Password == password select user).FirstOrDefault();
            return dbUser != null ? true : false;
        }
        public int CreateUser(tblUser user,int userTypeId)
        {
            _db.tblUsers.Add(user);
            int userId=_db.SaveChanges();
            tblUserMapper userType = new tblUserMapper { UserId = userId, UserTypeId = userTypeId };
            _db.tblUserMappers.Add(userType);
            _db.SaveChanges();
            return userId;
        }
    }
}
