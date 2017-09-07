using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindAHorseApiModel;
namespace FindAHorseBusiness.Business
{
    public interface IHorseBusiness
    {
        List<tblHors> GetAllHorses();
        tblHors GetHorseById(int id);
        List<tblHors> GetHorseByOwnerId(int OwnerId);
        int AddHorse(tblHors horse);
    }
}
