using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindAHorseApiModel;
using FindAHorseRepository.Repository;
namespace FindAHorseBusiness.Business
{
    public class HorseBusiness : IHorseBusiness
    {
        private HorseRepository _horseRepository=new HorseRepository();
        //public HorseBusiness(IHorseRepository horseRepository) {
        //    _horseRepository = horseRepository;
        //}
        public int AddHorse(tblHors horse)
        {
            return _horseRepository.AddHorse(horse);
        }

        public List<tblHors> GetAllHorses()
        {
            return _horseRepository.GetAllHorses();
        }

        public tblHors GetHorseById(int id)
        {
            return _horseRepository.GetHorseById(id);
        }

        public List<tblHors> GetHorseByOwnerId(int ownerId)
        {
            return _horseRepository.GetHorseByOwnerId(ownerId);
        }
    }
}
