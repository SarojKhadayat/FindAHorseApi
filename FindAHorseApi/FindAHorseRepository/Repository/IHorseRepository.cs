using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindAHorseApiModel;
namespace FindAHorseRepository.Repository
{
    public interface IHorseRepository
    {
        List<tblHors> GetAllHorses();
        tblHors GetHorseById(int id);
        List<tblHors> GetHorseByOwnerId(int ownerId);
        int AddHorse(tblHors horse);
    }
}
