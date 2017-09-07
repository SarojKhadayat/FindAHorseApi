using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindAHorseApiModel;

namespace FindAHorseBusiness.Business
{
    public interface IHorseBoxBusiness
    {
        List<tblHorseBox> GetAllHorseBoxes();
        tblHorseBox GetHorseBoxesById(int id);
        List<tblHorseBox> GetHorseBoxesByBoxOwnerId(int boxOwnerId);
        int AddHorseBox(tblHorseBox horseBox);
    }
}
