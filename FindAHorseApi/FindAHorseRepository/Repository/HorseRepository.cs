using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindAHorseApiModel;
namespace FindAHorseRepository.Repository
{
    public class HorseRepository
    {
        private FindAHorseBoxDbEntities _db = new FindAHorseBoxDbEntities();
        public List<tblHors> GetAllHorses()
        {
            return (from horse in _db.tblHorses select horse).ToList();
        }
        public tblHors GetHorseById(int id)
        {
            return (from horse in _db.tblHorses where horse.HorseId == id select horse).FirstOrDefault();
        }
        public List<tblHors> GetHorseByOwnerId(int OwnerId)
        {
            return (from horse in _db.tblHorses where horse.UserId == OwnerId select horse).ToList();
        }
        public int AddHorse(tblHors horse, List<string> ImagePaths)
        {
            _db.tblHorses.Add(horse);
            _db.SaveChanges();
            //foreach (string path in ImagePaths)
            //{
            //    tblHorseImage imagePath = new tblHorseImage
            //    {
            //        HorseId = horse.HorseId,
            //        ImagePath = path
            //    };
            //    _db.tblHorseImages.Add(imagePath);
            //}
            return (horse.HorseId);
        }
    }
}
