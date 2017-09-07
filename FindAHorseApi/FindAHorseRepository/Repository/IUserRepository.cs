
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindAHorseApiModel;

namespace FindAHorseRepository.Repository
{
    public interface IUserRepository
    {
        List<tblUser> GetAllUsers();
        tblUser GetUser(int id);
        bool UserLogin(string email, string password);
        int CreateUser(tblUser user,int userTypeId);
    }
}
