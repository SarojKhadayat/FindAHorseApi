using FindAHorseApiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAHorseRepository.Repository
{
    public interface IHorseBoxRepository
    {
        List<tblHorseBox> GetAllHorseBoxes();
        tblHorseBox GetHorseBoxesById(int id);
        List<tblHorseBox> GetHorseBoxesByBoxOwnerId(int boxOwnerId);
        int AddHorseBox(tblHorseBox horseBox);
    }
}
