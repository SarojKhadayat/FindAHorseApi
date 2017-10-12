using FindAHorseApiModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAHorseRepository.Repository
{
    public class HorseBoxRepository
    {
        private FindAHorseBoxDbEntities _db = new FindAHorseBoxDbEntities();
        public List<tblHorseBox> GetAllHorseBoxes()
        {
            return (from horseBoxes in _db.tblHorseBoxes select horseBoxes).ToList();
        }
        public tblHorseBox GetHorseBoxesById(int id)
        {
            return (from horseBox in _db.tblHorseBoxes where horseBox.HorseBoxId == id select horseBox).FirstOrDefault();
        }
        public List<tblHorseBox> GetHorseBoxesByBoxOwnerId(int boxOwnerId)
        {
            return (from horseBox in _db.tblHorseBoxes where horseBox.UserId == boxOwnerId select horseBox).ToList();
        }
        public List<tblHorseBox> GetHorseBoxByAddress(string addressText)
        {
            return _db.tblHorseBoxes.Where(x => x.tblUser.Country.ToLower().Contains(addressText) || x.tblUser.TownOrCity.ToLower().Contains(addressText)
            || x.tblUser.PostCode.Contains(addressText)).ToList();
        }
        public int AddHorseBox(tblHorseBox horseBox, List<string> imagePaths)
        {
            _db.tblHorseBoxes.Add(horseBox);
            _db.SaveChanges();
            //foreach (string imagePath in imagePaths)
            //{
            //    tblHorseBoxImage horseBoxImage = new tblHorseBoxImage
            //    {
            //        HorseBoxId = horseBox.HorseBoxId,
            //        ImagePath = imagePath
            //    };
            //    _db.tblHorseBoxImages.Add(horseBoxImage);
            //}
            _db.SaveChanges();
            return horseBox.HorseBoxId;
        }
        public tblHorseBox GetTransporterDetails(int id) {
          return  _db.tblHorseBoxes.Where(x => x.HorseBoxId == id).FirstOrDefault();
        }
    }
}
