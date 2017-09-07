using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindAHorseApiModel;
using FindAHorseRepository.Repository;

namespace FindAHorseBusiness.Business
{
    public class HorseBoxBusiness : IHorseBoxBusiness
    {
        private HorseBoxRepository _horseBoxRepository=new HorseBoxRepository();
        //public HorseBoxBusiness(HorseBoxRepository horseBoxRepository) {
        //    _horseBoxRepository = horseBoxRepository;
        //}
        public int AddHorseBox(tblHorseBox horseBox)
        {
            return _horseBoxRepository.AddHorseBox(horseBox);
        }

        public List<tblHorseBox> GetAllHorseBoxes()
        {
            return _horseBoxRepository.GetAllHorseBoxes();
        }

        public List<tblHorseBox> GetHorseBoxesByBoxOwnerId(int boxOwnerId)
        {
            return _horseBoxRepository.GetHorseBoxesByBoxOwnerId(boxOwnerId);
        }

        public tblHorseBox GetHorseBoxesById(int id)
        {
            return _horseBoxRepository.GetHorseBoxesById(id);
        }
    }
}
