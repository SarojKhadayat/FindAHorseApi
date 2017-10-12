using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindAHorseApiModel;
using FindAHorseRepository.Repository;
using FindAHorseApiModel.ApiModel;

namespace FindAHorseBusiness.Business
{
    public class HorseBusiness 
    {
        private HorseRepository _horseRepository=new HorseRepository();
        //public HorseBusiness(IHorseRepository horseRepository) {
        //    _horseRepository = horseRepository;
        //}
        public int AddHorse(HorseApiModel horse)
        {
            tblHors newHorse = new tblHors {
                Breed=horse.Breed,
                Color=horse.Color,
                Other=horse.Other,
                Size=horse.Size,
                UserId=horse.UserId
            };
            return _horseRepository.AddHorse(newHorse,horse.ImagePaths);
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
